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
    public partial class AddEditReport : Form
    {
        private string item;
        private string code;

        public AddEditReport()
        {
            InitializeComponent();
        }

        public AddEditReport(string item)
        {
            InitializeComponent();
            this.item = item;
        }

        public AddEditReport(string item, string code) 
        {
            InitializeComponent();
            this.code = code;
            this.item = item;
        }
    }
}
