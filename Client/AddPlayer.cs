using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Client.PlayerServiceReference.PlayerServiceClient sc = new Client.PlayerServiceReference.PlayerServiceClient("BasicHttpBinding_IPlayerService");
                Client.PlayerServiceReference.Player p = new PlayerServiceReference.Player();
                p.P_Name = pn.Text;
                p.Country = cn.Text;
                p.P_Type = pt.Text;
                p.J_No = int.Parse(jn.Text);
                string msg = sc.AddPlayer(p);
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Add a Player");
            }
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
