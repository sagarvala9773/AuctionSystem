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
    public partial class DeleteAuction : Form
    {
        public DeleteAuction()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("Auction Not Selected");
                return;
            }
            int id = int.Parse(textBox1.Text);
            Client.AuctionServiceReference.AuctionServiceClient sc = new Client.AuctionServiceReference.AuctionServiceClient("BasicHttpBinding_IAuctionService");
            try
            {
                string msg = sc.DeleteAuction(id);
                MessageBox.Show(msg);
                this.OnLoad(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can Not Delete This Anction");
            }
            finally
            {
                sc.Close();
            }
        }

        private void DeleteAuction_Load(object sender, EventArgs e)
        {

        }
    }
}
