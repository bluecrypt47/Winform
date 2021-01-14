using QLPT.DAO;
using QLPT.DTO;
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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        #region Methods
        private void loadCustomerList()
        {
            List<Customer> customerList = CustomerDAO.Instance.loadCustomerList();

            dgvCustomer.DataSource = customerList;
        }

        #endregion

        #region Envents

        // Thêm
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtIDCard.Text;
                string surName = txtSurName.Text;
                string lastName = txtLastName.Text;
                string name = txtFirstName.Text;
                string sexual = txtSexual.Text;

                if (CustomerDAO.Instance.InsertCustomer(cmnd, surName, lastName, name, sexual))
                {
                    MessageBox.Show("Thêm khách hàng THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                    loadCustomerList();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                    loadCustomerList();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm khách hàng THẤT BẠI!!!\n Vui lòng kiểm tra lại CMND!", "Thông báo", MessageBoxButtons.OK);
                loadCustomerList();
            }
            
        }

        // Xóa
        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtIDCard.Text;

                if (CustomerDAO.Instance.DelCustomer(cmnd))
                {
                    MessageBox.Show("Xóa khách hàng THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                    loadCustomerList();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                    loadCustomerList();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Xóa khách hàng THẤT BẠI!!!\n Vui lòng kiểm tra lại CMND!", "Thông báo", MessageBoxButtons.OK);
                loadCustomerList();
            }
            
        }



        // Sửa
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtIDCard.Text;
                string surName = txtSurName.Text;
                string lastName = txtLastName.Text;
                string name = txtFirstName.Text;
                string sexual = txtSexual.Text;

                if (CustomerDAO.Instance.UpdateCustomer(cmnd, surName, lastName, name, sexual))
                {
                    MessageBox.Show("Sửa khách hàng THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                    loadCustomerList();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                    loadCustomerList();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Sửa khách hàng THẤT BẠI!!!\n Vui lòng kiểm tra lại CMND!", "Thông báo", MessageBoxButtons.OK);
                loadCustomerList();
            }
            
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow data = this.dgvCustomer.Rows[e.RowIndex];

                txtIDCard.Text = data.Cells[0].Value.ToString();
                txtSurName.Text = data.Cells[1].Value.ToString();
                txtLastName.Text = data.Cells[2].Value.ToString();
                txtFirstName.Text = data.Cells[3].Value.ToString();
                txtSexual.Text = data.Cells[4].Value.ToString();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            loadCustomerList();

            dgvCustomer.Columns[0].HeaderText = "Số CMND";
            dgvCustomer.Columns[1].HeaderText = "Họ";
            dgvCustomer.Columns[2].HeaderText = "Tên lót";
            dgvCustomer.Columns[3].HeaderText = "Tên";
            dgvCustomer.Columns[4].HeaderText = "Giới tính";
        }
        #endregion





    }
}
