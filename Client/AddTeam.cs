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
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Client.TeamServiceReference.TeamServiceClient sc = new Client.TeamServiceReference.TeamServiceClient("BasicHttpBinding_ITeamService");
                Client.TeamServiceReference.Team t = new TeamServiceReference.Team();
                t.T_Name = tn.Text;
                t.T_Owner = to.Text;
                t.T_BValue = int.Parse(tb.Text);
                t.T_Captain = tc.Text;
                t.T_HCoach = th.Text;
                string msg = sc.AddTeam(t);
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Add a Team");
            }
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
