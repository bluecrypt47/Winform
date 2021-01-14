using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set => instance = value;
        }

        private CustomerDAO() { }

        public List<Customer> loadCustomerList()
        {
            List<Customer> customerList = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("getCustomer");

            foreach (DataRow item in data.Rows)
            {
                Customer customers = new Customer(item);

                customerList.Add(customers);
            }

            return customerList;
        }

        public List<Customer> loadIDCustomerList(string id)
        {
            List<Customer> customerIDList = new List<Customer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select CMND from HopDongThueNha where SoPhong =N' " + id+"'");

            foreach (DataRow item in data.Rows)
            {
                Customer customers = new Customer(item);

                customerIDList.Add(customers);
            }

            return customerIDList;
        }

        // Thêm
        public bool InsertCustomer(string cmnd, string surName, string lastName, string name, string sexual)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("insertCustomer @cmnd= N'"+cmnd+ "', @surname= N'"+surName+ "', @lastname= N'"+lastName+ "', @name= N'"+name+ "', @sexual= N'"+sexual+"'");

            return data > 0;
        }

        // Xóa
        public bool DelCustomer(string cmnd)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("delCustomer @cmnd= N'" + cmnd+ "'");

            return data > 0;
        }

        // Sửa
        public bool UpdateCustomer(string cmnd, string surName, string lastName, string name, string sexual)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("updateCustomer @cmnd= N'"+cmnd+"', @surname= N'" + surName+"', @lastname= N'" + lastName+"', @name= N'" + name+"', @sexual= N'" + sexual+"'");

            return data > 0;
        }
    }
}
