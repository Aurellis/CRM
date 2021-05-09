using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class Card : Form
    {
        public Card(bool createOrEdit)
        {
            InitializeComponent();

            if (createOrEdit)
            {
                AddNewData();
            }
            else
            {
                EditData();
            }
        }

        private void EditData()
        {
            throw new NotImplementedException();
        }

        private void AddNewData()
        {
            if (tClentSName.Text != string.Empty && tClentName.Text != string.Empty && cbMaster.SelectedItem.ToString() != string.Empty && cbService.SelectedItem.ToString() != string.Empty && cbTypeReq.SelectedItem.ToString() != string.Empty)
            {

            }
            else
            {
                MessageBox.Show("Не все данные заполнены!","Ошибка!");
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }
    }
}
