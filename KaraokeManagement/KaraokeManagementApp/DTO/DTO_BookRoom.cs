using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BookRoom
    {
        private string bookID;
        private string roomID;
        private DateTime timeStart;
        private DateTime? timeEnd;
        private string customerPhone;
        private string customerUsername;
        private string status;

        public DTO_BookRoom(string bookID, string roomID, DateTime timeStart, DateTime? timeEnd, string customerPhone, string customerUsername, string status)
        {
            this.bookID = bookID;
            this.roomID = roomID;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.customerPhone = customerPhone;
            this.customerUsername = customerUsername;
            this.status = status;
        }

        public DTO_BookRoom(DataRow row)
        {
            BookID = row["BookID"].ToString();
            RoomID = row["RoomID"].ToString();
            TimeStart = (DateTime)row["TimeStart"];
            var TimeEndTemp = row["TimeEnd"];
            if(TimeEndTemp.ToString() != "")
            {
                TimeEnd = (DateTime?)row["TimeEnd"];
            }
            else
            {
                TimeEnd = DateTime.Parse("");
            }
            CustomerPhone = row["CustomerPhone"].ToString();
            CustomerUsername = row["CustomerUsername"].ToString();
            Status = row["Status"].ToString();
        }

        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public DateTime TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }

        public DateTime? TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }

        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public string CustomerUsername
        {
            get { return customerUsername; }
            set { customerUsername = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
