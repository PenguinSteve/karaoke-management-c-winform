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
    public partial class fStaffManagement : Form
    {
        BUS_StaffManagement processStaffManagement;

        public fStaffManagement()
        {
            InitializeComponent();
        }


        private void fStaffManagement_Load(object sender, EventArgs e)
        {
            loadData();
            comboBoxRole.Items.AddRange(new object[] { "admin", "Nhân viên phục vụ", "Nhân viên lễ tân" });
        }

        public void loadData()
        {
            processStaffManagement = new BUS_StaffManagement();
            staffID.Text = processStaffManagement.autoGenerateStaffID();
            dataGridViewStaffList.DataSource = processStaffManagement.getStaffList();
        }

        private void reset()
        {
            processStaffManagement = new BUS_StaffManagement();
            staffID.Text = processStaffManagement.autoGenerateStaffID();
            staffName.Text = "";
            username.Text = "";
            phone.Text = "";
            username.BackColor = SystemColors.Control;

            comboBoxRole.Items.Clear();
            comboBoxRole.Items.AddRange(new object[] { "admin", "Nhân viên phục vụ", "Nhân viên lễ tân" });
            username.Enabled = true;

            btnDeleteStaff.Visible = false;
            btnEditStaff.Visible = false;
            btnReset2.Visible = false;
            btnSetDefaultPassword.Visible = false;

            btnReset.Visible = true;
            btnCreateStaff.Visible = true;
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            processStaffManagement = new BUS_StaffManagement();
            if (staffName.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thông báo");
                return;
            }
            else if ((staffName.Text.Any(Char.IsSymbol)) || (staffName.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Tên nhân viên chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (phone.Text == "")
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
            else if (username.Text == "")
            {
                MessageBox.Show("Tài khoản nhân viên không được để trống", "Thông báo");
                return;
            }
            else if (comboBoxRole.SelectedItem == null || comboBoxRole.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Chức vụ không được để trống", "Thông báo");
                return;
            }
            else if (processStaffManagement.checkExistUsername(username.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    if (processStaffManagement.createStaff(staffID.Text, staffName.Text, phone.Text, username.Text, comboBoxRole.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên không thành công", "Thông báo");
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
            else if (staffName.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thông báo");
                return;
            }
            else if ((staffName.Text.Any(Char.IsSymbol)) || (staffName.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Tên nhân viên chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (username.Text == "")
            {
                MessageBox.Show("Tài khoản nhân viên không được để trống", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processStaffManagement = new BUS_StaffManagement();
                    if (processStaffManagement.editStaff(staffID.Text, staffName.Text, phone.Text, username.Text, comboBoxRole.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhân viên không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processStaffManagement = new BUS_StaffManagement();
                if (processStaffManagement.deleteStaff(username.Text))
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công", "Thông báo");
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
                DataGridViewRow row = dataGridViewStaffList.Rows[e.RowIndex];
                staffID.Text = row.Cells["Mã nhân viên"].Value.ToString();
                staffName.Text = row.Cells["Tên nhân viên"].Value.ToString();
                phone.Text = row.Cells["Số điện thoại"].Value.ToString();
                username.Text = row.Cells["Tên tài khoản"].Value.ToString();
                comboBoxRole.Text = row.Cells["Chức vụ"].Value.ToString();

                username.Enabled = false;
                username.BackColor = Color.Silver;

                btnEditStaff.Visible = true;
                btnDeleteStaff.Visible = true;
                btnReset2.Visible = true;
                btnSetDefaultPassword.Visible = true;

                btnCreateStaff.Visible = false;
                btnReset.Visible = false;
            }
        }

        private void btnSetDefaultPassword_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đặt lại mật khẩu?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processStaffManagement = new BUS_StaffManagement();
                if (processStaffManagement.setDefaultPassword(username.Text))
                {
                    MessageBox.Show("Đặt lại mật khẩu nhân viên thành công", "Thông báo");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Đặt lại mật khẩu nhân viên không thành công", "Thông báo");
                }
            }
            return;
        }
    }
}
