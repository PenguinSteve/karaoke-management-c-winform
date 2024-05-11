using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_AccountInformation
    {
        private DTO_Staff staff;
        private DTO_Customer customer;

        public DAL_AccountInformation(string username)
        {
            staff = new DTO_Staff("", "", "", username, "");
            customer = new DTO_Customer("", "", username);
        }

        public DataTable getStaffInformation()
        {
            string query = "SELECT * FROM Staff WHERE StaffUsername = @username";
            return Connection.Instance.SelectQuery(query, new object[] {staff.StaffUsername});
        }

        public DataTable getCustomerInformation()
        {
            string query = "SELECT * FROM Customer WHERE CustomerUsername = @username";
            return Connection.Instance.SelectQuery(query, new object[] {customer.CustomerUsername});
        }

        public int updatePasswordAdmin(string password)
        {
            string query = "UPDATE Account SET AccountPassword = @password WHERE AccountUsername = 'admin'";
            return Connection.Instance.actionQuery(query, new object[] {password});
        }

        public bool updateStaffInformation(DTO_Staff staff, DTO_Account account)
        {
            string queryUpdateAccount = "UPDATE Account SET AccountPassword = @password WHERE AccountUsername = @username";
            string queryUpdateStaff = "UPDATE Staff SET StaffName = @name , StaffPhone = @phone WHERE StaffUsername = @username";

            int dataReturnAccount = Connection.Instance.actionQuery(queryUpdateAccount, new object[] { account.AccountPassword, account.AccountUsername });
            int dataReturnStaff = Connection.Instance.actionQuery(queryUpdateStaff, new object[] { "N'" + staff.StaffName + "'", staff.StaffPhone, account.AccountUsername });

            if(dataReturnAccount > 0 && dataReturnStaff > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateCustomerInformation(DTO_Customer customer, DTO_Account account)
        {
            string queryUpdateAccount = "UPDATE Account SET AccountPassword = @password WHERE AccountUsername = @username";
            string queryUpdateStaff = "UPDATE Customer SET CustomerName = @name , CustomerPhone = @phone WHERE CustomerUsername = @username";

            int dataReturnAccount = Connection.Instance.actionQuery(queryUpdateAccount, new object[] { account.AccountPassword, account.AccountUsername });
            int dataReturnCustomer = Connection.Instance.actionQuery(queryUpdateStaff, new object[] {customer.CustomerName, customer.CustomerPhone, account.AccountUsername});

            if (dataReturnAccount > 0 && dataReturnCustomer > 0)
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