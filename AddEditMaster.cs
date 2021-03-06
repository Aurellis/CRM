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
        private bool addOrEdit;
        private string code;
        DataTable table = Connect.GetList("point");

        public AddEditMaster()
        {
            InitializeComponent();
            addOrEdit = true;
            

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbPoints.Items.Add(table.Rows[i][1].ToString());
            }
       }

        public AddEditMaster(string _code)
        {
            InitializeComponent();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbPoints.Items.Add(table.Rows[i][1].ToString());
            }
            code = _code;
            addOrEdit = false;
            Connect.GetItem("master",code);
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["Name"];
            tFullName.Text = Connect.Items["FullName"];
            cbPoints.SelectedItem = Connect.Items["Point_ID"];
            cbIsActive.Checked = Convert.ToBoolean(Int16.Parse(Connect.Items["isactive"]));
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text != string.Empty && tFullName.Text != string.Empty && cbPoints.SelectedItem.ToString() != string.Empty)
            {
                if (addOrEdit)
                {
                    Connect.AddItem("master", tName.Text, tFullName.Text, null, null, cbPoints.SelectedItem.ToString(), Convert.ToInt16(cbIsActive.Checked), null);
                    this.Close();
                }
                else
                {
                    Connect.EditItem("master", code, tName.Text, tFullName.Text, null, null, cbPoints.SelectedItem.ToString(), Convert.ToInt16(cbIsActive.Checked), null);
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
