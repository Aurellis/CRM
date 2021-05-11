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
    public partial class AddEditPoints : Form
    {
        private bool addOrEdit;
        private string itemCode;

        public AddEditPoints()
        {
            InitializeComponent();
            addOrEdit = true;
        }

        public AddEditPoints(string p)
        {
            itemCode = p;
            InitializeComponent();
            addOrEdit = false;
            Connect.GetItem("point", itemCode);
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["Name"];
            tInfo.Text = Connect.Items["Prim"];
        }


        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text != string.Empty )
            {
                if (addOrEdit)
                {
                    Connect.AddItem("point", tName.Text, tInfo.Text, null, null, null, 0, null);
                    this.Close();
                }
                else
                {
                    Connect.EditItem("point", itemCode, tName.Text, tInfo.Text, null, null,null,0,null);
                    this.Close();
                }               
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка");
            }
        }

        
    }
}
