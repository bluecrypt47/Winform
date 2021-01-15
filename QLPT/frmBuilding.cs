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
            try
            {
                string idBuilding = txtIDBuilding.Text;
                string addressBuildidng = txtAddressBuilding.Text;
                
                if(idBuilding == "" && addressBuildidng =="")
                {
                    MessageBox.Show("Vui lòng nhập trước khi THÊM!!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

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
            catch(SqlException)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Thêm dãy nhà THẤT BẠI!!!\nVui lòng kiểm tra lại MÃ DÃY NHÀ!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
            
        }

        // Xóa Building
        private void btnDelBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuilding = txtIDBuilding.Text;

                if(idBuilding == "")
                {
                    MessageBox.Show("Vui lòng nhập trước khi XÓA!!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

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
            catch(SqlException)
            {
                MessageBox.Show("Xóa dãy nhà THẤT BẠI!!!\nVui lòng kiểm tra lại MÃ DÃY NHÀ!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
            
            
        }

        


        //sửa 
        private void btnEditBuilding_Click(object sender, EventArgs e)
        {

            try
            {

                string idBuilding = txtIDBuilding.Text;
                string addressBuilding = txtAddressBuilding.Text;

                if (idBuilding == "" && addressBuilding == "")
                {
                    MessageBox.Show("Vui lòng nhập trước khi SỬA!!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

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
            catch(SqlException)
            {
                MessageBox.Show("Sửa dãy nhà THẤT BẠI!!!\nVui lòng kiểm tra lại MÃ DÃY NHÀ!!!", "Thông báo", MessageBoxButtons.OK);
                loadBuildingList();
            }
            
        }


        private void dgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dgvBuilding.Rows[e.RowIndex];

                txtIDBuilding.Text = data.Cells[0].Value.ToString();
                txtAddressBuilding.Text = data.Cells[1].Value.ToString();
            }
        }

        #endregion

        



    }
}
