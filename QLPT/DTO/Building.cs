using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DTO
{
    public class Building
    {
        private string idBuilding;

        private string addressBuilding;

        public string IdBuilding { get => idBuilding; set => idBuilding = value; }
        public string AddressBuilding { get => addressBuilding; set => addressBuilding = value; }

        public Building() { }
        public Building(string idBuilding, string addressBuilding)
        {
            this.idBuilding = idBuilding;
            this.addressBuilding = addressBuilding;
        }

        public Building(DataRow row)
        {
            this.idBuilding = row["IDDayNha"].ToString();
            this.addressBuilding = row["DiaChiDay"].ToString();
        }
    }
}
