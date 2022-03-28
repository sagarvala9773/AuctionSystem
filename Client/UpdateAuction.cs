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
    public partial class UpdateAuction : Form
    {
        public UpdateAuction()
        {
            InitializeComponent();
        }

        private void UpdateAuction_Load(object sender, EventArgs e)
        {

            Client.AuctionServiceReference.AuctionServiceClient sc = new Client.AuctionServiceReference.AuctionServiceClient("BasicHttpBinding_IAuctionService");
            DataSet ds = sc.GetAuctions();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sc.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Client.AuctionServiceReference.AuctionServiceClient sc = new Client.AuctionServiceReference.AuctionServiceClient("BasicHttpBinding_IAuctionService");
            try
            {
                if (ai.Text != null)
                {
                    int id = int.Parse(ai.Text);
                    Client.AuctionServiceReference.Auction a = new AuctionServiceReference.Auction();
                    a.Id = id;
                    a.Season = int.Parse(sa.Text);
                    a.S_Name = sn.Text;
                    a.T_Player = int.Parse(tp.Text);
                    a.T_Team = int.Parse(tt.Text);
                    a.I_Player = int.Parse(ip.Text);
                    a.F_Player = int.Parse(fp.Text);
                    string msg = sc.UpdateAuction(a);
                    MessageBox.Show(msg);
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }
    }
}
