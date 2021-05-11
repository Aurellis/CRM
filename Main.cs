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
        public Main()
        {
            InitializeComponent();
        }

        public Main(string _login, string _password, string _server, string _database)
        {
            InitializeComponent();
            lFullName.Text = Connect.UserName;

            dgOrders.DataSource = Connect.GetList("card");

            dgOrders.Columns[0].HeaderText = "Код";
            dgOrders.Columns[1].HeaderText = "Номер заявки";
            dgOrders.Columns[2].HeaderText = "Услуга";
            dgOrders.Columns[3].HeaderText = "Мастер";
            dgOrders.Columns[4].HeaderText = "Тип оплаты";
            dgOrders.Columns[5].HeaderText = "Тип обращения";
            dgOrders.Columns[6].HeaderText = "Зарегистрировал";
            dgOrders.Columns[7].HeaderText = "Фамилия клиента";
            dgOrders.Columns[8].HeaderText = "Имя клиента";
            dgOrders.Columns[9].HeaderText = "Отчество клиента";
            dgOrders.Columns[10].HeaderText = "Телефон клиента";
            dgOrders.Columns[11].HeaderText = "Дата записи";
            dgOrders.Columns[12].HeaderText = "Выполнено";
            dgOrders.Columns[13].HeaderText = "Дата регистрации";
            dgOrders.Columns[14].HeaderText = "Дата оплаты";
            dgOrders.Columns[15].HeaderText = "К оплате";
            dgOrders.Columns[16].HeaderText = "Оплачено";
            dgOrders.Columns[17].HeaderText = "Примечание";
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
            Card card = new Card(true);
            card.ShowInTaskbar = false;
            card.FormClosing += Card_FormClosing;
            card.ShowDialog();
        }       

        private void bOpenCard_Click(object sender, EventArgs e)
        {
            Card card = new Card(false);
            card.ShowInTaskbar = false; 
            card.FormClosing += Card_FormClosing;
            card.ShowDialog();
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.ShowInTaskbar = false;
            filter.ShowDialog();
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
            throw new NotImplementedException();
        }
    }
}
