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
    public partial class AddEditClient : Form
    {
        private string code;

        public AddEditClient(string _code)
        {
            InitializeComponent();

            code = _code;
            Connect.GetItem("client", code);
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["name"];
           tSName.Text = Connect.Items["surname"];
            tPatron.Text = Connect.Items["patronymic"];
            tTel.Text = Connect.Items["tel"]; 
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            
                Connect.EditItem("client", code, tSName.Text, tName.Text, tPatron.Text, tTel.Text, null, 0, null);
                this.Close();
            
        }
    }
}
