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
    public partial class Reports : Form
    {
        private string item, code;

        public Reports()
        {
            InitializeComponent();
            dgList.DataSource = Connect.GetList("report");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Название";

            bPrint.Enabled = false;
            bPrint.Visible = false;

            bView.Enabled = false;
            bView.Visible = false;

            bSettings.Enabled = true;
            bSettings.Visible = true;

            bAdd.Enabled = true;
            bAdd.Visible = true;
        }

        public Reports(string code)
        {
            InitializeComponent();
            this.code = code;
            dgList.DataSource = Connect.GetList("report");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Название";


            bPrint.Enabled = true;
            bPrint.Visible = true;

            bView.Enabled = true;
            bView.Visible = true;

            bSettings.Enabled = false;
            bSettings.Visible = false;

            bAdd.Enabled = false;
            bAdd.Visible = false;
        }

        private void bView_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                AddEditReport viewReport = new AddEditReport(item, code);
                viewReport.ShowInTaskbar = false;
                viewReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите форму из списка.", "Ошибка!");
            }
        }       

        private void bSettings_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                AddEditReport viewReport = new AddEditReport(item);
                viewReport.ShowInTaskbar = false;
                viewReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите форму из списка.", "Ошибка!");
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditReport viewReport = new AddEditReport();
            viewReport.ShowInTaskbar = false;
            viewReport.ShowDialog();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                AddEditReport viewReport = new AddEditReport(item, code);
                viewReport.ShowInTaskbar = false;
                viewReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите форму из списка.", "Ошибка!");
            }
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item = dgList[0, dgList.CurrentRow.Index].Value.ToString();
        }
        
    }
}
