using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class Contract
    {
        private string idContract;

        private string numberRoom;

        private string cmnd;

        private string surName;

        private string lastName;

        private string name;

        private string sexual;

        private string statusDepositMoney;

        private DateTime? dateTime;

        private double depositMoney;

        public string IdContract { get => idContract; set => idContract = value; }
        public string NumberRoom { get => numberRoom; set => numberRoom = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string StatusDepositMoney { get => statusDepositMoney; set => statusDepositMoney = value; }
        public DateTime? DateTime { get => dateTime; set => dateTime = value; }
        public double DepositMoney { get => depositMoney; set => depositMoney = value; }
        public string SurName { get => surName; set => surName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public string Sexual { get => sexual; set => sexual = value; }

        public Contract() { }

        public Contract(string idConstract, string numberRoom, string cmnd, string surName, string lastName, string name, string sexual, string statusDepositMoney, DateTime? dateTime, double depositMoney)
        {
            this.idContract = idConstract;
            this.numberRoom = numberRoom;
            this.cmnd = cmnd;
            this.surName = surName;
            this.lastName = lastName;
            this.name = name;
            this.sexual = sexual;
            this.statusDepositMoney = statusDepositMoney;
            this.dateTime = dateTime;
            this.depositMoney = depositMoney;
        }

        public Contract(DataRow row)
        {
            this.idContract = row["IDHopDong"].ToString();
            this.numberRoom = row["SoPhong"].ToString();
            this.cmnd = row["CMND"].ToString();
            this.surName = row["Ho"].ToString();
            this.lastName = row["TenLot"].ToString();
            this.name = row["Ten"].ToString();
            this.sexual = row["GioiTinh"].ToString();
            this.statusDepositMoney = row["TinhTrangTienCoc"].ToString();
            this.dateTime = (DateTime?)(row["NgayChuyenVao"]);
            this.depositMoney = Convert.ToDouble( row["TienCoc"].ToString());
        }
    }
}
