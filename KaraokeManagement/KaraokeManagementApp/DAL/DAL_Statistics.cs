using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Statistics
    {
        public DAL_Statistics() { }

        public DataTable getBillListByDateAndPage(DateTime timeStart, DateTime timeEnd, string page)
        {
            string query = "getBillListByDateAndPage @timeStart , @timeEnd , @page ";
            return Connection.Instance.SelectQuery(query, new object[] { timeStart, timeEnd, page});
        }

        public DataTable getBillListByDate(DateTime timeStart, DateTime timeEnd)
        {
            string query = "getBillListByDate @timeStart , @timeEnd ";
            return Connection.Instance.SelectQuery(query, new object[] { timeStart, timeEnd });
        }
    }
}
