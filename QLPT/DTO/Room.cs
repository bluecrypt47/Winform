using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class Room
    {
        //private string numberRoom;

        //private string iDBuilding;

        //private double numberCustomer;

        //private string statusRoom;

        //private double price;

        //public string NumberRoom { get => numberRoom; set => numberRoom = value; }
        //public string IDBuilding { get => iDBuilding; set => iDBuilding = value; }
        //public double NumberCustomer { get => numberCustomer; set => numberCustomer = value; }
        //public string StatusRoom { get => statusRoom; set => statusRoom = value; }
        //public double Price { get => price; set => price = value; }

        //public Room() { }

        //public Room(string numberRoom, string iDBuilding, double numberCustomer, string statusRoom, double price)
        //{
        //    this.numberRoom = numberRoom;
        //    this.iDBuilding = iDBuilding;
        //    this.numberCustomer = numberCustomer;
        //    this.statusRoom = statusRoom;
        //    this.price = price;
        //}

        //public Room(DataRow row)
        //{
        //    this.numberRoom = row["SoPhong"].ToString();
        //    this.iDBuilding = row["IDDayNha"].ToString();
        //    this.numberCustomer = Convert.ToDouble(row["SoNguoiTroCungLuc"].ToString());
        //    this.statusRoom = row["TinhTrangPhong"].ToString();
        //    this.price = Convert.ToDouble(row["GiaPhong"].ToString());
        //}

        private string numberRoom;

        private string iDBuilding;

        private string surName;

        private string lastName;

        private string name;

        private string cMND;

        private string statusDepositMoney;

        private DateTime? dateTime;

        private double price;

        public string NumberRoom { get => numberRoom; set => numberRoom = value; }
        public string IDBuilding { get => iDBuilding; set => iDBuilding = value; }
        public double Price { get => price; set => price = value; }
        public string SurName { get => surName; set => surName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public DateTime? DateTime { get => dateTime; set => dateTime = value; }
        public string StatusDepositMoney { get => statusDepositMoney; set => statusDepositMoney = value; }

        public Room() { }

        public Room(string numberRoom, string iDBuilding, string surName, string lastName, string name, string cMND, string statusDepositMoney, DateTime? dateTime, double price)
        {
            this.numberRoom = numberRoom;
            this.iDBuilding = iDBuilding;
            this.surName = surName;
            this.lastName = lastName;
            this.name = name;
            this.cMND = cMND;
            this.StatusDepositMoney = statusDepositMoney;
            this.dateTime = dateTime;
            this.price = price;
        }

        public Room(DataRow row)
        {
            this.numberRoom = row["SoPhong"].ToString();
            this.iDBuilding = row["IDDayNha"].ToString();
            this.surName = row["Ho"].ToString();
            this.lastName = row["TenLot"].ToString();
            this.name = row["Ten"].ToString();
            this.cMND = row["CMND"].ToString();
            this.StatusDepositMoney = row["TinhTrangTienCoc"].ToString();
            this.dateTime = (DateTime?)row["NgayChuyenVao"];
            this.price = Convert.ToDouble(row["GiaPhong"].ToString());
        }
    }
}
