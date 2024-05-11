using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_RoomManagement
    {
        DAL_RoomManagement processRoomManagement;
        public BUS_RoomManagement() 
        {
            processRoomManagement = new DAL_RoomManagement();
        }

        public string autoGenerateRoomID()
        {
            string roomID = processRoomManagement.getRoomID();
            if (roomID != null)
            {
                int id = int.Parse(roomID.Substring(1));
                id++;
                return "R" + id;
            }
            else
            {
                return "R1";
            }
        }

        public bool createRoom(string roomID, string roomName, string roomType, string roomPrice)
        {
            return processRoomManagement.insertRoom(roomID, roomName, roomType, roomPrice);
        }

        public DataTable getRoomList()
        {
            return processRoomManagement.getRoomList();
        }

        public bool disableRoom(string roomID)
        {
            return processRoomManagement.updateDisableRoom(roomID);
        }

        public bool enableRoom(string roomID)
        {
            return processRoomManagement.updateEnableRoom(roomID);
        }


        public bool editRoom(string roomID, string roomName, string roomType, string roomPrice)
        {
            return processRoomManagement.updateRoom(roomID, roomName, roomType, roomPrice);
        }
    }
}
