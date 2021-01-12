using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            frmBuilding building = new frmBuilding();
            this.Hide();
            building.ShowDialog();
            this.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            this.Hide();
            room.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBill account = new frmBill();
            this.Hide();
            account.ShowDialog();
            this.Show();
        }

        

        private void btnContract_Click(object sender, EventArgs e)
        {
            frmContract customer = new frmContract();
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }
    }
}
