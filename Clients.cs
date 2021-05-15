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
    public partial class Clients : Form
    {
        private string code;

        public Clients()
        {
            InitializeComponent();

            dgList.DataSource = Connect.GetList("client");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Фамилия";
            dgList.Columns[2].HeaderText = "Имя";
            dgList.Columns[3].HeaderText = "Отчество";
            dgList.Columns[4].HeaderText = "Телефон";
        }

     
        private void bEdit_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                AddEditClient client = new AddEditClient(code);
            client.ShowInTaskbar = false;
            client.FormClosing += Client_FormClosing; ;
            client.ShowDialog();
            }
            else
            {
                MessageBox.Show("Требуется выбрать строку в таблице", "Ошибка");
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgList.DataSource = null;
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("client");
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code = dgList[0, dgList.CurrentRow.Index].Value.ToString();
        }
    }
}
