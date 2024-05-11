using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Booking
    {
        DAL_Booking processBooking;
        public BUS_Booking()
        {
            processBooking = new DAL_Booking();
        }

        public List<DTO_Room> getListAllRooms()
        {
            List<DTO_Room> listRooms = new List<DTO_Room>();

            DataTable dataTableRooms = processBooking.getListRooms();

            foreach (DataRow row in dataTableRooms.Rows)
            {
                listRooms.Add(new DTO_Room(row));
            }
            return listRooms;
        }

        public string autoGenerateBookID()
        {
            string bookID = processBooking.getBookID();
            if (bookID != null)
            {
                int id = int.Parse(bookID.Substring(2));
                id++;
                return "BK" + id;
            }
            else
            {
                return "BK1";
            }
        }

        public string autoGenerateBillID()
        {
            string billID = processBooking.getBillID();
            if (billID != null)
            {
                int id = int.Parse(billID.Substring(1));
                id++;
                return "B" + id;
            }
            else
            {
                return "B1";
            }
        }

        public DataTable SpecificDataBookingDetail(string roomID, DateTime timeCompare)
        {
            return processBooking.getSpecificDataBookingDetail(roomID, timeCompare);
        }

        public bool bookRoom(string bookID, string roomID, DateTime timeStart, string phone, string billID, string staffID, string customerName)
        {
            return processBooking.insertBooking(bookID, roomID, timeStart, phone, billID, staffID, customerName);
        }

        public bool editBookRoom(string bookID, string phone, string customerName)
        {
            return processBooking.updateBooking(bookID, phone, customerName);
        }

        public bool deleteBookRoom(string bookID)
        {
            return processBooking.deleteBooking(bookID);
        }

        public bool deleteUsingRoom(string bookID)
        {
            return processBooking.deleteUsingRoom(bookID);
        }

        public bool confirmBookRoom(string bookID, DateTime timeStart, string billID, string staffID, string customerName, string phone, string customerUsername)
        {
            return processBooking.updateConfirmBookRoom(bookID, timeStart, billID, staffID, customerName, phone, customerUsername);
        }

        public string getCurrentBillID(string bookID)
        {
            string currentBillID = processBooking.getCurrentBillID(bookID);
            if(currentBillID != null)
            {
                return currentBillID;
            }
            return "";
        }
    }
}
