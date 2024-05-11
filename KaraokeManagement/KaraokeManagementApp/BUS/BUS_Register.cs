using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Register
    {
        DAL_Register processRegister;

        public BUS_Register(string name, string phone, string username, string password) 
        {
            processRegister = new DAL_Register(name, phone, username, password);
        }

        public bool checkExistUsername()
        {
            DataTable existAccounts = processRegister.selectExistAccount();
            if(existAccounts.Rows.Count > 0 )
            {
                return true;
            }
            return false;
        }

        public bool registerAccount()
        {
            string returnValue = processRegister.insertRegister();
            if( returnValue == "Insert Successful")
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
