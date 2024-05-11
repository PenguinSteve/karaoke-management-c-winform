using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_StaffManagement
    {
        DAL_StaffManagement processStaffManagement;
        public BUS_StaffManagement()
        { 
            processStaffManagement = new DAL_StaffManagement();
        }

        public string autoGenerateStaffID()
        {
            string staffID = processStaffManagement.getStaffID();
            if (staffID != null)
            {
                int id = int.Parse(staffID.Substring(2));
                id++;
                return "NV" + id;
            }
            else
            {
                return "NV1";
            }
        }

        public bool createStaff(string staffID, string staffName, string phone, string username, string role)
        {
            return processStaffManagement.insertStaff(staffID, staffName, phone, username, role);
        }

        public bool checkExistUsername(string username)
        {
            DataTable existAccounts = processStaffManagement.selectExistAccount(username);
            if (existAccounts.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable getStaffList()
        {
            return processStaffManagement.getStaffList();
        }

        public bool deleteStaff(string username)
        {
            return processStaffManagement.deleteStaff(username);
        }

        public bool editStaff(string staffID, string staffName, string phone, string username, string role)
        {
            return processStaffManagement.updateStaff(staffID, staffName, phone, username, role);
        }

        public bool setDefaultPassword(string username)
        {
            return processStaffManagement.setDefaultPassword(username);
        }
    }
}
