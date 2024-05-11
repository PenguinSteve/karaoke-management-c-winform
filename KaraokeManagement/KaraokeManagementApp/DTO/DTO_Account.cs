using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private string accountUsername;
        private string accountPassword;
        private string accountRole;

        public DTO_Account(string accountUsername, string accountPassword, string accountRole)
        {
            this.accountUsername = accountUsername;
            this.accountPassword = accountPassword;
            this.accountRole = accountRole;
        }

        public DTO_Account(DataRow row)
        {
            AccountUsername = row["AccountUsername"].ToString();
            AccountPassword = row["AccountPassword"].ToString();
            AccountRole = row["AccountRole"].ToString();
        }
        public string AccountUsername
        { 
            get {  return accountUsername; }
            set { accountUsername = value; }
        }

        public string AccountPassword
        {
            get { return accountPassword; }
            set { accountPassword = value; }
        }

        public string AccountRole
        {
            get { return accountRole; }
            set { accountRole = value; }
        }

        
    }
}
