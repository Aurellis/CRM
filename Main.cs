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
        //TimerCallback timerCallback = new TimerCallback(CheckDateTime);

        //private static  void CheckDateTime(object state)
        //{
        //    lDateTime.Text = DateTime.Now.ToString();
        //}

        public Main()
        {
            InitializeComponent();
        }

        public Main(string _login, string _password, string _server, string _database)
        {
            InitializeComponent();
            lFullName.Text = Connect.UserName;
            
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
            Card card = new Card();
            card.ShowInTaskbar = false;
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
    }
}
