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
        private bool mode = false;
        string id;
        DataTable service = Connect.GetList("service");
        DataTable master = Connect.GetList("master");
        DataTable user = Connect.GetList("user");
        DataTable reqtype = Connect.GetList("reqtype");
        DataTable paytype = Connect.GetList("paytype");
        private bool editState;

        public Card(string code)
        {
            InitializeComponent();
            //bEdit.Enabled = false;
            id = code;
            for (int i = 0; i < service.Rows.Count; i++)
            {
                cbService.Items.Add(service.Rows[i][1].ToString());
            }
            for (int i = 0; i < master.Rows.Count; i++)
            {
                cbMaster.Items.Add(master.Rows[i][1].ToString());
            }
            for (int i = 0; i < user.Rows.Count; i++)
            {
                cbUser.Items.Add(user.Rows[i][3].ToString());
            }
            for (int i = 0; i < reqtype.Rows.Count; i++)
            {
                cbTypeReq.Items.Add(reqtype.Rows[i][1].ToString());
            }
            for (int i = 0; i < paytype.Rows.Count; i++)
            {
                cbPayType.Items.Add(paytype.Rows[i][1].ToString());
            }

            if (code != null)
            {
                mode = true;
                GetData(code);
                tClentSName.Enabled = false;
                tClentName.Enabled = false;
                tClientPatron.Enabled = false;
                tClientTel.Enabled = false;
                cbService.Enabled = false;
                cbMaster.Enabled = false;
                dtPlanDelivery.Enabled = false;
                cbIsDone.Enabled = false;
                tSumToPay.Enabled = false;
                dtPay.Enabled = false;
                tSumPay.Enabled = false;
                cbPayType.Enabled = false;
                cbUser.Enabled = false;
                dtReg.Enabled = false;
                cbTypeReq.Enabled = false;
                tPrim.Enabled = false;
                bSave.Enabled = false;

            }
            
        }

        private void GetData(string code)
        {
            Connect.GetItem("card",code);

            this.Text = this.Text + " " + Connect.Items["id"];
            tClentSName.Text          = Connect.Items["family"];
            tClentName.Text            = Connect.Items["clientname"];
            tClientPatron.Text          = Connect.Items["patron"];
            tClientTel.Text               = Connect.Items["tel"];
            cbService.SelectedItem  = Connect.Items["service"];
            cbMaster.SelectedItem   = Connect.Items["master"];
            dtPlanDelivery.Value       = Convert.ToDateTime(Connect.Items["datedelivery"]);
            cbIsDone.Checked          = Convert.ToBoolean(Int16.Parse(Connect.Items["isdone"]));
            tSumToPay.Text            = Connect.Items["forpay"];
            dtPay.Value                   = Convert.ToDateTime(Connect.Items["datepay"]);
            tSumPay.Text                = Connect.Items["paysum"];
            cbPayType.SelectedItem  = Connect.Items["paytype"];
            cbUser.SelectedItem       = Connect.Items["user"];
            dtReg.Value                   = Convert.ToDateTime(Connect.Items["datereg"]);
            cbTypeReq.SelectedItem = Connect.Items["requesttype"];
            tPrim.Text                      = Connect.Items["prim"];
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
                                          tSumToPay.Text.Replace(',','.'), 
                                          tSumPay.Text.Replace(',', '.'), 
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
            if (mode)
            {
                SaveData();
            }
            else
            {
                AddNewData();
            }

            tClentSName.Enabled = false;
            tClentName.Enabled = false;
            tClientPatron.Enabled = false;
            tClientTel.Enabled = false;
            cbService.Enabled = false;
            cbMaster.Enabled = false;
            dtPlanDelivery.Enabled = false;
            cbIsDone.Enabled = false;
            tSumToPay.Enabled = false;
            dtPay.Enabled = false;
            tSumPay.Enabled = false;
            cbPayType.Enabled = false;
            cbUser.Enabled = false;
            dtReg.Enabled = false;
            cbTypeReq.Enabled = false;
            tPrim.Enabled = false;
            bSave.Enabled = false;
            bEdit.Enabled = true;
            bPrint.Enabled = true;

        }

        private void SaveData()
        {
            Connect.SaveCard(tClentSName.Text,
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
                                          tSumToPay.Text.Replace(',', '.'),
                                          tSumPay.Text.Replace(',', '.'),
                                          dtPay.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                                          cbPayType.SelectedItem.ToString(),
                                          tPrim.Text,
                                          Connect.Point_ID,
                                          id);
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode && editState)
            {
                DataRow[] rows = service.Select($"Name='{cbService.SelectedItem.ToString()}'");
                string id = rows[0][0].ToString();
                Connect.GetItem("service", id);
                tSumToPay.Text = Connect.Items["Price"];
            }
            else
            {

            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editState = true;
            bEdit.Enabled = false;
            bPrint.Enabled = false;

            tClentSName.Enabled = true;
            tClentName.Enabled = true;
            tClientPatron.Enabled = true;
            tClientTel.Enabled = true;
            cbService.Enabled = true;
            cbMaster.Enabled = true;
            dtPlanDelivery.Enabled = true;
            cbIsDone.Enabled = true;
            tSumToPay.Enabled = false;
            dtPay.Enabled = true;
            tSumPay.Enabled = true;
            cbPayType.Enabled = true;
            cbUser.Enabled = true;
            dtReg.Enabled = true;
            cbTypeReq.Enabled = true;
            tPrim.Enabled = true;
            bSave.Enabled = true;
        }
    }
}
