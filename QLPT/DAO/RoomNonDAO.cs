using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT.DAO
{
    public class RoomNonDAO
    {
        private static RoomNonDAO instance;

        public static RoomNonDAO Instance 
        { 
            get { if (instance == null) instance = new RoomNonDAO(); return instance; } 
            private set => instance = value; 
        }

        private RoomNonDAO() { }

        // load phòng trống
        public List<RoomNon> getRoomNonList()
        {
            List<RoomNon> roomNonList = new List<RoomNon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Phong where  TinhTrangPhong = N'Trống'");

            foreach (DataRow item in data.Rows)
            {
                RoomNon room = new RoomNon(item);
                roomNonList.Add(room);
            }

            return roomNonList;
        }

        // Thêm 
        public bool InsertRoomNon(string idRoom, string idBuilding, double numberPeopleRoom, double priceRoom)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("insertRoom @idroom=N'"+idRoom+"', @idbuilding= N'" + idBuilding+"', @number= " + numberPeopleRoom+", @status= N'Trống', @price =" + priceRoom+"");

            return result > 0;
        }

        // Xóa
        public bool DelRoom(string idRoom)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int result = DataProvider.Instance.ExecuteNonQuery("delRoom @idroom =N'" + idRoom + "'");

                return result > 0;
            }
            else
            {
                return false;
            }
            
        }

        // Sửa
        public bool EditRoom(string idRoom, string idBuilding, double numberPeopleRoom, string statusRoom, double priceRoom)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("updateRoom @idroom=N'"+idRoom+"', @idbuilding= N'" + idBuilding+"', @number= " + numberPeopleRoom+", @status= N'" + statusRoom+"', @price =" + priceRoom+"");

            return result > 0;
        }
    }
}
