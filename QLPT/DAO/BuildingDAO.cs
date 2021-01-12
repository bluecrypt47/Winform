using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class BuildingDAO
    {
        private static BuildingDAO instance;

        public static BuildingDAO Instance
        {
            get { if (instance == null) instance = new BuildingDAO(); return instance; }
            private set => instance = value;
        }

        private BuildingDAO() { }

        // load building
        public List<Building> loadBuildingList()
        {
            List<Building> buildingList = new List<Building>();

            DataTable data = DataProvider.Instance.ExecuteQuery("getBuildings");

            foreach (DataRow item in data.Rows)
            {
                Building building = new Building(item);
                buildingList.Add(building);
            }

            return buildingList;
        }


        // Thêm building
        public bool InsertBuilding(string idBuilding, string addressBuilding)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("insertBuilding @id =N'" + idBuilding+"', @address = N'"+addressBuilding+"'");

            return result > 0;
        }

        // Xóa building
        public bool DelBuilding(string idBuilding)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("delBuilding N'"+idBuilding+"'");

            return result > 0;
        }

        // sửa building
        public bool UpdateBuilding(string idBuilding, string addressBuilding)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("updateBuilding @id= N'"+idBuilding+"', @address= N'"+addressBuilding+"'");

            return result > 0;
        }
    }
}
