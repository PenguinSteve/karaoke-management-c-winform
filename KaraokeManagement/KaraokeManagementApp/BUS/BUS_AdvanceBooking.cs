using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.SqlServer.Server;

namespace BUS
{
    public class BUS_AdvanceBooking
    {
        DAL_AdvanceBooking processAdvanceBooking;
        public BUS_AdvanceBooking()
        {
            processAdvanceBooking = new DAL_AdvanceBooking();
        }

        public List<DTO_Room> getListAllRooms()
        {
            List<DTO_Room> listRooms = new List<DTO_Room>();

            DataTable dataTableRooms = processAdvanceBooking.getListRooms();

            foreach (DataRow row in dataTableRooms.Rows)
            {
                listRooms.Add(new DTO_Room(row));
            }
            return listRooms;
        }
        
        public string autoGenerateBookID()
        {
            string bookID = processAdvanceBooking.getBookID();
            if(bookID != null )
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

        public bool bookRoom(string bookID, string roomID, DateTime timeStart, string phone, string username) 
        {
            return processAdvanceBooking.insertBooking(bookID, roomID, timeStart, phone, username);
        }

        public bool updateBookRoom(string bookID, DateTime timeStart, string phone)
        {
            return processAdvanceBooking.updateBooking(bookID, timeStart, phone);
        }

        public bool deleteBookRoom(string bookID)
        {
            return processAdvanceBooking.deleteBooking(bookID);
        }

        public DataTable dataBookingDetail(string roomID, DateTime timeCompare)
        {
            return processAdvanceBooking.getDataBookingDetail(roomID, timeCompare);
        }
        
        public DataTable dataBookingHistory(string username, DateTime timeCompare)
        {
            return processAdvanceBooking.getDataBookingHistory(username, timeCompare);
        }

        public DataTable SpecificDataBookingDetail(string roomID, DateTime timeCompare)
        {
            return processAdvanceBooking.getSpecificDataBookingDetail(roomID, timeCompare);
        }
    }
}
