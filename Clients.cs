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

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditClent client = new AddEditClent();
            client.ShowInTaskbar = false;
            //client.FormClosing += Masters_FormClosing;
            client.ShowDialog();
        }
    }
}
