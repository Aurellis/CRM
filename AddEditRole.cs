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
    public partial class AddEditRole : Form
    {
        private string code;
        private bool addOrEdit;

        public AddEditRole()
        {
            InitializeComponent();
            addOrEdit = true;
        }

        public AddEditRole(string code)
        {
            this.code = code;
            InitializeComponent();
            addOrEdit = false;
            Connect.GetItem("role", code);
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["Name"];
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text != string.Empty)
            {
                if (addOrEdit)
                {
                    Connect.AddItem("role", tName.Text, null, null, null, null, 0, null);
                    this.Close();
                }
                else
                {
                    Connect.EditItem("role", code, tName.Text, null, null, null, null, 0, null);
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
