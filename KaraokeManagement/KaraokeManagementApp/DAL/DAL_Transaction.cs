using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Transaction
    {
        public DAL_Transaction() { }

        public DataTable getBillDetail(string billID)
        {
            string queryBillDetail = "SELECT bd.ServiceID N'Mã dịch vụ', ServiceName N'Tên dịch vụ', bd.ServiceQuantity N'Số lượng', ServicePrice N'Giá', TotalServicePrice N'Tổng' FROM BillDetail" +
                " bd LEFT JOIN Service s ON bd.ServiceID = s.ServiceID WHERE BillID = @billID";
            return Connection.Instance.SelectQuery(queryBillDetail, new object[] { billID });
        }
      
        public bool updateConfirmTransaction(string billID, string bookID, DateTime billDate, double totalPrice, DateTime timeEnd)
        {
            string queryBill = "UPDATE Bill SET BillDate = @billDate , TotalPrice = @totalPrice WHERE BillID = @billID ";
            string queryBookRoom = "UPDATE BookRoom SET TimeEnd = @timeEnd , Status = N'Đã thanh toán' WHERE BookID = @bookID ";

            int dataReturnBill = Connection.Instance.actionQuery(queryBill, new object[] { billDate, totalPrice, billID });
            int dataReturnBookRoom = Connection.Instance.actionQuery(queryBookRoom, new object[] { timeEnd.ToString("yyyy-MM-dd HH:mm"), bookID });

            if(dataReturnBookRoom > 0 && dataReturnBill > 0)
            {
                return true;
            }
            return false;
        }
    }
}
