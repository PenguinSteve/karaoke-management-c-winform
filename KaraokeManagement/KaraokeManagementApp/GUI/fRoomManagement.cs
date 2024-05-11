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
    public partial class fRoomManagement : Form
    {
        BUS_RoomManagement processRoomManagement;

        public fRoomManagement()
        {
            InitializeComponent();
        }


        private void fAdvanceBooking_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            processRoomManagement = new BUS_RoomManagement();
            panelRoomStatus.Visible = false;
            roomID.Text = processRoomManagement.autoGenerateRoomID();
            dataGridViewRoomList.DataSource = processRoomManagement.getRoomList();
        }

        private void reset()
        {
            processRoomManagement = new BUS_RoomManagement();
            roomID.Text = processRoomManagement.autoGenerateRoomID();
            roomName.Text = "";
            roomPrice.Text = "";
            roomType.Text = "";
            panelRoomStatus.Visible = false;

            btnDisableRoom.Visible = false;
            btnEditRoom.Visible = false;
            btnReset2.Visible = false;
            btnEnableRoom.Visible = false;

            btnReset.Visible = true;
            btnCreateRoom.Visible = true;
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            processRoomManagement = new BUS_RoomManagement();
            if (roomName.Text == "")
            {
                MessageBox.Show("Tên phòng không được để trống", "Thông báo");
                return;
            }
            else if ((roomName.Text.Any(Char.IsSymbol)))
            {
                MessageBox.Show("Tên phòng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (roomType.Text == "")
            {
                MessageBox.Show("Loại phòng không được để trống", "Thông báo");
                return;
            }
            else if ( (roomType.Text.Any(Char.IsSymbol)) )
            {
                MessageBox.Show("Loại phòng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (roomPrice.Text == "")
            {
                MessageBox.Show("Giá phòng không được để trống", "Thông báo");
                return;
            }
            else if (!roomPrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Giá phòng chỉ được nhập số", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    if (processRoomManagement.createRoom(roomID.Text, roomName.Text, roomType.Text, roomPrice.Text))
                    {
                        MessageBox.Show("Thêm phòng thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            processRoomManagement = new BUS_RoomManagement();
            if (roomName.Text == "")
            {
                MessageBox.Show("Tên phòng không được để trống", "Thông báo");
                return;
            }
            else if ((roomName.Text.Any(Char.IsSymbol)))
            {
                MessageBox.Show("Tên phòng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (roomType.Text == "")
            {
                MessageBox.Show("Loại phòng không được để trống", "Thông báo");
                return;
            }
            else if ((roomType.Text.Any(Char.IsSymbol)))
            {
                MessageBox.Show("Loại phòng chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (roomPrice.Text == "")
            {
                MessageBox.Show("Giá phòng không được để trống", "Thông báo");
                return;
            }
            else if (!roomPrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Giá phòng chỉ được nhập số", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    if (processRoomManagement.editRoom(roomID.Text, roomName.Text, roomType.Text, roomPrice.Text))
                    {
                        MessageBox.Show("Chỉnh sửa thông tin phòng thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa thông tin phòng không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnEnableRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn kích hoạt phòng?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processRoomManagement = new BUS_RoomManagement();
                if (processRoomManagement.enableRoom(roomID.Text))
                {
                    MessageBox.Show("Kích hoạt phòng phòng thành công", "Thông báo");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Kích hoạt phòng phòng không thành công", "Thông báo");
                }
            }
            return;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn vô hiệu hóa phòng?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processRoomManagement = new BUS_RoomManagement();
                if (processRoomManagement.disableRoom(roomID.Text))
                {
                    MessageBox.Show("Vô hiệu hóa phòng thành công", "Thông báo");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Vô hiệu hóa phòng không thành công", "Thông báo");
                }
            }
            return;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridViewStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoomList.Rows[e.RowIndex];
                roomID.Text = row.Cells["Mã phòng"].Value.ToString();
                roomName.Text = row.Cells["Tên phòng"].Value.ToString();
                roomType.Text = row.Cells["Loại phòng"].Value.ToString();
                roomPrice.Text = row.Cells["Giá phòng"].Value.ToString();
                roomStatus.Text = row.Cells["Trạng thái"].Value.ToString();

                if(roomStatus.Text == "Khả dụng")
                {
                    btnDisableRoom.Visible = true;
                    btnEnableRoom.Visible = false;
                }
                if(roomStatus.Text == "Vô hiệu hóa")
                {
                    btnEnableRoom.Visible = true;
                    btnDisableRoom.Visible = false;
                }

                btnEditRoom.Visible = true;
                btnReset2.Visible = true;

                btnCreateRoom.Visible = false;
                btnReset.Visible = false;
            }
        }
    }
}