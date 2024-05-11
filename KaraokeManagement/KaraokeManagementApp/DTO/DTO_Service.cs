using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class DTO_Service
    {
        private string serviceID;
        private string serviceName;
        private double servicePrice;
        private int serviceQuantity;

        public DTO_Service(string serviceID, string serviceName, double servicePrice, int serviceQuantity)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.servicePrice = servicePrice;
            this.serviceQuantity = serviceQuantity;
        }

        public DTO_Service(DataRow row)
        {
            ServiceID = row["ServiceID"].ToString();
            ServiceName = row["ServiceName"].ToString();
            ServicePrice = (double)row["ServicePrice"];
            ServiceQuantity = (int)row["ServiceQuantity"];
        }
        public string ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        public double ServicePrice
        {
            get { return servicePrice; }
            set { servicePrice = value; }
        }

        public int ServiceQuantity
        {
            get { return serviceQuantity; }
            set { serviceQuantity = value; }
        }
    }
}
