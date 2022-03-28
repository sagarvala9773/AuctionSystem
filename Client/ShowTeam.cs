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
    public partial class ShowTeam : Form
    {
        public ShowTeam()
        {
            InitializeComponent();
        }

        private void ShowTeam_Load(object sender, EventArgs e)
        {
            Client.TeamServiceReference.TeamServiceClient sc = new Client.TeamServiceReference.TeamServiceClient("BasicHttpBinding_ITeamService");
            DataSet ds = sc.GetTeam();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
