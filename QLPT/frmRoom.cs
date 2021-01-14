using QLPT.DAO;
using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
            loadIDBuilding();
            loadListRoom();
            
        }

        #region Methos
        // Xem phòng có người ở rồi hoặc dã đặt cọc
        private void loadListRoom()
        {
            List<Room> roomList = RoomDAO.Instance.getListRoom();

            dgvRoom.DataSource = roomList;
        }

        public void loadIDBuilding()
        {
            List<Building> idBuildingsList = BuildingDAO.Instance.loadBuildingList();

            cbxIDBuilding.DataSource = idBuildingsList;
            cbxIDBuilding.DisplayMember = "idBuilding";
        }

        #endregion


        #region Events
        // hiển thị phòng trống
        private void dgvRoomNon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                // lưu dữ liệu khi click
                DataGridViewRow data = this.dgvRoomNon.Rows[e.RowIndex];

                txtIDRoom.Text = data.Cells[1].Value.ToString();
                cbxIDBuilding.Text = data.Cells[2].Value.ToString();
                cbxNumberRoom.Text = data.Cells[4].Value.ToString();
                txtStatusRoom.Text = data.Cells[0].Value.ToString();
                txtPriceRoom.Text = data.Cells[3].Value.ToString();
            }
        }

        // Xem phòng trống
        private void loadListRoomNon()
        {
            List<RoomNon> roomList = RoomNonDAO.Instance.getRoomNonList();

            dgvRoomNon.DataSource = roomList;
        }

        // Thêm
        private void btnAddRoomNon_Click_1(object sender, EventArgs e)
        {
            try
            {
                string idRoom = txtIDRoom.Text;
                string idBuilding = cbxIDBuilding.Text;
                double numberPeopleRoom = Convert.ToDouble(cbxNumberRoom.Text);
                double priceRoom = Convert.ToDouble(txtPriceRoom.Text);

                if (RoomNonDAO.Instance.InsertRoomNon(idRoom, idBuilding, numberPeopleRoom, priceRoom))
                {
                    MessageBox.Show("Thêm phòng thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    loadListRoomNon();

                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại!!!", "Thông báo", MessageBoxButtons.OK);
                    loadListRoomNon();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Thêm phòng thất bại!!!\n Vui lòng kiểm tra lại MÃ PHÒNG", "Thông báo", MessageBoxButtons.OK);
                loadListRoomNon();
            }
            
        }


        // Xóa
        private void btnDelDetailsRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string idRoom = txtIDRoom.Text;

                if (RoomNonDAO.Instance.DelRoom(idRoom))
                {
                    MessageBox.Show("Xóa phòng thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    loadListRoomNon();
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại!!!", "Thông báo", MessageBoxButtons.OK);
                    loadListRoomNon();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Xóa phòng thất bại!!!\n Vui lòng kiểm tra lại MÃ PHÒNG!", "Thông báo", MessageBoxButtons.OK);
                loadListRoomNon();
            }
            
        }

        // Sửa
        private void btnEditDetailsRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string idRoom = txtIDRoom.Text;
                string idBuilding = cbxIDBuilding.Text;
                double numberPeopleRoom = Convert.ToDouble(cbxNumberRoom.Text);
                string statusRoom = txtStatusRoom.Text;
                double priceRoom = Convert.ToDouble(txtPriceRoom.Text);

                if (RoomNonDAO.Instance.EditRoom(idRoom, idBuilding, numberPeopleRoom, statusRoom, priceRoom))
                {
                    MessageBox.Show("Sửa phòng THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                    loadListRoomNon();

                }
                else
                {
                    MessageBox.Show("Sửa phòng THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                    loadListRoomNon();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Sửa phòng THẤT BẠI!!!\n Vui lòng kiểm tra lại MÃ PHÒNG!", "Thông báo", MessageBoxButtons.OK);
                loadListRoomNon();
            }
            
        }



        

        private void frmRoom_Load(object sender, EventArgs e)
        {
            loadListRoomNon();

            dgvRoomNon.Columns[0].HeaderText = "Tình trạng phòng";
            dgvRoomNon.Columns[1].HeaderText = "Mã phòng";
            dgvRoomNon.Columns[2].HeaderText = "Mã dãy";
            dgvRoomNon.Columns[3].HeaderText = "Giá phòng";
            dgvRoomNon.Columns[4].HeaderText = "Số người ở cùng phòng";

            loadListRoom();
            dgvRoom.Columns[0].HeaderText = "Mã phòng";
            dgvRoom.Columns[1].HeaderText = "Mã dãy";
            dgvRoom.Columns[2].HeaderText = "Giá phòng";
            dgvRoom.Columns[3].HeaderText = "Họ";
            dgvRoom.Columns[4].HeaderText = "Tên lót";
            dgvRoom.Columns[5].HeaderText = "Tên";
            dgvRoom.Columns[6].HeaderText = "Số CMND";
            dgvRoom.Columns[7].HeaderText = "Ngày chuyển vào";
            dgvRoom.Columns[8].HeaderText = "Tình trạng tiền cọc";
        }
        #endregion

        
    }
}
