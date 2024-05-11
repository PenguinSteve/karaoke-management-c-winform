using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CustomerManagement
    {
        public DAL_CustomerManagement() { }

        public bool insertCustomer(string customerName, string phone, string username)
        {
            string insertAccount = "INSERT INTO Account VALUES( @username , @password , N'khách' )";
            string insertCustomer = "INSERT INTO Customer VALUES( @customerName , @phone , @username )";
            int dataReturnAccount = Connection.Instance.actionQuery(insertAccount, new object[] { username, username });
            int dataReturnCustomer = Connection.Instance.actionQuery(insertCustomer, new object[] { customerName, phone, username });

            if (dataReturnAccount > 0 && dataReturnCustomer > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable selectExistAccount(string username)
        {
            string query = "SELECT * FROM Account WHERE AccountUsername = @username";
            return Connection.Instance.SelectQuery(query, new object[] { username });
        }

        public DataTable getCustomerList()
        {
            string query = "SELECT CustomerName N'Tên khách hàng', CustomerPhone N'Số điện thoại', AccountUsername N'Tên tài khoản' FROM Customer c INNER JOIN Account a ON c.CustomerUsername = a.AccountUsername";
            return Connection.Instance.SelectQuery(query);
        }

        public bool deleteCustomer(string username)
        {
            string query = "DELETE FROM Account WHERE AccountUsername = @username";

            Connection.Instance.actionQuery("alter table BookRoom nocheck constraint all");
            Connection.Instance.actionQuery("alter table Bill nocheck constraint all");

            int dataReturn = Connection.Instance.actionQuery(query, new object[] { username });

            Connection.Instance.actionQuery("alter table BookRoom check constraint all");
            Connection.Instance.actionQuery("alter table Bill check constraint all");

            if (dataReturn > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateCustomer(string customerName, string phone, string username)
        {
            string queryCustomer = "UPDATE Customer SET CustomerName = @customerName , CustomerPhone = @phone WHERE CustomerUsername = @customerUsername";
     
            int dataReturnCustomer = Connection.Instance.actionQuery(queryCustomer, new object[] { customerName, phone, username });
            if (dataReturnCustomer > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setDefaultPassword(string username)
        {
            string queryCustomer = "UPDATE Account SET AccountPassword = @password WHERE AccountUsername = @customerUsername ";

            int dataReturnCustomer = Connection.Instance.actionQuery(queryCustomer, new object[] { username, username });
            if (dataReturnCustomer > 0)
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
