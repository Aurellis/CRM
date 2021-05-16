using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Roles : Form
    {
        private string code;

        public Roles()
        {
            InitializeComponent();

            dgList.DataSource = Connect.GetList("role");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Имя";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditRole role = new AddEditRole();
            role.ShowInTaskbar = false;
            role.FormClosing += Role_FormClosing; 
            role.ShowDialog();
        }

        private void Role_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgList.DataSource = null;
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("role");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Имя";
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                AddEditRole role = new AddEditRole(code);
                role.ShowInTaskbar = false;
                role.FormClosing += Role_FormClosing;
                role.ShowDialog();
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
