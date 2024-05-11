using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BillDetail
    {
        private string billId;
        private string serviceID;
        private int serviceQuantity;
        private double totalServicePrice;

        public DTO_BillDetail(string billID, string serviceID, int serviceQuantity, double totalServicePrice)
        {
            this.billId = billID;
            this.serviceID = serviceID;
            this.serviceQuantity = serviceQuantity;
            this.totalServicePrice = totalServicePrice;
        }

        public DTO_BillDetail(DataRow row)
        {
            BillID = row["BillID"].ToString();
            ServiceID = row["ServiceID"].ToString();
            ServiceQuantity = (int)row["ServiceQuantity"];
            TotalServicePrice = (double)row["TotalServicePrice"];
        }

        public string BillID
        {
            get { return billId; }
            set { billId = value; }
        }

        public string ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        public int ServiceQuantity
        {
            get { return serviceQuantity; }
            set { serviceQuantity = value; }
        }

        public double TotalServicePrice
        {
            get { return totalServicePrice; }
            set { totalServicePrice = value; }
        }
    }
}
