using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ServiceManagement
    {
        DAL_ServiceManagement processServiceManagement;
        public BUS_ServiceManagement()
        {
            processServiceManagement = new DAL_ServiceManagement();
        }

        public string autoGenerateServiceID()
        {
            string serviceID = processServiceManagement.getServiceID();
            if (serviceID != null)
            {
                int id = int.Parse(serviceID.Substring(2));
                id++;
                return "DV" + id;
            }
            else
            {
                return "DV1";
            }
        }

        public bool createService(string serviceID, string serviceName, string servicePrice, string serviceQuantity)
        {
            return processServiceManagement.insertService(serviceID, serviceName, servicePrice, serviceQuantity);
        }

        public DataTable getServiceList()
        {
            return processServiceManagement.getServiceList();
        }

        public bool deleteService(string serviceID)
        {
            return processServiceManagement.deleteService(serviceID);
        }


        public bool editService(string serviceID, string serviceName, string servicePrice, string serviceQuantity)
        {
            return processServiceManagement.updateService(serviceID, serviceName, servicePrice, serviceQuantity);
        }
    }
}
