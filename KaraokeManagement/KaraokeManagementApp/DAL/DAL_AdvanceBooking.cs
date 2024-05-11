using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_AdvanceBooking
    {
        public DAL_AdvanceBooking() { }

        public DataTable getListRooms()
        {
            string query = "SELECT * FROM Room WHERE Status = N'Khả dụng'";
            return Connection.Instance.SelectQuery(query);
        }

        public string getBookID()
        {
            string query = "SELECT BookID FROM BookRoom ORDER BY CAST(SUBSTRING(BookID, 3, LEN(BookID)) AS INT) DESC";
            return Connection.Instance.executeScalar(query);
        }

        public bool insertBooking(string bookID, string roomID, DateTime timeStart, string phone, string username)
        {
            string query = "INSERT INTO BookRoom (BookID, RoomID, TimeStart, CustomerPhone, CustomerUsername, Status) VALUES ( @bookID , @roomID , @timeStart , @phone , @username , N'Đặt trước' ) ";
            Connection.Instance.actionQuery("alter table BookRoom nocheck constraint all");
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { bookID, roomID, timeStart.ToString("yyyy-MM-dd HH:mm"), phone, username });
            Connection.Instance.actionQuery("alter table BookRoom check constraint all");
            if (dataReturn > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateBooking(string bookID, DateTime timeStart, string phone)
        {
            string query = "UPDATE BookRoom SET TimeStart = @timeStart , CustomerPhone = @phone WHERE BookID = @bookID";
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { timeStart.ToString("yyyy-MM-dd HH:mm"), phone, bookID });
            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteBooking(string bookID)
        {
            string query = "DELETE FROM BookRoom WHERE BookID = @bookID";
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { bookID });
            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getDataBookingDetail(string roomID, DateTime timeCompare)
        {
            string query = "SELECT BookID N'Mã đặt phòng', RoomID N'Mã phòng', TimeStart N'Thời gian đặt', Status N'Trạng thái' FROM BookRoom WHERE RoomID = @roomID AND TimeStart >= @timeMin AND TimeStart < @timeMax AND Status = N'Đặt trước'";
            return Connection.Instance.SelectQuery(query, new object[] { roomID, timeCompare.ToString("yyyy-MM-dd"), timeCompare.AddDays(1).ToString("yyyy-MM-dd") });
        }

        public DataTable getDataBookingHistory(string username, DateTime timeCompare)
        {
            string query = "SELECT BookID N'Mã đặt phòng', bk.RoomID N'Mã phòng', RoomName N'Tên phòng', RoomType N'Loại phòng', RoomPrice N'Giá phòng', TimeStart N'Thời gian đặt'," +
                " CustomerPhone N'Số điện thoại', CustomerUsername N'Tên tài khoản' FROM BookRoom bk INNER JOIN Room r ON bk.RoomID = r.RoomID WHERE CustomerUsername = @username AND TimeStart >= @timeMin AND TimeStart < @timeMax AND bk.Status = N'Đặt trước'";

            return Connection.Instance.SelectQuery(query, new object[] { username, timeCompare.ToString("yyyy-MM-dd"), timeCompare.AddDays(1).ToString("yyyy-MM-dd") });
        }

        public DataTable getSpecificDataBookingDetail(string roomID, DateTime timeCompare)
        {
            string query = "SELECT BookID N'Mã đặt phòng', bk.RoomID N'Mã phòng', RoomName N'Tên phòng', RoomType N'Loại phòng', RoomPrice N'Giá phòng', TimeStart N'Thời gian đặt'," +
                " CustomerPhone N'Số điện thoại', CustomerUsername N'Tên tài khoản' FROM BookRoom bk INNER JOIN Room r ON bk.RoomID = r.RoomID WHERE bk.RoomID = @roomID AND TimeStart >= @timeMin AND TimeStart < @timeMax AND bk.Status = N'Đặt trước'";
            return Connection.Instance.SelectQuery(query, new object[] {roomID, timeCompare.ToString("yyyy-MM-dd"), timeCompare.AddDays(1).ToString("yyyy-MM-dd") });
        }
    }
}
