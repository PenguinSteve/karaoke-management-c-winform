using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Transaction
    {
        DAL_Transaction processTransaction;
        public BUS_Transaction()
        { 
            processTransaction = new DAL_Transaction();
        }

        public DataTable getBillDetail(string billID)
        {
            return processTransaction.getBillDetail(billID);
        }

        public bool confirmTransaction(string billID, string bookID, DateTime billDate, double totalPrice, DateTime timeEnd)
        {
            return processTransaction.updateConfirmTransaction(billID, bookID, billDate, totalPrice, timeEnd);
        }
    }
}
