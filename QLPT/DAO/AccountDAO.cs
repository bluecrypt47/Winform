using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            // Chuyển Password qua byte
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            // Băm nó ra mã của máy tính và lưu vào hasData
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            // Lưu cái bảng vừa băm vào 1 cái list có kiểu ToString() và đảo ngược nó lại
            //var list = hasData.ToString();
            //list.Reverse();

            string hasPass = "";

            foreach(byte item in hasData)
            {
                hasPass += item;
            }

            

            string query = "exec Logins @userName =N'"+userName+"', @password =N'"+hasPass+"' ";/* bạn có thể thay password bằng cái list vừa tạo*/

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }


        // load danh sách account lên
        public List<Account> loadAccountList()
        {
            List<Account> accountList = new List<Account>();

            DataTable data = DataProvider.Instance.ExecuteQuery("getAccount");

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accountList.Add(account);
            }

            return accountList;
        }



        // Thêm Account
        public bool InsertAccount(string userName, string viewName, string passWord, double typeAccount)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT TaiKhoan VALUES(N'" + userName + "', N'" + viewName + "', N'" + passWord + "', " + typeAccount + ") ");

            return result > 0;
        }

        // Sửa Account
        public bool EditAccount(string userName, string viewName, string passWord, double typeAccount)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("update TaiKhoan set TenTaiKhoan =N'" + userName + "', TenHienThi = N'" + viewName + "', MatKhau = N'" + passWord + "', IDLoai = '" + typeAccount + "' where TenTaiKhoan = N'" + userName + "'");

            return result > 0;
        }

        // Xóa Account
        public bool DelAcount(string userName)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("delete TaiKhoan where TenTaiKhoan = N'" + userName + "'");

            return result > 0;
        }

    }
}
