using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AddAuction : Form
    {
        public AddAuction()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Client.AuctionServiceReference.AuctionServiceClient sc = new Client.AuctionServiceReference.AuctionServiceClient("BasicHttpBinding_IAuctionService");
                Client.AuctionServiceReference.Auction a = new AuctionServiceReference.Auction();
                a.Season = int.Parse(sa.Text);
                a.S_Name = sn.Text;
                a.T_Player = int.Parse(tp.Text);
                a.T_Team = int.Parse(tt.Text);
                a.I_Player = int.Parse(ip.Text);
                a.F_Player = int.Parse(fp.Text);
                string msg = sc.AddAuction(a);
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Add a Player");
            }
        }

        private void AddAuction_Load(object sender, EventArgs e)
        {

        }
    }
}
