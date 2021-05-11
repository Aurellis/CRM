using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class Services : Form
    {
        private string code;

        public Services()
        {
            InitializeComponent();
            dgList.DataSource = Connect.GetList("service");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Наименование";
            dgList.Columns[2].HeaderText = "Стоимость";
            dgList.Columns[3].HeaderText = "Точка";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditService service = new AddEditService();
            service.ShowInTaskbar = false;
            service.FormClosing += Points_FormClosing;
            service.ShowDialog();
        }

        private void Points_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgList.DataSource = null;
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("service");
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                AddEditService service = new AddEditService(code);
                service.ShowInTaskbar = false;
                service.FormClosing += Points_FormClosing;
                service.ShowDialog();
            }
            else
            {
                MessageBox.Show("Требуется выбрать строку в таблице", "Ошибка");
            }
        }
        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code = dgList[0, dgList.CurrentRow.Index].Value.ToString();
        }
    }
}
