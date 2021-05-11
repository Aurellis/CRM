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
    public partial class Points : Form
    {
        private string code;

        public Points()
        {
            InitializeComponent();
            dgList.DataSource = Connect.GetList("point");
            dgList.Columns[0].HeaderText = "Код";
            dgList.Columns[1].HeaderText = "Наименование";
            dgList.Columns[2].HeaderText = "Информация";
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditPoints points = new AddEditPoints();
            points.ShowInTaskbar = false; 
            points.FormClosing += Points_FormClosing; 
            points.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                AddEditPoints points = new AddEditPoints(code);
                points.ShowInTaskbar = false;
                points.FormClosing += Points_FormClosing;
                points.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Требуется выбрать строку в таблице","Ошибка");
            }            
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code = dgList[0, dgList.CurrentRow.Index].Value.ToString();
        }

        private void Points_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgList.DataSource = null;
            dgList.Rows.Clear();
            dgList.DataSource = Connect.GetList("point");
        }


    }
}
