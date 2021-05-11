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
    public partial class AddEditService : Form
    {
        private string code;
        private bool addOrEdit;
        DataTable table = Connect.GetList("point");

        public AddEditService()
        {
            InitializeComponent();
            addOrEdit = true;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbPoints.Items.Add(table.Rows[i][1].ToString());
            }
        }
        public AddEditService(string _code)
        {
            InitializeComponent();
            addOrEdit = false;
            code = _code;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbPoints.Items.Add(table.Rows[i][1].ToString());
            }
            code = _code;
            addOrEdit = false;
            Connect.GetItem("service", code);
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["Name"];
            tPrice.Text = Connect.Items["Price"];
            
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text != string.Empty && tPrice.Text != string.Empty)
            {
                double price;
                if (Double.TryParse(tPrice.Text, out price))
                {
                    if (addOrEdit)
                    {
                        Connect.AddItem("service", tName.Text, price.ToString(), null, null, cbPoints.SelectedItem.ToString(), 0, null);
                        this.Close();
                    }
                    else
                    {
                        Connect.EditItem("service", code, tName.Text, price.ToString(), null, null, cbPoints.SelectedItem.ToString(), 0, null);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Введите правильную стоимость!", "Ошибка");
                }  
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка");
            }
        }
    }
}
