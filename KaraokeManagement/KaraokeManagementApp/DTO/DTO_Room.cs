using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Room
    {
        private string roomId;
        private string roomName;
        private string roomType;
        private double roomPrice;

        public DTO_Room() { }

        public DTO_Room(string roomId, string roomName, string roomType, double roomPrice)
        {
            this.roomName = roomName;
            this.roomId = roomId;
            this.roomPrice = roomPrice;
            this.roomType = roomType;
        }

        public DTO_Room(DataRow row)
        {
            RoomID = row["RoomID"].ToString();
            RoomName = row["RoomName"].ToString();
            RoomType = row["RoomType"].ToString();
            RoomPrice = (double)row["RoomPrice"];
        }

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public string RoomID
        {
            get { return roomId; }
            set { roomId = value; }
        }

        public double RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }
    }
}
