using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ServiceManagement
    {
        public DAL_ServiceManagement() { }

        public string getServiceID()
        {
            string query = "SELECT ServiceID FROM Service ORDER BY CAST(SUBSTRING(ServiceID, 3, LEN(ServiceID)) AS INT) DESC";
            return Connection.Instance.executeScalar(query);
        }

        public bool insertService(string serviceID, string serviceName, string servicePrice, string serviceQuantity)
        {
            string query = "INSERT INTO Service VALUES( @serviceID , @serviceName , @servicePrice , @serviceQuantity )";

            int dataReturnService = Connection.Instance.actionQuery(query, new object[] { serviceID, serviceName, servicePrice, serviceQuantity });

            if (dataReturnService > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getServiceList()
        {
            string query = "SELECT ServiceID N'Mã dịch vụ', ServiceName N'Tên dịch vụ' , ServicePrice N'Giá dịch vụ', ServiceQuantity N'Số lượng' FROM Service";
            return Connection.Instance.SelectQuery(query);
        }

        public bool deleteService(string serviceID)
        {
            string query = "DELETE FROM Service WHERE serviceID = @serviceID ";
            Connection.Instance.actionQuery("alter table BillDetail nocheck constraint all");
            
            int dataReturn = Connection.Instance.actionQuery(query, new object[] { serviceID });

            Connection.Instance.actionQuery("alter table BillDetail check constraint all");
            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateService(string serviceID, string serviceName, string servicePrice, string serviceQuantity)
        {
            string query = "UPDATE Service SET ServiceName = @serviceName , ServicePrice = @servicePrice , ServiceQuantity = @serviceQuantity WHERE ServiceID = @serviceID";

            int dataReturn = Connection.Instance.actionQuery(query, new object[] { serviceName, servicePrice, serviceQuantity, serviceID });

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
