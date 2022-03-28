using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ShowAuction : Form
    {
        public ShowAuction()
        {
            InitializeComponent();
        }

        private void ShowAuction_Load(object sender, EventArgs e)
        {
            Client.AuctionServiceReference.AuctionServiceClient sc = new Client.AuctionServiceReference.AuctionServiceClient("BasicHttpBinding_IAuctionService");
            DataSet ds = sc.GetAuctions();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
