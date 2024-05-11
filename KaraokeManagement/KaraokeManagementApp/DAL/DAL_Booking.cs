using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Booking
    {
        public DAL_Booking() { }

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

        public string getBillID()
        {
            string query = "SELECT BillID FROM Bill ORDER BY CAST(SUBSTRING(BillID, 2, LEN(BillID)) AS INT) DESC";
            return Connection.Instance.executeScalar(query);
        }

        public DataTable getSpecificDataBookingDetail(string roomID, DateTime timeCompare)
        {
            string query = "SELECT bk.BookID N'Mã đặt phòng', bk.RoomID N'Mã phòng', RoomName N'Tên phòng', RoomType N'Loại phòng', RoomPrice N'Giá phòng', TimeStart N'Thời gian đặt'," +
                " bk.CustomerPhone N'Số điện thoại', bk.CustomerUsername N'Tên tài khoản', CustomerName N'Tên khách hàng', bk.Status N'Trạng thái' FROM BookRoom bk INNER JOIN Room r ON bk.RoomID = r.RoomID LEFT JOIN Bill b ON bk.BookID = b.BookID WHERE bk.RoomID = @roomID AND ( (TimeStart >= @timeMin AND TimeStart < @timeMax AND bk.Status = N'Đặt trước') OR (bk.Status = N'Đang được sử dụng') )";
            return Connection.Instance.SelectQuery(query, new object[] { roomID, timeCompare.ToString("yyyy-MM-dd"), timeCompare.AddDays(1).ToString("yyyy-MM-dd") });
        }

        public bool insertBooking(string bookID, string roomID, DateTime timeStart, string phone, string billID, string staffID, string customerName)
        {
            string queryBookRoom = "INSERT INTO BookRoom (BookID, RoomID, TimeStart, CustomerPhone, Status) VALUES ( @bookID , @roomID , @timeStart , @phone , N'Đang được sử dụng' ) ";
            string queryBill = "INSERT INTO Bill (BillID, StaffID, CustomerName, CustomerPhone, BookID) VALUES ( @billID , @staffID , @customerName , @customerPhone , @bookID )";

            Connection.Instance.actionQuery("alter table BookRoom nocheck constraint all");
            Connection.Instance.actionQuery("alter table Bill nocheck constraint all");

            int dataReturnBookRoom = Connection.Instance.actionQuery(queryBookRoom, new object[] { bookID, roomID, timeStart.ToString("yyyy-MM-dd HH:mm"), phone });
            int dataReturnBillRoom = Connection.Instance.actionQuery(queryBill, new object[] { billID, staffID, customerName, phone, bookID });

            Connection.Instance.actionQuery("alter table BookRoom check constraint all");
            Connection.Instance.actionQuery("alter table Bill check constraint all");


            if (dataReturnBookRoom > 0 && dataReturnBillRoom > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateConfirmBookRoom(string bookID, DateTime timeStart, string billID, string staffID, string customerName, string phone, string customerUsername)
        {
            string queryBookRoom = "UPDATE BookRoom SET TimeStart = @timeStart , Status = N'Đang được sử dụng' WHERE BookID = @bookID ";
            string queryBill = "INSERT INTO Bill (BillID, StaffID, CustomerName, CustomerPhone, CustomerUsername, BookID) VALUES ( @billID , @staffID , @customerName , @customerPhone , @customerUsername , @bookID )";

            Connection.Instance.actionQuery("alter table BookRoom nocheck constraint all");
            Connection.Instance.actionQuery("alter table Bill nocheck constraint all");

            int dataReturnBookRoom = Connection.Instance.actionQuery(queryBookRoom, new object[] { timeStart.ToString("yyyy-MM-dd HH:mm"), bookID });
            int dataReturnBillRoom = Connection.Instance.actionQuery(queryBill, new object[] { billID, staffID, customerName, phone, customerUsername, bookID });

            Connection.Instance.actionQuery("alter table BookRoom check constraint all");
            Connection.Instance.actionQuery("alter table Bill check constraint all");


            if (dataReturnBookRoom > 0 && dataReturnBillRoom > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateBooking(string bookID, string phone, string customerName)
        {
            string queryBookRoom = "UPDATE BookRoom SET CustomerPhone = @phone WHERE BookID = @bookID";
            string queryBill = "UPDATE Bill SET CustomerName = @customerName , CustomerPhone = @phone WHERE BookID = @bookID";

            int dataReturnBookRoom = Connection.Instance.actionQuery(queryBookRoom, new object[] { phone, bookID });
            int dataReturnBill = Connection.Instance.actionQuery(queryBill, new object[] { customerName, phone, bookID });
            if (dataReturnBookRoom > 0 && dataReturnBill > 0)
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

        public bool deleteUsingRoom(string bookID)
        {
            string queryBookRoom = "DELETE FROM BookRoom WHERE BookID = @bookID";
            
            int dataReturnBookRoom = Connection.Instance.actionQuery(queryBookRoom, new object[] { bookID });
            
            if (dataReturnBookRoom > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getCurrentBillID(string bookID)
        {
            string query = "SELECT BillID FROM Bill WHERE BookID = '" + bookID + "'";
            return Connection.Instance.executeScalar(query);
        }
    }
}
