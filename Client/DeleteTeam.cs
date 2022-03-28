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
    public partial class DeleteTeam : Form
    {
        public DeleteTeam()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ti.Text == null)
            {
                MessageBox.Show("Team Not Selected");
                return;
            }
            int id = int.Parse(ti.Text);
            Client.TeamServiceReference.TeamServiceClient sc = new Client.TeamServiceReference.TeamServiceClient("BasicHttpBinding_ITeamService");
            try
            {
                string msg = sc.DeleteTeam(id);
                MessageBox.Show(msg);
                this.OnLoad(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Delete This Team");
            }
            finally
            {
                sc.Close();
            }
        }
    }
}
