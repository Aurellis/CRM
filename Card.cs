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
                Connect.AddCard(
                                          tClentSName.Text, 
                                          tClentName.Text, 
                                          tClientPatron.Text, 
                                          tClientTel.Text, 
                                          cbMaster.SelectedItem.ToString(), 
                                          cbService.SelectedItem.ToString(), 
                                          dtPlanDelivery.Value.ToString("yyyy-MM-dd HH:mm:ss"), 
                                          cbUser.SelectedItem.ToString(), 
                                          cbTypeReq.SelectedItem.ToString(), 
                                          cbIsDone.Checked, 
                                          dtReg.Value.ToString("yyyy-MM-dd HH:mm:ss"), 
                                          tSumToPay.Text, 
                                          tSumPay.Text, 
                                          dtPay.Value.ToString("yyyy-MM-dd HH:mm:ss"), 
                                          cbPayType.SelectedItem.ToString(), 
                                          tPrim.Text, 
                                          Connect.Point_ID
                                          );
            }
            else
            {
                MessageBox.Show("Не все данные заполнены!","Ошибка!");
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            AddNewData();
        }
    }
}
