using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class RoomNon
    {
        private string idRoomNon;

        private string idBuilding;

        private double numberPeopleRoom;

        private string statusRoomNon;

        private double priceRoom;
        public string StatusRoomNon { get => statusRoomNon; set => statusRoomNon = value; }
        public string IdRoomNon { get => idRoomNon; set => idRoomNon = value; }
        public string IdBuilding { get => idBuilding; set => idBuilding = value; }
        public double PriceRoom { get => priceRoom; set => priceRoom = value; }
        public double NumberPeopleRoom { get => numberPeopleRoom; set => numberPeopleRoom = value; }

        public RoomNon() { }

        public RoomNon(string idRoomNon, string idBuilding, double numberPeopleRoom, string statusRoomNon, double priceRoom)
        {
            this.idRoomNon = idRoomNon;
            this.idBuilding = idBuilding;
            this.numberPeopleRoom = numberPeopleRoom;
            this.statusRoomNon = statusRoomNon;
            this.priceRoom = priceRoom;
        }

        public RoomNon(DataRow row)
        {
            this.idRoomNon = row["SoPhong"].ToString();
            this.idBuilding = row["IDDayNha"].ToString();
            this.numberPeopleRoom = Convert.ToDouble(row["SoNguoiTroCungLuc"].ToString());
            this.statusRoomNon = row["TinhTrangPhong"].ToString();
            this.priceRoom = Convert.ToDouble(row["GiaPhong"].ToString());
        }
    }
}
