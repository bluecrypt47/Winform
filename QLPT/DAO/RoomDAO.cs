using QLPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT.DAO
{
    public class RoomDAO
    {
        //private static RoomDAO instance;

        //public static RoomDAO Instance
        //{
        //    get { if (instance == null) instance = new RoomDAO(); return instance; }
        //    private set => instance = value;
        //}

        //private RoomDAO() { }

        //public static int roomWidth = 80;
        //public static int roomHeigth = 80;
        //// load danh sách phòng lên
        //public List<Room> loadRoomList()
        //{
        //    List<Room> roomList = new List<Room>();
        //    DataTable data = DataProvider.Instance.ExecuteQuery("getRoom");

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Room room = new Room(item);
        //        roomList.Add(room);
        //    }

        //    return roomList;
        //}

        //// Thêm 
        //public bool InsertRoom(string idRoom, string building, double numberPeople, string statusRoom, double priceRoom)
        //{
        //    //INSERT Phong VALUES(N'A1-1', N'1', 1, N'Đã thuê', 2000000)
        //    int result = DataProvider.Instance.ExecuteNonQuery("INSERT Phong VALUES(N'" + idRoom + "', N'" + building + "'," + numberPeople + " , N'" + statusRoom + "', " + priceRoom + ")");

        //    return result > 0;
        //}

        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return instance; }
            private set => instance = value;
        }

        private RoomDAO() { }

        public List<Room> getListRoom()
        {
            List<Room> roomInfors = new List<Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select p.SoPhong, p.IDDayNha, k.Ho, k.TenLot, k.Ten, k.CMND, h.TinhTrangTienCoc, NgayChuyenVao, p.GiaPhong from Phong p, HopDongThueNha h, KhachHang k where p.SoPhong = h.SoPhong and h.CMND = k.CMND");

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomInfors.Add(room);
            }

            return roomInfors;
        }

        // load danh sách ID room
        public List<RoomID> getListIDRoom()
        {
            List<RoomID> roomID = new List<RoomID>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *  from Phong ");

            foreach (DataRow item in data.Rows)
            {
                RoomID room = new RoomID(item);
                roomID.Add(room);
            }

            return roomID;
        }


    }
}
