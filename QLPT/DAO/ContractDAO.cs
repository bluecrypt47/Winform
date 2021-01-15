using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class ContractDAO
    {
        private static ContractDAO instance;

        public static ContractDAO Instance 
        {
            get { if (instance == null) instance = new ContractDAO();return instance; } 
            private set => instance = value; 
        }

        private ContractDAO() { }

        // load
        public List<Contract> loadContractList()
        {
            List<Contract> contractList = new List<Contract>();
            DataTable data = DataProvider.Instance.ExecuteQuery("getContract");

            foreach(DataRow item in data.Rows)
            {
                Contract contract = new Contract(item);

                contractList.Add(contract);
            }

            return contractList;
        }

        // Thêm 
        //string idContract, string numberRoom, string cmnd, string surName, string lastName, string name, string sexual, DateTime? dateTime, string statusDepositMoney, double depositMoney
        public bool InsertContract(string idContract, string numberRoom, string cmnd, string statusDepositMoney, double depositMoney)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("insertContract @idContract= N'"+idContract+"', @idRoom= N'" + numberRoom+"', @cmnd= N'" + cmnd+"', @statusDeposit= N'" + statusDepositMoney+"', @depositMoney=" + depositMoney+"");

            return result > 0;
        }

        // Sửa
        public bool EditContract(string idContract, string numberRoom, string cmnd, DateTime? dateTime, string statusDepositMoney, double depositMoney)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("set dateformat dmy exec updateContract @idContract =N'" + idContract+"', @idRoom= N'"+numberRoom+"', @cmnd= N'"+cmnd+"', @statusDeposit= N'"+statusDepositMoney+"', @dateTime= N'"+dateTime+"', @depositMoney= "+depositMoney+"");

            return result > 0;
        }

        // Xóa 
        public bool DelContract(string idContract)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("delContract @idContract= N'"+idContract+"'");

            return result > 0;
        }
    }
}
