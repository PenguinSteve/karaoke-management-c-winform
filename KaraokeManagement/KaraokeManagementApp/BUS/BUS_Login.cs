using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login processLogin;

        public BUS_Login(string username, string password)
        {
            processLogin = new DAL_Login(username, password);
        }

        public DTO_Account validateAccount()
        {

            DTO_Account account = new DTO_Account("", "", "");
            DataTable accountInfomation = processLogin.getAccount();
            if(accountInfomation.Rows.Count > 0)
            {
                account = new DTO_Account(accountInfomation.Rows[0]);
            }
            return account;
        }
    }
}
