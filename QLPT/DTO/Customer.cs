using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class Customer
    {
        private string cMND;

        private string surName;

        private string lastName;

        private string name;

        private string sexual;

        public string CMND { get => cMND; set => cMND = value; }
        public string SurName { get => surName; set => surName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public string Sexual { get => sexual; set => sexual = value; }

        public Customer() { }

        public Customer(string cMND, string surName, string lastName, string name, string sexual)
        {
            this.cMND = cMND;
            this.surName = surName;
            this.lastName = lastName;
            this.name = name;
            this.sexual = sexual;
        }

        public Customer(DataRow row)
        {
            this.cMND = row["CMND"].ToString();
            this.surName = row["Ho"].ToString();
            this.lastName = row["TenLot"].ToString();
            this.name = row["Ten"].ToString();
            this.sexual = row["GioiTinh"].ToString();
        }
    }
}
