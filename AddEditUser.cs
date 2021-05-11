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
    public partial class AddEditUser : Form
    {
        private string code;
        private bool addOrEdit;
        DataTable points = Connect.GetList("point");
        DataTable roles = Connect.GetList("role");

        public AddEditUser()
        {
            InitializeComponent();
            addOrEdit = true;
            for (int i = 0; i < points.Rows.Count; i++)
            {
                cbPoints.Items.Add(points.Rows[i][1].ToString());
            }
            for (int i = 0; i < roles.Rows.Count; i++)
            {
                cbRole.Items.Add(roles.Rows[i][1].ToString());
            }
        }

        public AddEditUser(string _code)
        {
            InitializeComponent();
            addOrEdit = false;
            code = _code;
            for (int i = 0; i < points.Rows.Count; i++)
            {
                cbPoints.Items.Add(points.Rows[i][1].ToString());
            }
            for (int i = 0; i < roles.Rows.Count; i++)
            {
                cbRole.Items.Add(roles.Rows[i][1].ToString());
            }
            Connect.GetItem("user", code);
            tCode.Text = Connect.Items["id"];
            tLogin.Text = Connect.Items["Login"];
            tName.Text = Connect.Items["UserName"];
            tFullname.Text = Connect.Items["FullName"];
            tPassword.Text = Connect.Items["Password"];
            cbIsActive.Checked = Convert.ToBoolean(Int16.Parse(Connect.Items["isactive"]));
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tLogin.Text != string.Empty && tPassword.Text != string.Empty && tName.Text != string.Empty)
            {
                if (addOrEdit)
                {
                    Connect.AddItem("user", tLogin.Text, tPassword.Text, tName.Text, tFullname.Text, cbPoints.SelectedItem.ToString(), Convert.ToInt16(cbIsActive.Checked), cbRole.SelectedItem.ToString());
                    this.Close();
                }
                else
                {
                    Connect.EditItem("user", code, tLogin.Text, tPassword.Text, tName.Text, tFullname.Text, cbPoints.SelectedItem.ToString(), Convert.ToInt16(cbIsActive.Checked), cbRole.SelectedItem.ToString());
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
