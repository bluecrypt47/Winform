using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class Account
    {
        private string userName;

        private string viewName;

        private string passWord;


        public string UserName { get => userName; set => userName = value; }
        public string ViewName { get => viewName; set => viewName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public Account() { }

        public Account(string userName, string viewName, string passWord)
        {
            this.userName = userName;
            this.viewName = viewName;
            this.passWord = passWord;
        }

        public Account(DataRow row)
        {
            this.userName = row["TenTaiKhoan"].ToString();
            this.viewName = row["TenHienThi"].ToString();
            this.passWord = row["MatKhau"].ToString();
        }
    }
}
