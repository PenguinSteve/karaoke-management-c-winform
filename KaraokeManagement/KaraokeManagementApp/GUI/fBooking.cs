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
    public partial class fBooking : Form
    {
        BUS_Booking processBooking;
        BUS_AccountInformation accountInformation;
        DTO_Staff staff;

        int tableWidth = 130;
        int tableHeight = 130;
        Button currentBtn = null;

        public fBooking()
        {
            InitializeComponent();
        }

        private void fAdvanceBooking_Load(object sender, EventArgs e)
        {
            accountInformation = new BUS_AccountInformation(fLogin.Instance.account);
            staff = accountInformation.getStaffInformation();

            DateTime now = DateTime.Now;
            
            dateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            

            loadData();
        }

        public void loadData()
        {
            processBooking = new BUS_Booking();
            List<DTO_Room> allRoomsList = processBooking.getListAllRooms();

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
            processBooking = new BUS_Booking();
            dataGridViewBookingDetail.DataSource = processBooking.SpecificDataBookingDetail(roomID, timeCompare);
            if (dataGridViewBookingDetail.Rows.Count > 0)
            {
                dataGridViewBookingDetail.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            loadBookingDetail(((DTO_Room)((Button)sender).Tag).RoomID, dateTimePicker.Value);
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

            panelBooking.Enabled = true;
            phone.Enabled = true;
            processBooking = new BUS_Booking();
            bookID.Text = processBooking.autoGenerateBookID();
            roomID.Text = ((DTO_Room)((Button)sender).Tag).RoomID;
            roomName.Text = ((DTO_Room)((Button)sender).Tag).RoomName;
            roomType.Text = ((DTO_Room)((Button)sender).Tag).RoomType;
            roomPrice.Text = ((DTO_Room)((Button)sender).Tag).RoomPrice.ToString();
            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            timerUpdateTimeStart.Enabled = true;
            phone.Text = "";
            customerName.Text = "";

            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnConfirmBooking.Visible = false;
            btnPay.Visible = false;
            btnDeleteUsingRoom.Visible = false;

            btnBooking.Visible = true;
        }

        private void reset()
        {
            timerUpdateTimeStart.Enabled = false;
            bookID.Text = "";
            roomID.Text = "";
            roomName.Text = "";
            roomType.Text = "";
            roomPrice.Text = "";
            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            phone.Text = "";
            customerName.Text = "";
            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.Control;
                currentBtn = null;
            }
            panelBooking.Enabled = false;
            panelCustomerUsername.Visible = false;
            phone.Enabled = true;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookingDetail.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewBookingDetail.Rows)
                {
                    if (row.Cells["Trạng thái"].Value.ToString() == "Đang được sử dụng")
                    {
                        MessageBox.Show("Phòng đang được sử dụng", "Thông báo");
                        return;
                    }
                }
            }
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
            else if (customerName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                return;
            }
            else if ( (customerName.Text.Any(Char.IsSymbol)) || (customerName.Text.Any(Char.IsDigit)) )
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processBooking = new BUS_Booking();

                    string newBillID = processBooking.autoGenerateBillID();

                    if (processBooking.bookRoom(bookID.Text, roomID.Text, timeStart.Value, phone.Text, newBillID, staff.StaffID, customerName.Text))
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

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if(dataGridViewBookingDetail.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewBookingDetail.Rows)
                {
                    if (row.Cells["Trạng thái"].Value.ToString() == "Đang được sử dụng")
                    {
                        MessageBox.Show("Phòng đang được sử dụng", "Thông báo");
                        return;
                    }
                }
            }
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
            else if (customerName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                return;
            }
            else if ((customerName.Text.Any(Char.IsSymbol)) || (customerName.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?" + Environment.NewLine + " Thời gian bắt đầu đặt phòng sẽ được tự động cập nhật lại bằng thời gian hiện tại (" + time.Text +").", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processBooking = new BUS_Booking();

                    string newBillID = processBooking.autoGenerateBillID();
                    DateTime newTimeStart = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                    if (processBooking.confirmBookRoom(bookID.Text, newTimeStart, newBillID, staff.StaffID, customerName.Text, phone.Text, customerUsername.Text))
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
            else if (customerName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                return;
            }
            else if ((customerName.Text.Any(Char.IsSymbol)) || (customerName.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processBooking = new BUS_Booking();
                    if (processBooking.editBookRoom(bookID.Text, phone.Text, customerName.Text))
                    {
                        MessageBox.Show("Sửa đơn đặt phòng thành công", "Thông báo");
                        loadBookingDetail(roomID.Text, dateTimePicker.Value);
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
                processBooking = new BUS_Booking();
                if (processBooking.deleteBookRoom(bookID.Text))
                {
                    MessageBox.Show("Hủy đặt phòng thành công", "Thông báo");
                    loadBookingDetail(roomID.Text, dateTimePicker.Value);
                    reset();
                }
                else
                {
                    MessageBox.Show("Hủy đặt phòng không thành công", "Thông báo");
                }
            }
            return;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            processBooking = new BUS_Booking();
            DTO_Room room = new DTO_Room(roomID.Text, roomName.Text, roomType.Text, Double.Parse(roomPrice.Text));
            DTO_BookRoom bookRoom = new DTO_BookRoom(bookID.Text, roomID.Text, timeStart.Value, null, phone.Text, customerName.Text, "Đang được sử dụng");
            string billID = processBooking.getCurrentBillID(bookID.Text);
            DTO_Bill bill = new DTO_Bill(billID, staff.StaffID, customerName.Text, null, 0, phone.Text, customerUsername.Text, bookID.Text);
            fTransaction transaction = new fTransaction(room, bookRoom, bill);
            transaction.ShowDialog();
            loadBookingDetail(roomID.Text, dateTimePicker.Value);
            reset();
        }

        private void btnDeleteUsingRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn hủy phòng đang được sử dụng?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processBooking = new BUS_Booking();
                if (processBooking.deleteUsingRoom(bookID.Text))
                {
                    MessageBox.Show("Hủy đặt phòng đang sử dụng thành công", "Thông báo");
                    loadBookingDetail(roomID.Text, dateTimePicker.Value);
                    reset();
                }
                else
                {
                    MessageBox.Show("Hủy đặt phòng đang sử dụng không thành công", "Thông báo");
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
                    if (bookID == row.Cells["Mã đặt phòng"].Value.ToString())
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

        private void dataGridViewBookingDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timerUpdateTimeStart.Enabled = false;
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewBookingDetail.Rows[e.RowIndex];
                string status = row.Cells["Trạng thái"].Value.ToString();

                if(status == "Đặt trước")
                {
                    btnConfirmBooking.Visible = true;
                    btnDelete.Visible = true;
                    panelCustomerUsername.Visible = true;

                    btnPay.Visible = false;
                    btnEdit.Visible = false;
                    btnBooking.Visible = false;
                    btnDeleteUsingRoom.Visible = false;
                    phone.Enabled = false;
                }
                else if(status == "Đang được sử dụng")
                {
                    btnEdit.Visible = true;
                    btnPay.Visible = true;
                    btnDeleteUsingRoom.Visible = true;

                    btnBooking.Visible = false;
                    btnConfirmBooking.Visible = false;
                    btnDelete.Visible = false;
                }

                bookID.Text = row.Cells["Mã đặt phòng"].Value.ToString();
                roomID.Text = row.Cells["Mã phòng"].Value.ToString();
                roomName.Text = row.Cells["Tên phòng"].Value.ToString();
                roomType.Text = row.Cells["Loại phòng"].Value.ToString();
                roomPrice.Text = row.Cells["Giá phòng"].Value.ToString();
                timeStart.Value = DateTime.Parse(row.Cells["Thời gian đặt"].Value.ToString());
                phone.Text = row.Cells["Số điện thoại"].Value.ToString();
                customerName.Text = row.Cells["Tên khách hàng"].Value.ToString();
                customerUsername.Text = row.Cells["Tên tài khoản"].Value.ToString();

                TimeSpan duration = DateTime.Now - timeStart.Value;
                if(duration.TotalMinutes > 15)
                {
                    btnDeleteUsingRoom.Visible = false;
                }

                panelBooking.Enabled = true;
                panelCustomerUsername.Visible = true;
                
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

        private void timerUpdateTimeStart_Tick(object sender, EventArgs e)
        {
            timeStart.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
        }

        
    }
}
