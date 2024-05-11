using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_RoomManagement
    {
        public DAL_RoomManagement() { }

        public string getRoomID()
        {
            string query = "SELECT RoomID FROM Room ORDER BY CAST(SUBSTRING(RoomID, 2, LEN(RoomID)) AS INT) DESC";
            return Connection.Instance.executeScalar(query);
        }

        public bool insertRoom(string roomID, string roomName, string roomType, string roomPrice)
        {
            string query = "INSERT INTO Room VALUES( @roomID , @roomName , @roomType , @roomPrice , N'Khả dụng' )";
            
            int dataReturnRoom = Connection.Instance.actionQuery(query, new object[] { roomID, roomName, roomType, roomPrice });

            if (dataReturnRoom > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getRoomList()
        {
            string query = "SELECT RoomID N'Mã phòng', RoomName N'Tên phòng' , RoomType N'Loại phòng', RoomPrice N'Giá phòng', Status N'Trạng thái' FROM Room";
            return Connection.Instance.SelectQuery(query);
        }

        public bool updateDisableRoom(string roomID)
        {
            string query = "UPDATE Room SET Status = N'Vô hiệu hóa' WHERE RoomID = @roomID ";
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { roomID });

            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateEnableRoom(string roomID)
        {
            string query = "UPDATE Room SET Status = N'Khả dụng' WHERE RoomID = @roomID ";
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { roomID });

            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateRoom(string roomID, string roomName, string roomType, string roomPrice)
        {
            string query = "UPDATE Room SET RoomName = @roomName , RoomType = @roomType , RoomPrice = @roomPrice WHERE RoomID = @roomID";

            int dataReturn = Connection.Instance.actionQuery(query, new object[] { roomName, roomType, roomPrice, roomID });

            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
