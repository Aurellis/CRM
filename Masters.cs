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
    public partial class Masters : Form
    {
        private string code;

        public Masters()
        {
            InitializeComponent();

            dgList.DataSource = Connect.GetList("master");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Имя";
            dgList.Columns[2].HeaderText = "Полное имя";
            dgList.Columns[3].HeaderText = "Точка";
            dgList.Columns[4].HeaderText = "Активен";

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditMaster masters = new AddEditMaster();
            masters.ShowInTaskbar = false;
            masters.FormClosing += Masters_FormClosing;
            masters.ShowDialog();

        }

        private void Masters_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgList.DataSource = null;
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("master");
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                AddEditMaster masters = new AddEditMaster(code);
                masters.ShowInTaskbar = false;
                masters.FormClosing += Masters_FormClosing;
                masters.ShowDialog();
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
