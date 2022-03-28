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
    public partial class UpdatePlayer : Form
    {
        public UpdatePlayer()
        {
            InitializeComponent();
        }

        private void UpdatePlayer_Load(object sender, EventArgs e)
        {
            Client.PlayerServiceReference.PlayerServiceClient sc = new Client.PlayerServiceReference.PlayerServiceClient("BasicHttpBinding_IPlayerService");
            DataSet ds = sc.GetPlayers();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sc.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Client.PlayerServiceReference.PlayerServiceClient sc = new Client.PlayerServiceReference.PlayerServiceClient("BasicHttpBinding_IPlayerService");
            try
            {
                if (pi.Text != null)
                {
                    int id = int.Parse(pi.Text);
                    Client.PlayerServiceReference.Player p = new PlayerServiceReference.Player();
                    p.Id = id;
                    p.P_Name = pn.Text;
                    p.J_No = int.Parse(pj.Text);
                    p.Country = pc.Text;
                    p.P_Type = pt.Text;
                    string msg = sc.UpdatePlayer (p);
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
