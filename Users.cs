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
    public partial class Users : Form
    {
        private string code;

        public Users()
        {
            InitializeComponent();
            dgList.DataSource = Connect.GetList("user");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Логин";
            dgList.Columns[2].HeaderText = "Пароль";
            dgList.Columns[2].Visible = false;
            dgList.Columns[3].HeaderText = "Имя";
            dgList.Columns[4].HeaderText = "Полное имя";
            dgList.Columns[5].HeaderText = "Точка";
            dgList.Columns[6].HeaderText = "Права";
            dgList.Columns[7].HeaderText = "Активен";
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code = dgList[0, dgList.CurrentRow.Index].Value.ToString();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditUser user = new AddEditUser();
            user.ShowInTaskbar = false;
            user.FormClosing += User_FormClosing;
            user.ShowDialog();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgList.DataSource = null;
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("user");
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                AddEditUser user = new AddEditUser(code);
                user.ShowInTaskbar = false;
                user.FormClosing += User_FormClosing;
                user.ShowDialog();
            }
            else
            {
                MessageBox.Show("Требуется выбрать строку в таблице", "Ошибка");
            }
        }
    }
}
