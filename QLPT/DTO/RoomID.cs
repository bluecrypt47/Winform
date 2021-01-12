using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class RoomID
    {
        private string numberRoom;

        private string iDBuilding;

        private double price;

        private double number;

        private string status;


        public string NumberRoom { get => numberRoom; set => numberRoom = value; }
        public string IDBuilding { get => iDBuilding; set => iDBuilding = value; }
        public double Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
        public double Number { get => number; set => number = value; }

        public RoomID() { }

        public RoomID(string numberRoom, string iDBuilding, double numberPeopel, string status, double price)
        {
            this.numberRoom = numberRoom;
            this.iDBuilding = iDBuilding;
            this.Number = Number;
            this.status = status;
            this.price = price;
        }

        public RoomID(DataRow row)
        {
            this.numberRoom = row["SoPhong"].ToString();
            this.iDBuilding = row["IDDayNha"].ToString();
            this.Number = Convert.ToDouble(row["SoNguoiTroCungLuc"].ToString());
            this.price = Convert.ToDouble(row["GiaPhong"].ToString());
        }
    }
}
