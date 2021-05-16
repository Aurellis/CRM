using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            FontsLoad();
            lItems.Items.Add("ObjID");
        }

        public AddEditReport(string item)
        {
            InitializeComponent();
            FontsLoad();
            lItems.Items.Add("ObjID");
            this.item = item;
        }

        public AddEditReport(string item, string code) 
        {            
            InitializeComponent();
            FontsLoad();
            this.code = code;
            this.item = item;
        }

        public void FontsLoad ()
        {
            var fontsCollection = new InstalledFontCollection();
            var ff = fontsCollection.Families;

            foreach (var item in ff)
            {
                tscbFonts.Items.Add(item.Name);
            }
        }

        private void bQuery_Click(object sender, EventArgs e)
        {
            lItems.Clear();
            lItems.Items.Add("ObjID");
            Connect.CustomQuery(tQuery.Text);

            foreach (var item in Connect.Items)
            {
                lItems.Items.Add(item.Key);
            }
            
        }

        private void tscbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbBody.SelectionFont = new Font(tscbFonts.SelectedItem.ToString(), float.Parse(tstSize.Text));
        }

        private void tstSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rtbBody.SelectionFont = new Font(rtbBody.SelectionFont.Name, float.Parse(tstSize.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionFont = new Font(rtbBody.SelectionFont.Name, float.Parse(tstSize.Text), FontStyle.Bold);
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionFont = new Font(rtbBody.SelectionFont.Name, float.Parse(tstSize.Text), FontStyle.Italic);
        }

        private void tsbCrossed_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionFont = new Font(rtbBody.SelectionFont.Name, float.Parse(tstSize.Text), FontStyle.Strikeout);
        }

        private void tsbNormal_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionFont = new Font(rtbBody.SelectionFont.Name, float.Parse(tstSize.Text), FontStyle.Regular);
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionAlignment =  HorizontalAlignment.Left;
        }

        private void tsbCenter_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tsbRight_Click(object sender, EventArgs e)
        {
            rtbBody.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            Connect.Reports();
        }
    }
}
