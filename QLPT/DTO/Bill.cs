using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    
    public class Bill
    {
        private string iDBill;

        private string iDRoom;

        private string cMND;

        private string surName;

        private string lastName;

        private string name;

        private DateTime? dateTime;

        private double oldNumberElectric;

        private double newNumberElectric;

        private double oldNumberWater;

        private double newNumberWater;

        private double priceRoom;

        private double totalPrice;



        public string IDBill { get => iDBill; set => iDBill = value; }
        public string IDRoom { get => iDRoom; set => iDRoom = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public DateTime? DateTime { get => dateTime; set => dateTime = value; }
        public double OldNumberElectric { get => oldNumberElectric; set => oldNumberElectric = value; }
        public double NewNumberElectric { get => newNumberElectric; set => newNumberElectric = value; }
        public double OldNumberWater { get => oldNumberWater; set => oldNumberWater = value; }
        public double NewNumberWater { get => newNumberWater; set => newNumberWater = value; }
        public string SurName { get => surName; set => surName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public double PriceRoom { get => priceRoom; set => priceRoom = value; }

        public Bill() { }

        public Bill(string iDBill, string iDRoom, string cMND, string surName, string lastName, string name, DateTime? dateTime, double oldNumberElectric, double newNumberElectric, double oldNumberWater, double newNumberWater, double priceRoom, double totalPrice)
        {
            this.iDBill = iDBill;
            this.iDRoom = iDRoom;
            this.cMND = cMND;
            this.surName = surName;
            this.lastName = lastName;
            this.name = name;
            this.dateTime = dateTime;
            this.oldNumberWater = oldNumberWater;
            this.newNumberWater = newNumberWater;
            this.oldNumberElectric = oldNumberElectric;
            this.newNumberElectric = newNumberElectric;
            this.priceRoom = priceRoom;
            this.totalPrice = totalPrice;
        }

        public Bill(DataRow row)
        {
                this.iDBill = row["IDHoaDon"].ToString();
                this.iDRoom = row["SoPhong"].ToString();
                this.cMND = row["CMND"].ToString();
                this.surName = row["Ho"].ToString();
                this.lastName = row["TenLot"].ToString();
                this.name = row["Ten"].ToString();
                this.dateTime = (DateTime?)row["NgayLap"];
                this.oldNumberWater = Convert.ToDouble(row["ChiSoNuocCu"].ToString());
                this.newNumberWater = Convert.ToDouble(row["ChiSoNuocMoi"].ToString());
                this.oldNumberElectric = Convert.ToDouble(row["ChiSoDienCu"].ToString());
                this.newNumberElectric = Convert.ToDouble(row["ChiSoDienMoi"].ToString());
                this.priceRoom = Convert.ToDouble(row["GiaPhong"].ToString());
                this.totalPrice = Convert.ToDouble(row["Thành tiền"].ToString());
          
        }
    }
}
