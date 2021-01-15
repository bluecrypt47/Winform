using Microsoft.Reporting.WinForms;
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
    public partial class frmReportBill : Form
    {
        public frmReportBill()
        {
            InitializeComponent();
        }

        private void frmReportBill_Load(object sender, EventArgs e)
        {

            this.rpvBill.RefreshReport();

            loadIDBill();



            this.rpvBill.RefreshReport();
        }

        private void loadIDBill()
        {
            List<IDBill> idBill = BillDAO.Instance.loadIDBill();

            cbxBill.DataSource = idBill;
            cbxBill.DisplayMember = "idBill";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using (ReportBillContextDB context = new ReportBillContextDB())
            {
                string id = cbxBill.Text;
                string query = "select h.IDHoaDon, h.SoPhong, h.CMND, k.Ho, k.TenLot, k.Ten, h.NgayLap, h.ChiSoNuocCu, h.ChiSoNuocMoi, h.ChiSoDienCu, h.ChiSoDienMoi, p.GiaPhong, (p.GiaPhong + ((h.ChiSoNuocMoi- h.ChiSoNuocCu)*15000) + (h.ChiSoDienMoi - h.ChiSoDienCu)* 3000 ) as [ThanhTien]  from HoaDon h, Phong p, KhachHang k where h.CMND = k.CMND and h.SoPhong = p.SoPhong and h.IDHoaDon = N'" + id + "'";


                List<ReportBill> listReport = context.Database.SqlQuery<ReportBill>(query).ToList();

                if (cbxBill.Text != "")
                {
                    listReport = listReport.Where(p => p.IDHoaDon.ToLower() == cbxBill.Text.ToLower()).ToList();
                }


                this.rpvBill.LocalReport.ReportPath = "E:/Project/Winform/QLPT/QLPT/ReportBill.rdlc";

                ReportDataSource report = new ReportDataSource("ReportBillDataSet", listReport);

                this.rpvBill.LocalReport.DataSources.Clear();
                this.rpvBill.LocalReport.DataSources.Add(report);
                this.rpvBill.RefreshReport();
            }
        }
    }
}
