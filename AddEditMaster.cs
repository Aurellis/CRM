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
    public partial class AddEditMaster : Form
    {
        public AddEditMaster()
        {
            InitializeComponent();
            Connect.GetItem("master");
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["name"];
            tFullName.Text = Connect.Items["fullname"];
            cbPoints.SelectedItem = Connect.Items["point"];
            //cbIsActive.ToString() = Connect.Items["isactive"];
        }

        public AddEditMaster(object p)
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text != string.Empty && tFullName.Text != string.Empty && cbPoints.SelectedItem.ToString() != string.Empty)
            {
                Connect.AddItemList("master", tName.Text, tFullName.Text, null, null, cbPoints.SelectedItem.ToString(), cbIsActive.Checked, null);
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка");
            }
        }
    }
}
