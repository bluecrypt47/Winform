using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class DetailsRoomDAO
    {
        private static DetailsRoomDAO instance;

        public static DetailsRoomDAO Instance 
        {
            get { if (instance == null) instance = new DetailsRoomDAO(); return instance; } 
            private set => instance = value; 
        }

        private DetailsRoomDAO() { }

        public bool InsertRoom(string idRoom, string idBuilding, double numPeople, string status, double priceRoom)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT Phong VALUES(N'"+idRoom+ "', N'" + idBuilding + "', " + numPeople + ", N'" + status + "', " + priceRoom + ")");

            return result > 0;
        }
    }
}
