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
            masters.ShowDialog();
            masters.FormClosed += Masters_FormClosed;            
        }

        private void Masters_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("master");
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            AddEditMaster masters = new AddEditMaster(null);
            masters.ShowInTaskbar = false;
            masters.ShowDialog();
            masters.FormClosed += Masters_FormClosed;
        }
    }
}
