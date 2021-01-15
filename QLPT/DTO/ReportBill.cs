using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class ReportBill
    {
        public string IDHoaDon { get; set; }

        public string SoPhong { get; set; }

        public string CMND { get; set; }

        public string Ho { get; set; }

        public string TenLot { get; set; }

        public string Ten { get; set; }

        public DateTime? NgayLap { get; set; }

        public Int64 ChiSoNuocCu { get; set; }

        public Int64 ChiSoNuocMoi { get; set; }

        public Int64 ChiSoDienCu { get; set; }

        public Int64 ChiSoDienMoi { get; set; }

        public Int64 GiaPhong { get; set; }

        public Int64 ThanhTien { get; set; }
    }
}
