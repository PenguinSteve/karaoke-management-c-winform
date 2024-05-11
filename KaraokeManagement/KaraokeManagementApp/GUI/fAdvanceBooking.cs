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
    public partial class fAdvanceBooking : Form
    {
        BUS_AdvanceBooking processAdvanceBooking;

        int tableWidth = 130;
        int tableHeight = 130;
        Button currentBtn = null;

        public fAdvanceBooking()
        {
            InitializeComponent();
        }

        private void fAdvanceBooking_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            if (now.AddDays(1).Day == 1)
            {
                month = month + 1;
                if (month == 1)
                {
                    year = year + 1;
                }
            }
            dateTimePicker.MinDate = new DateTime(year, month, now.AddDays(1).Day, 0, 0, 0);
            dateTimePicker.MaxDate = dateTimePicker.MinDate.AddMonths(1);
            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            timeStart.MinDate = dateTimePicker.MinDate;
            timeStart.MaxDate = dateTimePicker.MaxDate;

            loadData();
        }

        public void loadData()
        {

            processAdvanceBooking = new BUS_AdvanceBooking();
            List<DTO_Room> allRoomsList = processAdvanceBooking.getListAllRooms();

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
            processAdvanceBooking = new BUS_AdvanceBooking();
            dataGridViewBookingDetail.DataSource = processAdvanceBooking.dataBookingDetail(roomID, timeCompare);
            if(dataGridViewBookingDetail.Rows.Count > 0)
            {
                dataGridViewBookingDetail.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

        }

        private void loadBookingHistory(string username, DateTime timeCompare)
        {
            processAdvanceBooking = new BUS_AdvanceBooking();
            dataGridViewBookingHistory.DataSource = processAdvanceBooking.dataBookingHistory(username, timeCompare);
            if (dataGridViewBookingHistory.Rows.Count > 0)
            {
                dataGridViewBookingHistory.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            tabControlBooking.SelectedIndex = 0;
            loadBookingDetail(((DTO_Room)((Button)sender).Tag).RoomID, dateTimePicker.Value);
            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.Control;
                currentBtn = (Button)sender;
                currentBtn.BackColor = SystemColors.ActiveCaption;
            }
            else if(currentBtn == null)
            {
                currentBtn = (Button)sender;
                currentBtn.BackColor = SystemColors.ActiveCaption;
            }

            panelBooking.Enabled = true;
            processAdvanceBooking = new BUS_AdvanceBooking();
            bookID.Text = processAdvanceBooking.autoGenerateBookID();
            roomID.Text = ((DTO_Room)((Button)sender).Tag).RoomID;
            roomName.Text = ((DTO_Room)((Button)sender).Tag).RoomName;
            roomType.Text = ((DTO_Room)((Button) sender).Tag).RoomType;
            roomPrice.Text = ((DTO_Room)((Button)sender).Tag).RoomPrice.ToString();
            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            phone.Text = "";
            username.Text = fLogin.Instance.account.AccountUsername;
        }

        private void timerSynchrony_Tick(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
            btnPreviousDay.Enabled = true;
            if (dateTimePicker.Value == dateTimePicker.MaxDate)
            {
                btnNextDay.Enabled = false;
            }
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);     
            btnNextDay.Enabled = true;
            if (dateTimePicker.Value == dateTimePicker.MinDate)
            {
                btnPreviousDay.Enabled = false;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker.Value == dateTimePicker.MaxDate)
            {
                btnPreviousDay.Enabled = true;
                btnNextDay.Enabled = false;
            }
            else if(dateTimePicker.Value == dateTimePicker.MinDate)
            {
                btnNextDay.Enabled = true;
                btnPreviousDay.Enabled = false;
            }
            else 
            {
                btnNextDay.Enabled = true;
                btnPreviousDay.Enabled= true;
            }
            reset();
            loadBookingHistory(fLogin.Instance.account.AccountUsername, dateTimePicker.Value);
            loadBookingDetail("", dateTimePicker.Value);
        }

        private void tabControlRoomInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();

            if (tabControlBooking.SelectedIndex == 0)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;

                btnBooking.Visible = true;
                loadBookingDetail("", dateTimePicker.Value);
            }
            else if (tabControlBooking.SelectedIndex == 1)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;

                btnBooking.Visible = false;
                loadBookingHistory(fLogin.Instance.account.AccountUsername, dateTimePicker.Value);
            }
        }

        private void dataGridViewBookingHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewBookingHistory.Rows[e.RowIndex];
                bookID.Text = row.Cells["Mã đặt phòng"].Value.ToString();
                roomID.Text = row.Cells["Mã phòng"].Value.ToString();
                roomName.Text = row.Cells["Tên phòng"].Value.ToString();
                roomType.Text = row.Cells["Loại phòng"].Value.ToString();
                roomPrice.Text = row.Cells["Giá phòng"].Value.ToString();
                timeStart.Value = DateTime.Parse(row.Cells["Thời gian đặt"].Value.ToString());
                phone.Text = row.Cells["Số điện thoại"].Value.ToString();
                username.Text = row.Cells["Tên tài khoản"].Value.ToString();
                loadBookingDetail(roomID.Text, dateTimePicker.Value);

                panelBooking.Enabled = true;
            }
        }

        private void reset()
        {
            bookID.Text = "";
            roomID.Text = "";
            roomName.Text = "";
            roomType.Text = "";
            roomPrice.Text = "";
            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            phone.Text = "";
            username.Text = "";
            if(currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.Control;
                currentBtn = null;
            }
            panelBooking.Enabled = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo");
                return;
            }
            else if (!phone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số", "Thông báo");
                return;
            }
            else if (phone.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại ít nhất 10 chữ số", "Thông báo");
                return;
            }
            else if (!validTimeBooking(timeStart.Value, bookID.Text))
            {
                MessageBox.Show("Giờ đặt phòng quá gần với giờ đã đặt trước đó (Cách nhau tối thiểu 2 giờ)!", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processAdvanceBooking = new BUS_AdvanceBooking();
                    if (processAdvanceBooking.bookRoom(bookID.Text, roomID.Text, timeStart.Value, phone.Text, username.Text))
                    {
                        MessageBox.Show("Đặt phòng thành công", "Thông báo");
                        loadBookingDetail(roomID.Text, dateTimePicker.Value);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Đặt phòng không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo");
                return;
            }
            else if (!phone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số", "Thông báo");
                return;
            }
            else if (phone.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại ít nhất 10 chữ số", "Thông báo");
                return;
            }
            else if (!validTimeBooking(timeStart.Value, bookID.Text))
            {
                MessageBox.Show("Giờ đặt phòng quá gần với giờ đã đặt trước đó (Cách nhau tối thiểu 2 giờ)!", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processAdvanceBooking = new BUS_AdvanceBooking();
                    if (processAdvanceBooking.updateBookRoom(bookID.Text, timeStart.Value, phone.Text))
                    {
                        MessageBox.Show("Sửa đơn đặt phòng thành công", "Thông báo");
                        loadBookingHistory(fLogin.Instance.account.AccountUsername, dateTimePicker.Value);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa đơn đặt phòng không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn hủy đơn đặt phòng?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processAdvanceBooking = new BUS_AdvanceBooking();
                if (processAdvanceBooking.deleteBookRoom(bookID.Text))
                {
                    MessageBox.Show("Hủy đặt phòng thành công", "Thông báo");
                    loadBookingHistory(fLogin.Instance.account.AccountUsername, dateTimePicker.Value);
                    reset();
                }
                else
                {
                    MessageBox.Show("Hủy đặt phòng không thành công", "Thông báo");
                }
            }
            return;
        }

        private bool validTimeBooking(DateTime timeCompare, string bookID)
        {
            if (dataGridViewBookingDetail.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewBookingDetail.Rows)
                {
                    DateTime timeCompare1 = DateTime.Parse(row.Cells["Thời gian đặt"].Value.ToString());
                    if(bookID == row.Cells["Mã đặt phòng"].Value.ToString())
                    {
                        continue;
                    }
                    if (timeCompare1.Hour - timeCompare.Hour == 2)
                    {
                        if (timeCompare1.Minute >= timeCompare.Minute)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (timeCompare.Hour - timeCompare1.Hour == 2)
                    {
                        if (timeCompare.Minute >= timeCompare1.Minute)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (Math.Abs(timeCompare1.Hour - timeCompare.Hour) > 2)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
