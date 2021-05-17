using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CRM
{
    public partial class Main : Form
    {
        private string code;

        public Main()
        {
            InitializeComponent();
            if (code == null)
            {
                bOpenCard.Enabled = false;
            }
            else
            {
                bOpenCard.Enabled = true;
            }


        }

        public Main(string _login, string _password, string _server, string _database)
        {
            InitializeComponent();
            lFullName.Text = Connect.UserName;

            dgOrders.DataSource = Connect.GetList("card");

            dgOrders.Columns[0].HeaderText = "Номер заявки";
            dgOrders.Columns[1].HeaderText = "Услуга";
            dgOrders.Columns[2].HeaderText = "Мастер";
            dgOrders.Columns[3].HeaderText = "Тип оплаты";
            dgOrders.Columns[4].HeaderText = "Тип обращения";
            dgOrders.Columns[5].HeaderText = "Зарегистрировал";
            dgOrders.Columns[6].HeaderText = "Фамилия клиента";
            dgOrders.Columns[7].HeaderText = "Имя клиента";
            dgOrders.Columns[8].HeaderText = "Отчество клиента";
            dgOrders.Columns[9].HeaderText = "Телефон клиента";
            dgOrders.Columns[10].HeaderText = "Дата записи";
            dgOrders.Columns[11].HeaderText = "Выполнено";
            dgOrders.Columns[12].HeaderText = "Дата регистрации";
            dgOrders.Columns[13].HeaderText = "Дата оплаты";
            dgOrders.Columns[14].HeaderText = "К оплате";
            dgOrders.Columns[15].HeaderText = "Оплачено";
            dgOrders.Columns[16].HeaderText = "Примечание";
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void bAddCard_Click(object sender, EventArgs e)
        {
            Card card = new Card(null);
            card.ShowInTaskbar = false;
            card.FormClosing += Card_FormClosing;
            card.ShowDialog();
        }

        private void bOpenCard_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                Card card = new Card(code);
                card.ShowInTaskbar = false;
                card.FormClosing += Card_FormClosing;
                card.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите заявку из списка.", "Ошибка!");
            }

        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowInTaskbar = false;
            users.ShowDialog();
        }

        private void мастераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masters masters = new Masters();
            masters.ShowInTaskbar = false;
            masters.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.ShowInTaskbar = false;
            clients.ShowDialog();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.ShowInTaskbar = false;
            services.ShowDialog();
        }

        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Points points = new Points();
            points.ShowInTaskbar = false;
            points.ShowDialog();
        }

        private void Card_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgOrders.DataSource = null;
            dgOrders.Rows.Clear();
            dgOrders.DataSource = Connect.GetList("card");

            dgOrders.Columns[0].HeaderText = "Номер заявки";
            dgOrders.Columns[1].HeaderText = "Услуга";
            dgOrders.Columns[2].HeaderText = "Мастер";
            dgOrders.Columns[3].HeaderText = "Тип оплаты";
            dgOrders.Columns[4].HeaderText = "Тип обращения";
            dgOrders.Columns[5].HeaderText = "Зарегистрировал";
            dgOrders.Columns[6].HeaderText = "Фамилия клиента";
            dgOrders.Columns[7].HeaderText = "Имя клиента";
            dgOrders.Columns[8].HeaderText = "Отчество клиента";
            dgOrders.Columns[9].HeaderText = "Телефон клиента";
            dgOrders.Columns[10].HeaderText = "Дата записи";
            dgOrders.Columns[11].HeaderText = "Выполнено";
            dgOrders.Columns[12].HeaderText = "Дата регистрации";
            dgOrders.Columns[13].HeaderText = "Дата оплаты";
            dgOrders.Columns[14].HeaderText = "К оплате";
            dgOrders.Columns[15].HeaderText = "Оплачено";
            dgOrders.Columns[16].HeaderText = "Примечание";


        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code = dgOrders[0, dgOrders.CurrentRow.Index].Value.ToString();
            bOpenCard.Enabled = true;
        }

        private void dgOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (code != null)
            {
                Card card = new Card(code);
                card.ShowInTaskbar = false;
                card.FormClosing += Card_FormClosing;
                card.ShowDialog();
            }
        }

        private void tFastFilter_TextChanged(object sender, EventArgs e)
        {
            if (tFastFilter.Text != "")
            {
                
                for (int i = 0; i < dgOrders.Rows.Count; i++)
                {
                    for (int j = 0; j < dgOrders.Rows[i].Cells.Count; j++)
                    {
                        if (dgOrders.Rows[i].Cells[j].Value.ToString().Contains(tFastFilter.Text))
                        {
                            dgOrders.CurrentCell = null;
                            dgOrders.Rows[dgOrders.Rows[i].Index].Visible = true;
                            break;
                        }
                        else
                        {
                            dgOrders.CurrentCell = null;
                            dgOrders.Rows[dgOrders.Rows[i].Index].Visible = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dgOrders.Rows.Count; i++)
                {
                    dgOrders.CurrentCell = null;
                    dgOrders.Rows[dgOrders.Rows[i].Index].Visible = true;                    
                }
            }
        }

        private void праваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.ShowInTaskbar = false;
            roles.ShowDialog();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (code != null)
            {
                Reports reports = new Reports(code);
                reports.ShowInTaskbar = false;
                reports.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите заявку из списка.", "Ошибка!");
            }
        }

        private void настройкаОтчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowInTaskbar = false;
            reports.ShowDialog();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            dgOrders.DataSource = null;
            dgOrders.Rows.Clear();
            dgOrders.DataSource = Connect.GetList("card");

            dgOrders.Columns[0].HeaderText = "Номер заявки";
            dgOrders.Columns[1].HeaderText = "Услуга";
            dgOrders.Columns[2].HeaderText = "Мастер";
            dgOrders.Columns[3].HeaderText = "Тип оплаты";
            dgOrders.Columns[4].HeaderText = "Тип обращения";
            dgOrders.Columns[5].HeaderText = "Зарегистрировал";
            dgOrders.Columns[6].HeaderText = "Фамилия клиента";
            dgOrders.Columns[7].HeaderText = "Имя клиента";
            dgOrders.Columns[8].HeaderText = "Отчество клиента";
            dgOrders.Columns[9].HeaderText = "Телефон клиента";
            dgOrders.Columns[10].HeaderText = "Дата записи";
            dgOrders.Columns[11].HeaderText = "Выполнено";
            dgOrders.Columns[12].HeaderText = "Дата регистрации";
            dgOrders.Columns[13].HeaderText = "Дата оплаты";
            dgOrders.Columns[14].HeaderText = "К оплате";
            dgOrders.Columns[15].HeaderText = "Оплачено";
            dgOrders.Columns[16].HeaderText = "Примечание";
        }
    }
}
   
