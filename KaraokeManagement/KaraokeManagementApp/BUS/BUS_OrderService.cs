using DAL;
using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_OrderService
    {
        DAL_OrderService processOrderSerivce;

        public BUS_OrderService()
        {
            processOrderSerivce = new DAL_OrderService();
        }

        public List<DTO_Room> getListAllRooms()
        {
            List<DTO_Room> listRooms = new List<DTO_Room>();

            DataTable dataTableRooms = processOrderSerivce.getListRooms();

            foreach (DataRow row in dataTableRooms.Rows)
            {
                listRooms.Add(new DTO_Room(row));
            }
            return listRooms;
        }

        public List<DTO_Service> getServiceList()
        {
            List<DTO_Service> serviceList = new List<DTO_Service>();

            DataTable dataServiceList = processOrderSerivce.getServices();

            foreach (DataRow row in dataServiceList.Rows)
            {
                serviceList.Add(new DTO_Service(row));
            }
            return serviceList;
        }

        public DataTable DataBookingDetail(string roomID, DateTime timeCompare)
        {
            return processOrderSerivce.getDataBookingDetail(roomID, timeCompare);
        }

        public string getCurrentBillID(string bookID)
        {
            string currentBillID = processOrderSerivce.getCurrentBillID(bookID);
            if (currentBillID != null)
            {
                return currentBillID;
            }
            return "";
        }

        public DataTable getBillDetail(string billID)
        {
            return processOrderSerivce.getBillDetail(billID);
        }

        public bool insertBillDetail(string billID, string serviceID, int quantity)
        {
            return processOrderSerivce.insertBillDetail(billID, serviceID, quantity);
        }
    }
}
