using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_StaffManagement
    {
        public DAL_StaffManagement() { }

        public string getStaffID()
        {
            string query = "SELECT StaffID FROM Staff ORDER BY CAST(SUBSTRING(StaffID, 3, LEN(StaffID)) AS INT) DESC";
            return Connection.Instance.executeScalar(query);
        }

        public bool insertStaff(string staffID, string staffName, string phone, string username, string role)
        {
            string insertAccount = "INSERT INTO Account VALUES( @username , @password , @role )";
            string insertStaff = "INSERT INTO Staff VALUES( @staffID , @staffName , @phone , @username , @role )";
            int dataReturnAccount = Connection.Instance.actionQuery(insertAccount, new object[] { username, username, role });
            int dataReturnStaff = Connection.Instance.actionQuery(insertStaff, new object[] { staffID, staffName, phone, username, role });

            if (dataReturnAccount > 0 && dataReturnStaff > 0)
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

        public DataTable getStaffList()
        {
            string query = "SELECT StaffID N'Mã nhân viên', StaffName N'Tên nhân viên' , StaffPhone N'Số điện thoại', AccountUsername N'Tên tài khoản', AccountRole N'Chức vụ' FROM STAFF s INNER JOIN Account a ON s.StaffUsername = a.AccountUsername";
            return Connection.Instance.SelectQuery(query);
        }

        public bool deleteStaff(string username)
        {
            string query = "DELETE FROM Account WHERE AccountUsername = @username";

            Connection.Instance.actionQuery("alter table Bill nocheck constraint all");

            int dataReturn = Connection.Instance.actionQuery(query, new object[] { username });

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

        public bool updateStaff(string staffID, string staffName, string phone, string username, string role)
        {
            string queryAccount = "UPDATE Account SET AccountRole = @role WHERE AccountUsername = @username";
            string queryStaff = "UPDATE Staff SET StaffName = @staffName , StaffPhone = @phone , StaffRole = @role WHERE StaffID = @staffID";

            int dataReturnAccount = Connection.Instance.actionQuery(queryAccount, new object[] { role, username });
            int dataReturnStaff = Connection.Instance.actionQuery(queryStaff, new object[] { staffName, phone, role, staffID });
            if (dataReturnAccount > 0 && dataReturnStaff > 0)
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
            string queryCustomer = "UPDATE Account SET AccountPassword = @password WHERE AccountUsername = @staffUsername ";

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
