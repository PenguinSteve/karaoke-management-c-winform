using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Register
    {
        DTO_Account account;
        DTO_Customer customer;

        public DAL_Register(string name, string phone, string username, string password)
        {
            account = new DTO_Account(username, password, "khách");
            customer = new DTO_Customer(name, phone, username);
        }

        public DataTable selectExistAccount()
        {
            string query = "SELECT * FROM Account WHERE AccountUsername = @username";
            return Connection.Instance.SelectQuery(query, new object[] {account.AccountUsername});
        }

        public string insertRegister()
        {
            string insertAccount = "INSERT INTO Account VALUES( @username , @password , @role )";
            string insertCustomer = "INSERT INTO Customer VALUES( @name , @phone , @username )";

            int dataReturnAccount = Connection.Instance.actionQuery(insertAccount, new object[] {account.AccountUsername, account.AccountPassword, account.AccountRole});
            int dataReturnCustomer = Connection.Instance.actionQuery(insertCustomer, new object[] {customer.CustomerName, customer.CustomerPhone, customer.CustomerUsername });

            if(dataReturnAccount > 0 && dataReturnCustomer > 0)
            {
                return "Insert Successful";
            }
            else if(dataReturnAccount > 0)
            {
                return "Insert Fail At Customer";
            }
            else if (dataReturnCustomer > 0)
            {
                return "Insert Fail At Account";
            }
            return "Insert Fail";
        }
    }
}
