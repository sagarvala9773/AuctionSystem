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
    public partial class DeletePlayer : Form
    {
        public DeletePlayer()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dp.Text == null)
            {
                MessageBox.Show("Player Not Selected");
                return;
            }
            int id = int.Parse(dp.Text);
            Client.PlayerServiceReference.PlayerServiceClient sc = new Client.PlayerServiceReference.PlayerServiceClient("BasicHttpBinding_IPlayerService");
            try
            {
                string msg = sc.DeletePlayer(id);
                MessageBox.Show(msg);
                this.OnLoad(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Delete This Player");
            }
            finally
            {
                sc.Close();
            }
        }

        private void DeletePlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
