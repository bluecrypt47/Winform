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
    public partial class frmContract : Form
    {
        public frmContract()
        {
            InitializeComponent();
            loadIDRoom();
            loadCmnd();
            loadListContract();
        }

        #region Methods
        //xem
        private void loadListContract()
        {
            List<Contract> contractList = ContractDAO.Instance.loadContractList();

            dgvContract.DataSource = contractList;
        }

        public void loadIDRoom()
        {
            List<RoomID> idRoomList = RoomDAO.Instance.getListIDRoom();

            cbxNumberRoom.DataSource = idRoomList;
            cbxNumberRoom.DisplayMember = "numberRoom";
        }

        public void loadCmnd()
        {
            List<Customer> customerIDList = CustomerDAO.Instance.loadCustomerList();

            cbxCMND.DataSource = customerIDList;
            cbxCMND.DisplayMember = "cMND";
        }
        #endregion

        #region Events
        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                // lưu dữ liệu khi click
                DataGridViewRow data = this.dgvContract.Rows[e.RowIndex];

                txtIDContract.Text = data.Cells[0].Value.ToString();
                cbxNumberRoom.Text = data.Cells[1].Value.ToString();
                cbxCMND.Text = data.Cells[2].Value.ToString();
                txtSurName.Text = data.Cells[6].Value.ToString();
                txtLastName.Text = data.Cells[7].Value.ToString();
                txtName.Text = data.Cells[8].Value.ToString();
                txtSexual.Text = data.Cells[9].Value.ToString();
                txtDateTime.Text = data.Cells[4].Value.ToString();
                cbxStatusDepositMoney.Text = data.Cells[3].Value.ToString();
                txtDepositMoney.Text = data.Cells[5].Value.ToString();
            }
        }



        // Sửa
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string idConstract = txtIDContract.Text;
            string numberRoom = cbxNumberRoom.Text;
            string cmnd = cbxCMND.Text;
            DateTime datetime = Convert.ToDateTime(txtDateTime.Text);
            string status = cbxStatusDepositMoney.Text;
            double deposit = Convert.ToDouble(txtDepositMoney.Text);

            if (ContractDAO.Instance.EditContract(idConstract, numberRoom, cmnd, datetime, status, deposit))
            {
                MessageBox.Show("Sửa hợp đồng THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadListContract();
            }
            else
            {
                MessageBox.Show("Sửa hợp đồng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadListContract();
            }
        }

        // Thêm
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string idConstract = txtIDContract.Text;
            string numberRoom = cbxNumberRoom.Text;
            string cmnd = cbxCMND.Text;
            DateTime datetime = Convert.ToDateTime(txtDateTime.Text);
            string status = cbxStatusDepositMoney.Text;
            double deposit = Convert.ToDouble(txtDepositMoney.Text);

            if (ContractDAO.Instance.InsertContract(idConstract, numberRoom, cmnd, datetime, status, deposit))
            {
                MessageBox.Show("Thêm hợp đồng THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadListContract();
            }
            else
            {
                MessageBox.Show("Thêm hợp đồng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadListContract();
            }
        }

        // Xóa
        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            string idConstract = txtIDContract.Text;

            if (ContractDAO.Instance.DelContract(idConstract))
            {
                MessageBox.Show("Xóa hợp đồng tHÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadListContract();
            }
            else
            {
                MessageBox.Show("Xóa hợp đồng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadListContract();
            }
        }

        private void frmContract_Load(object sender, EventArgs e)
        {
            loadListContract();

            dgvContract.Columns[0].HeaderText = "Mã hợp đồng";
            dgvContract.Columns[1].HeaderText = "Mã phòng";
            dgvContract.Columns[2].HeaderText = "Số CMND";
            dgvContract.Columns[3].HeaderText = "Tình trạng tiền cọc";
            dgvContract.Columns[4].HeaderText = "Ngày lập";
            dgvContract.Columns[5].HeaderText = "Tiền cọc";
            dgvContract.Columns[6].HeaderText = "Họ";
            dgvContract.Columns[7].HeaderText = "Tên lót";
            dgvContract.Columns[8].HeaderText = "Tên";
            dgvContract.Columns[9].HeaderText = "Giới tính";
        }
        #endregion

    }
}
