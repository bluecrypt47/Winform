using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class IDBill
    {
        private string idBill;

        public string IdBill { get => idBill; set => idBill = value; }

        public IDBill() { }

        public IDBill(string idBill)
        {
            this.idBill = idBill;
        }

        public IDBill (DataRow row)
        {
            this.idBill = row["IDHoaDon"].ToString();
        }
    }
}
