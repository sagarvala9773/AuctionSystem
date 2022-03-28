using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost sh1 = null, sh2 = null ,sh3=null;

      
        private void Form1_Load(object sender, EventArgs e)
        {
            sh1 = new ServiceHost(typeof(PlayerService.PlayerService));
            sh1.Open();

            sh2 = new ServiceHost(typeof(PlayerService.TeamService));
            sh2.Open();

            sh3 = new ServiceHost(typeof(PlayerService.AuctionService));
            sh3.Open();

            label1.Text = "PlayerManagement Service is Running";
            label2.Text = "TeamManagement Service is Running";
            label3.Text = "AuctionManagement Service is Running";
        }
    }
}
