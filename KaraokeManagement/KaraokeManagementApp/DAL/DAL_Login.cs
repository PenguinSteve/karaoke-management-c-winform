using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Login
    {
        DTO_Account account;

        public DAL_Login(string username, string password)
        {
            account = new DTO_Account(username, password, "");
        }

        public DataTable getAccount()
        {
            string query = "checkLogin @username , @password";
            return Connection.Instance.SelectQuery(query, new object[] {account.AccountUsername, account.AccountPassword});
        }
    }
}
