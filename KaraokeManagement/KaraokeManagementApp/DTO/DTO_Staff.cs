using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class DTO_Staff
    {
        private string staffID;
        private string staffName;
        private string staffPhone;
        private string staffUsername;
        private string staffRole;

        public DTO_Staff(string staffID, string staffName, string staffPhone, string staffUsername, string staffRole)
        {
            this.staffID = staffID;
            this.staffName = staffName;
            this.staffPhone = staffPhone;
            this.staffUsername = staffUsername;
            this.staffRole = staffRole;
        }

        public DTO_Staff(DataRow row)
        {
            StaffID = row["StaffID"].ToString();
            StaffPhone = row["StaffPhone"].ToString();
            StaffName = row["StaffName"].ToString();
            StaffUsername = row["StaffUsername"].ToString();
            StaffRole = row["StaffRole"].ToString();
        }

        public string StaffID
        {
            get { return this.staffID; }
            set { this.staffID = value; }
        }

        public string StaffName
        {
            get { return this.staffName; }
            set { this.staffName = value; }
        }

        public string StaffPhone
        {
            get { return this.staffPhone; }
            set { this.staffPhone = value; }
        }

        public string StaffUsername
        {
            get { return this.staffUsername; }
            set { this.staffUsername = value; }
        }

        public string StaffRole
        {
            get { return this.staffRole; }
            set { this.staffRole = value; }
        }
    }
}
