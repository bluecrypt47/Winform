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
    public partial class frmBuilding : Form
    {
        public frmBuilding()
        {
            InitializeComponent();

        }



        #region Methods
        // load Building
        public void loadBuildingList()
        {
            List<Building> buildings = BuildingDAO.Instance.loadBuildingList();

            dgvBuilding.DataSource = buildings;


        }

        private void frmBuilding_Load(object sender, EventArgs e)
        {
            loadBuildingList();

            dgvBuilding.Columns[0].HeaderText = "Mã dãy";
            dgvBuilding.Columns[1].HeaderText = "Địa chỉ";
        }
        #endregion


        #region events
        // Thêm
        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            string idBuilding = txtIDBuilding.Text;
            string addressBuildidng = txtAddressBuilding.Text;

            if (BuildingDAO.Instance.InsertBuilding(idBuilding, addressBuildidng))
            {
                MessageBox.Show("Thêm dãy nhà THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
            else
            {
                MessageBox.Show("Thêm dãy nhà THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
        }

        // Xóa Building
        private void btnDelBuilding_Click(object sender, EventArgs e)
        {
            //lsvBuilding.Items.Clear();
            string idBuilding = txtIDBuilding.Text;
            if (BuildingDAO.Instance.DelBuilding(idBuilding))
            {
                MessageBox.Show("Xóa dãy nhà THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
            else
            {
                MessageBox.Show("Xóa dãy nhà THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
        }

        


        //sửa 
        private void btnEditBuilding_Click(object sender, EventArgs e)
        {

            string idBuilding = txtIDBuilding.Text;
            string addressBuilding = txtAddressBuilding.Text;

            if (BuildingDAO.Instance.UpdateBuilding(idBuilding, addressBuilding))
            {
                MessageBox.Show("Sửa dãy nhà THÀNH CÔNG!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
            else
            {
                MessageBox.Show("Sửa dãy nhà THẤT BẠI!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
        }


        private void dgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow data = this.dgvBuilding.Rows[e.RowIndex];

                txtIDBuilding.Text = data.Cells[0].Value.ToString();
                txtAddressBuilding.Text = data.Cells[1].Value.ToString();
            }
        }

        #endregion

        



    }
}
