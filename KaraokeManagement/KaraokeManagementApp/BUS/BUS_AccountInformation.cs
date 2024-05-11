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
    public class BUS_AccountInformation
    {
        DAL_AccountInformation processAccountInformation;
        public BUS_AccountInformation(DTO_Account account)
        {
            processAccountInformation = new DAL_AccountInformation(account.AccountUsername);
        }

        public DTO_Staff getStaffInformation()
        {
            DTO_Staff staff = new DTO_Staff("", "", "", "", "");

            DataTable staffInformation = processAccountInformation.getStaffInformation();
            if(staffInformation.Rows.Count > 0)
            {
                staff = new DTO_Staff(staffInformation.Rows[0]);
            }
            return staff;
        }

        public DTO_Customer getCustomerInformation()
        {
            DTO_Customer customer = new DTO_Customer("", "", "");

            DataTable customerInformation = processAccountInformation.getCustomerInformation();
            if(customerInformation.Rows.Count > 0)
            {
                customer = new DTO_Customer(customerInformation.Rows[0]);
            }
            return customer;
        }

        public bool updatePasswordAdmin(string password)
        {
            if(processAccountInformation.updatePasswordAdmin(password) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateStaffInformation(DTO_Staff staff, DTO_Account account)
        {
            if (processAccountInformation.updateStaffInformation(staff, account))
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
            if (processAccountInformation.updateCustomerInformation(customer, account))
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
