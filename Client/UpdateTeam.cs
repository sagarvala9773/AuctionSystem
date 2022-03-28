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
    public partial class UpdateTeam : Form
    {
        public UpdateTeam()
        {
            InitializeComponent();
        }

        private void UpdateTeam_Load(object sender, EventArgs e)
        {
            Client.TeamServiceReference.TeamServiceClient sc = new Client.TeamServiceReference.TeamServiceClient("BasicHttpBinding_ITeamService");
            DataSet ds = sc.GetTeam();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sc.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Client.TeamServiceReference.TeamServiceClient sc = new Client.TeamServiceReference.TeamServiceClient("BasicHttpBinding_ITeamService");
            try
            {
                if (ti.Text != null)
                {
                    int id = int.Parse(ti.Text);
                    Client.TeamServiceReference.Team t = new TeamServiceReference.Team();
                    t.Id = id;
                    t.T_Name = tn.Text;
                    t.T_BValue = int.Parse(tb.Text);
                    t.T_Owner = to.Text;
                    t.T_Captain = tc.Text;
                    t.T_HCoach = th.Text;
                    string msg = sc.UpdateTeam(t);
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
