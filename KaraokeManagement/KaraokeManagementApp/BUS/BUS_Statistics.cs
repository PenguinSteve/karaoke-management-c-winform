using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Statistics
    {
        DAL_Statistics processStatistics;

        public BUS_Statistics() 
        {
            processStatistics = new DAL_Statistics();
        }

        public DataTable getBillListByDateAndPage(DateTime timeStart, DateTime timeEnd, string page)
        {
            return processStatistics.getBillListByDateAndPage(timeStart, timeEnd, page);
        }

        public DataTable getBillListByDate(DateTime timeStart,DateTime timeEnd)
        {
            return processStatistics.getBillListByDate(timeStart, timeEnd);
        }
    }
}
