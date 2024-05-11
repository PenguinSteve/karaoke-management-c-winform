using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Device
    {
        private string deviceID;
        private string deviceName;
        private double purchasePrice;
        private string deviceStatus;
        private string roomID;

        public DTO_Device(string deviceID, string deviceName, double purchasePrice, string deviceStatus, string roomID)
        {
            this.deviceID = deviceID;
            this.deviceName = deviceName;
            this.purchasePrice = purchasePrice;
            this.deviceStatus = deviceStatus;
            this.roomID = roomID;
        }

        public DTO_Device(DataRow row)
        {
            DeviceID = row["DeviceID"].ToString();
            DeviceName = row["DeviceName"].ToString();
            PurchasePrice = (double)row["PurchasePrice"];
            DeviceStatus = row["DeviceStatus"].ToString();
            RoomID = row["RoomID"].ToString();
        }

        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public double PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }

        public string DeviceStatus
        {
            get { return deviceStatus; }
            set { deviceStatus = value; }
        }

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
    }
}