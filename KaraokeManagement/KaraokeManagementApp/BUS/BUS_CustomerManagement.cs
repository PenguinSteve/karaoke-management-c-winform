using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CustomerManagement
    {
        DAL_CustomerManagement processCustomerManagement;
        public BUS_CustomerManagement() 
        {
            processCustomerManagement = new DAL_CustomerManagement();
        }


        public bool createCustomer(string customerName, string phone, string username)
        {
            return processCustomerManagement.insertCustomer(customerName, phone, username);
        }

        public bool checkExistUsername(string username)
        {
            DataTable existAccounts = processCustomerManagement.selectExistAccount(username);
            if (existAccounts.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable getCustomerList()
        {
            return processCustomerManagement.getCustomerList();
        }

        public bool deleteCustomer(string username)
        {
            return processCustomerManagement.deleteCustomer(username);
        }

        public bool editCustomer(string customerName, string phone, string username)
        {
            return processCustomerManagement.updateCustomer(customerName, phone, username);
        }

        public bool setDefaultPassword(string username)
        {
            return processCustomerManagement.setDefaultPassword(username);
        }
    }
}
