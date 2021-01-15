using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO(); return instance; } 
            private set => instance = value; 
        }

        private BillDAO() { }

        // load
        public List<Bill> loadBillList()
        {
            List<Bill> billList = new List<Bill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("getBill");

            foreach(DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);

                billList.Add(bill);
            }

            return billList;
        }

        // Load id bill
        public List<IDBill> loadIDBill()
        {
            List<IDBill> billList = new List<IDBill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select IDHoaDon from HoaDon");

            foreach (DataRow item in data.Rows)
            {
                IDBill bill = new IDBill(item);

                billList.Add(bill);
            }

            return billList;
        }

        // Thêm
        public bool InsertBill(string idBill, string idRoom, string CMND,  double oldNumberWater, double newNumberWater, double oldNumberElectric, double newNumberElectric)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("insertBill @idBill= N'"+idBill+ "', @idRoom= N'"+idRoom+ "', @cmnd= N'"+CMND+ "',  @oldNumberWater= "+oldNumberWater+ ", @newNumberWater= "+newNumberWater+ ", @oldNumberElectric= "+oldNumberElectric+ ", @newNumberElectric= "+newNumberElectric+"");

            return result > 0;
        }

        // Xóa
        public bool DelBill(string idBill)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("delBill @idBill= N'"+idBill+"'");

            return result > 0;
        }

        // Sửa
        public bool EditBill(string idBill, string idRoom, string CMND, double oldNumberWater, double newNumberWater, double oldNumberElectric, double newNumberElectric)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("updateBill @idBill= N'"+idBill+"', @idRoom= N'" + idRoom+"', @cmnd= N'" + CMND+"', @oldNumberWater= " + oldNumberWater+", @newNumberWater= " + newNumberWater+", @oldNumberElectric= " + oldNumberElectric+", @newNumberElectric= "+newNumberElectric+"");

            return result > 0;
        }
    }
}
