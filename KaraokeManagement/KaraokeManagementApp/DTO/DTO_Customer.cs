using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private string customerName;
        private string customerPhone;
        private string customerUsername;

        public DTO_Customer(string customerName, string customerPhone, string customerUsername)
        {
            this.customerPhone = customerPhone;
            this.customerName = customerName;
            this.customerUsername = customerUsername;
        }

        public DTO_Customer(DataRow row)
        {
            CustomerName = row["CustomerName"].ToString();
            CustomerPhone = row["CustomerPhone"].ToString();
            CustomerUsername = row["CustomerUsername"].ToString();
        }

        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerUsername
        {
            get { return customerUsername; }
            set { customerUsername = value; }
        }
    }
}
