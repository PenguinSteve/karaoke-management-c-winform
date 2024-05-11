using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private string billID;
        private string staffID;
        private string customerName;
        private DateTime? billDate;
        private double totalPrice;
        private string customerPhone;
        private string customerUsername;
        private string bookID;

        public DTO_Bill(string billID, string staffID, string customerName, DateTime? billDate, double totalPrice, string customerPhone, string customerUsername, string bookID)
        {
            this.billID = billID;
            this.staffID = staffID;
            this.customerName = customerName;
            this.billDate = billDate;
            this.totalPrice = totalPrice;
            this.customerPhone = customerPhone;
            this.customerUsername = customerUsername;
            this.bookID = bookID;
        }

        public DTO_Bill(DataRow row)
        {
            BillID = row["BillID"].ToString();
            StaffID = row["StaffID"].ToString();
            CustomerName = row["CustomerName"].ToString();
            
            var BillDateTemp = row["BillDate"];
            if (BillDateTemp.ToString() != "")
            {
                BillDate = (DateTime?)row["BillDate"];
            }
            else
            {
                BillDate = DateTime.Parse("");
            }
            TotalPrice = (double)row["TotalPrice"];
            CustomerPhone = row["CustomerPhone"].ToString();
            CustomerUsername = row["CustomerUsername"].ToString();
            BookID = row["BookID"].ToString();
        }

        public string BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public DateTime? BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
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

        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        
    }
}