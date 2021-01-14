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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
            loadIDRoom();
            loadCmnd();

            //string id = cbxCMND.Text;
            //loadCmnd(id);
        }
        #region Methods

        // 
        

        // Load
        private void loadBillList()
        {
            List<Bill> billList = BillDAO.Instance.loadBillList();

            dgvBill.DataSource = billList;
        }

        public void loadIDRoom()
        {
            List<RoomID> idRoomList = RoomDAO.Instance.getListIDRoom();

            cbxIDRoom.DataSource = idRoomList;
            cbxIDRoom.DisplayMember = "numberRoom";
        }

        public void loadCmnd()
        {
            List<Customer> customerIDList = CustomerDAO.Instance.loadCustomerList();

            cbxCMND.DataSource = customerIDList;
            cbxCMND.DisplayMember = "cMND";
        }
        //public void loadCmnd(string id)
        //{
        //    List<Customer> customerIDList = CustomerDAO.Instance.loadIDCustomerList(id);

        //    cbxCMND.DataSource = customerIDList;
        //    cbxCMND.DisplayMember = "cMND";
        //}

        #endregion


        #region Events
        // 
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                // lưu dữ liệu khi click
                DataGridViewRow data = this.dgvBill.Rows[e.RowIndex];

                txtIDBill.Text = data.Cells[0].Value.ToString();
                cbxIDRoom.Text = data.Cells[1].Value.ToString();
                cbxCMND.Text = data.Cells[2].Value.ToString();
                //txtSurName.Text = data.Cells[8].Value.ToString();
                //txtLastName.Text = data.Cells[9].Value.ToString();
                //txtName.Text = data.Cells[10].Value.ToString();
                txtDateTime.Text = data.Cells[3].Value.ToString();
                txtOldNumberWater.Text = data.Cells[4].Value.ToString();
                txtNewNumberWater.Text = data.Cells[5].Value.ToString();
                txtOldNumberElectirc.Text = data.Cells[6].Value.ToString();
                txtNewNumberElectirc.Text = data.Cells[7].Value.ToString();
                txtPriceRoom.Text = data.Cells[12].Value.ToString();
                txtTotalBill.Text = data.Cells[11].Value.ToString();
            }
        }


        // Thêm
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string idBill = txtIDBill.Text;
            string idRoom = cbxIDRoom.Text;
            string CMND = cbxCMND.Text;
            double oldNumberElectric = Convert.ToDouble(txtOldNumberElectirc.Text);
            double newNumberElectric = Convert.ToDouble(txtNewNumberElectirc.Text);
            double oldNumberWater = Convert.ToDouble(txtOldNumberWater.Text);
            double newNumberWater = Convert.ToDouble(txtNewNumberWater.Text);

            if(oldNumberWater > newNumberWater || oldNumberElectric >newNumberElectric)
            {
                MessageBox.Show("Thêm hóa đơn THẤT BẠI!!! Mời bạn xem lại các chỉ số điện nước!", "Thông báo", MessageBoxButtons.OK);
                loadBillList();
            }
            else
            {
                if (BillDAO.Instance.InsertBill(idBill, idRoom, CMND, oldNumberWater, newNumberWater, oldNumberElectric, newNumberElectric))
                {
                    MessageBox.Show("Thêm hóa đơn THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                    loadBillList();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                    loadBillList();
                }
            }

            

        }

        // Xóa
        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            string idBill = txtIDBill.Text;

            if (BillDAO.Instance.DelBill(idBill))
            {
                MessageBox.Show("Xóa hóa đơn THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadBillList();
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadBillList();
            }
        }


        // Sửa
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            string idBill = txtIDBill.Text;
            string idRoom = cbxIDRoom.Text;
            string CMND = cbxCMND.Text;
            DateTime dateTime = Convert.ToDateTime(txtDateTime.Text);
            double oldNumberElectric = Convert.ToDouble(txtOldNumberElectirc.Text);
            double newNumberElectric = Convert.ToDouble(txtNewNumberElectirc.Text);
            double oldNumberWater = Convert.ToDouble(txtOldNumberWater.Text);
            double newNumberWater = Convert.ToDouble(txtNewNumberWater.Text);

            if (BillDAO.Instance.EditBill(idBill, idRoom, CMND, dateTime, oldNumberWater, newNumberWater, oldNumberElectric, newNumberElectric))
            {
                MessageBox.Show("Sửa hóa đơn THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadBillList();
            }
            else
            {
                MessageBox.Show("Sửa hóa đơn THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadBillList();
            }
        }


        private void frmBill_Load(object sender, EventArgs e)
        {

            loadBillList();

            dgvBill.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBill.Columns[1].HeaderText = "Mã phòng";
            dgvBill.Columns[2].HeaderText = "Số CMND";
            dgvBill.Columns[3].HeaderText = "Ngày lập";
            dgvBill.Columns[4].HeaderText = "Chỉ số điện cũ";
            dgvBill.Columns[5].HeaderText = "Chỉ số điện mới";
            dgvBill.Columns[6].HeaderText = "Chỉ số nước cũ";
            dgvBill.Columns[7].HeaderText = "Chỉ số nước mới";
            dgvBill.Columns[8].HeaderText = "Họ";
            dgvBill.Columns[9].HeaderText = "Tên lót";
            dgvBill.Columns[10].HeaderText = "Tên";
            dgvBill.Columns[11].HeaderText = "Tổng tiền";
            dgvBill.Columns[12].HeaderText = "Giá phòng";
        }
        #endregion

    }
}
