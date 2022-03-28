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
    public partial class ShowPlayer : Form
    {
        public ShowPlayer()
        {
            InitializeComponent();
        }

        private void ShowPlayer_Load(object sender, EventArgs e)
        {
            Client.PlayerServiceReference.PlayerServiceClient sc = new Client.PlayerServiceReference.PlayerServiceClient("BasicHttpBinding_IPlayerService");
            DataSet ds = sc.GetPlayers();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
