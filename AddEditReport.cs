using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            this.Width = 690;
        }

        public AddEditReport(string item)
        {
            InitializeComponent();
            FontsLoad();
            Connect.GetItem("report",item);
            
            rtbBody.Text = Connect.Items["textbody"];
            tQuery.Text = Connect.Items["sqlbody"];
            tCode.Text = Connect.Items["id"];
            tName.Text = Connect.Items["name"];
            lItems.Items.Add("ObjID");
            this.Width = 690;
            this.item = item;
        }

        public AddEditReport(string item, string code) 
        {            
            InitializeComponent();
            FontsLoad();
            tabBody.Enabled = false;
            
            this.Width = 530; //
            this.code = code;
            this.item = item;

            Connect.GetItem("report", item);
            tName.Text = Connect.Items["name"];
            ParseText(Connect.Items["textbody"], Connect.Items["sqlbody"]);
            

        }

        private void ParseText(string text, string sql)
        {

            Connect.CustomQuery(sql.Replace("ObjId", code));

            foreach (var key in Connect.Items.Keys)
            {
                text = text.Replace(key, Connect.Items[key]);
            }

            rtbBody.Text = text;
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
            if (item == null)
            {
                item = "0";
            }
            
            Connect.Reports(item, code, tName.Text, rtbBody.Text, tQuery.Text);
            this.Close();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage; 
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbBody.Text, rtbBody.Font, Brushes.Black,0,0);
        }
    }
}
