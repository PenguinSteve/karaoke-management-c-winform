using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class fOrderService : Form
    {
        BUS_OrderService processOrderService;

        int tableWidth = 130;
        int tableHeight = 130;
        Button currentBtn = null;

        public fOrderService()
        {
            InitializeComponent();
        }

        private void fAdvanceBooking_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            dateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

            loadData();
        }

        public void loadData()
        {
            processOrderService = new BUS_OrderService();
            List<DTO_Room> allRoomsList = processOrderService.getListAllRooms();

            roomList.Controls.Clear();

            foreach (DTO_Room room in allRoomsList)
            {
                Button btn = new Button()
                {
                    Width = tableWidth,
                    Height = tableHeight,
                    Text = room.RoomName

                };
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = room;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
                btn.FlatAppearance.MouseDownBackColor = Color.Silver;
                btn.Click += Btn_Click;
                roomList.Controls.Add(btn);
            }
        }

        private void loadBookingDetail(string roomID, DateTime timeCompare)
        {
            processOrderService = new BUS_OrderService();
            dataGridViewBookingDetail.DataSource = processOrderService.DataBookingDetail(roomID, timeCompare);
            if (dataGridViewBookingDetail.Rows.Count > 0)
            {
                dataGridViewBookingDetail.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void loadService()
        {
            processOrderService = new BUS_OrderService();
            comboBoxServices.DataSource = processOrderService.getServiceList();
            comboBoxServices.DisplayMember = "serviceName";
        }

        private void loadBillDetail(string billID)
        {
            processOrderService = new BUS_OrderService();

            DataTable BillDetail = processOrderService.getBillDetail(billID);
            listViewBillDetail.Items.Clear();
            if (BillDetail.Rows.Count > 0)
            {
                foreach (DataRow row in BillDetail.Rows)
                {
                    ListViewItem listViewItem = new ListViewItem(row["Mã dịch vụ"].ToString());
                    listViewItem.SubItems.Add(row["Tên dịch vụ"].ToString());
                    listViewItem.SubItems.Add(row["Giá"].ToString());
                    listViewItem.SubItems.Add(row["Số lượng"].ToString());
                    listViewItem.SubItems.Add(row["Tổng"].ToString());
                    listViewBillDetail.Items.Add(listViewItem);
                }
            }
            listViewBillDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            loadBookingDetail(((DTO_Room)((Button)sender).Tag).RoomID, dateTimePicker.Value);
            reset();

            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.Control;
                currentBtn = (Button)sender;
                currentBtn.BackColor = SystemColors.ActiveCaption;
            }
            else if (currentBtn == null)
            {
                currentBtn = (Button)sender;
                currentBtn.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void reset()
        {
            bookID.Text = "";
            roomID.Text = "";
            roomName.Text = "";
            listViewBillDetail.Items.Clear();
            quantity.Value = 1;
            
            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.Control;
                currentBtn = null;
            }
            panelOrderSerivce.Enabled = false;
        }

        

        private void btnOrderService_Click(object sender, EventArgs e)
        {
            processOrderService = new BUS_OrderService();
            string billID = processOrderService.getCurrentBillID(bookID.Text);
            if(comboBoxServices.SelectedItem == null)
            {
                MessageBox.Show("Đặt dịch vụ không thành công", "Thông báo");
                return;
            }
            string serviceID = (comboBoxServices.SelectedItem as DTO_Service).ServiceID;
            int serviceQuantity = (int)quantity.Value;

            if(serviceID == null || serviceID == "")
            {
                return;
            }
            if (processOrderService.insertBillDetail(billID, serviceID, serviceQuantity))
            {
                MessageBox.Show("Đặt dịch vụ thành công", "Thông báo");
                loadBillDetail(billID);
            }
            else
            {
                MessageBox.Show("Đặt dịch vụ không thành công", "Thông báo");
            }
            panelOrderSerivce.Enabled = false;
            
        }

        

        private void dataGridViewBookingDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewBookingDetail.Rows[e.RowIndex];
                string status = row.Cells["Trạng thái"].Value.ToString();

                if (status == "Đang được sử dụng")
                {
                    panelOrderSerivce.Enabled = true;
                    bookID.Text = row.Cells["Mã đặt phòng"].Value.ToString();
                    roomID.Text = row.Cells["Mã phòng"].Value.ToString();
                    roomName.Text = row.Cells["Tên phòng"].Value.ToString();
                    processOrderService = new BUS_OrderService();
                    string billID = processOrderService.getCurrentBillID(bookID.Text);

                    loadService();
                    loadBillDetail(billID);
                }
                else
                {
                    panelOrderSerivce.Enabled = false;
                }
            }
        }

        private void timerSynchrony_Tick(object sender, EventArgs e)
        {
            loadData();
        }

        private void timerRealtime_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            DateTime now = DateTime.Now;
            dateTimePicker.MinDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            dateTimePicker.MaxDate = dateTimePicker.MinDate.AddDays(1);
            dateTimePicker.Value = dateTimePicker.MinDate;
        }
    }
}
