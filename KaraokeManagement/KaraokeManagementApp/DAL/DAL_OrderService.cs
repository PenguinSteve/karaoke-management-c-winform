using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_OrderService
    {
        public DAL_OrderService() { }

        public DataTable getListRooms()
        {
            string query = "SELECT * FROM Room WHERE Status = N'Khả dụng'";
            return Connection.Instance.SelectQuery(query);
        }

        public DataTable getDataBookingDetail(string roomID, DateTime timeCompare)
        {
            string query = "SELECT bk.BookID N'Mã đặt phòng', bk.RoomID N'Mã phòng', RoomName N'Tên phòng', TimeStart N'Thời gian đặt'," +
                " CustomerName N'Tên khách hàng', bk.Status N'Trạng thái' FROM BookRoom bk INNER JOIN Room r ON bk.RoomID = r.RoomID LEFT JOIN Bill b ON bk.BookID = b.BookID WHERE bk.RoomID = @roomID AND ( (TimeStart >= @timeMin AND TimeStart < @timeMax AND bk.Status = N'Đặt trước') OR (bk.Status = N'Đang được sử dụng') )";
            return Connection.Instance.SelectQuery(query, new object[] { roomID, timeCompare.ToString("yyyy-MM-dd"), timeCompare.AddDays(1).ToString("yyyy-MM-dd") });
        }

        public DataTable getServices()
        {
            string query = "SELECT * FROM Service";
            return Connection.Instance.SelectQuery(query);
        }

        public string getCurrentBillID(string bookID)
        {
            string query = "SELECT BillID FROM Bill WHERE BookID = '" + bookID + "'";
            return Connection.Instance.executeScalar(query);
        }

        public DataTable getBillDetail(string billID)
        {
            string queryBillDetail = "SELECT bd.ServiceID N'Mã dịch vụ', ServiceName N'Tên dịch vụ', bd.ServiceQuantity N'Số lượng', ServicePrice N'Giá', TotalServicePrice N'Tổng' FROM BillDetail" +
                " bd INNER JOIN Service s ON bd.ServiceID = s.ServiceID WHERE BillID = @billID";
            return Connection.Instance.SelectQuery(queryBillDetail, new object[] { billID });
        }



        public bool insertBillDetail(string billID, string serviceID, int serviceQuantity)
        {
            string query = "insertBillDetail @billID , @serviceID , @serviceQuantity ";
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { billID, serviceID, serviceQuantity });

            if(dataReturn > 0)
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
