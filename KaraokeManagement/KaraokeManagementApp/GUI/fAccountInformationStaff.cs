using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class fAccountInformationStaff : Form
    {
        private DTO_Staff staff;
        private BUS_AccountInformation processAccountInformation;
        public fAccountInformationStaff()
        {
            InitializeComponent();
            loadData();
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            if(username.Text == "admin")
            {
                MessageBox.Show("Tài khoản này không thể chỉnh sửa họ tên", "Thông báo");
                return;
            }
            btnConfirmEdit.Visible = true;
            name.Enabled = true;
            name.BackColor = SystemColors.Control;
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin")
            {
                MessageBox.Show("Tài khoản này không thể chỉnh sửa số điện thoại", "Thông báo");
                return;
            }
            btnConfirmEdit.Visible = true;
            phone.Enabled = true;
            phone.BackColor = SystemColors.Control;
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            btnConfirmEdit.Visible = true;
            password.Enabled = true;
            password.BackColor = SystemColors.Control;
            panel6.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void loadData()
        {
            processAccountInformation = new BUS_AccountInformation(fLogin.Instance.account);
            staff = processAccountInformation.getStaffInformation();
            staffID.Text = staff.StaffID;
            name.Text = staff.StaffName;
            phone.Text = staff.StaffPhone;
            username.Text = fLogin.Instance.account.AccountUsername;
            password.Text = fLogin.Instance.account.AccountPassword;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            btnHidePassword.Visible = true;
            btnShowPassword.Visible = false;
            password.UseSystemPasswordChar = false;
        }

        private void btnHidePassword_Click_1(object sender, EventArgs e)
        {
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
            password.UseSystemPasswordChar = true;
        }

        public void reset()
        {
            loadData();
            name.Enabled = false;
            name.BackColor = Color.Silver;

            password.Enabled = false;
            password.BackColor = Color.Silver;

            phone.Enabled = false;
            phone.BackColor = Color.Silver;

            panel6.Visible = false;
            confirmPassword.Text = "";
            password.UseSystemPasswordChar = true;
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
            btnConfirmEdit.Visible = false;
        }
        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin")
            {
                if ((password.Text == string.Empty) || (confirmPassword.Text == string.Empty))
                {
                    MessageBox.Show("Mật khẩu hoặc nhập lại mật khẩu không được để trống", "Thông báo");
                    return;
                }
                else if (password.Text != confirmPassword.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác", "Thông báo");
                    return;
                }
                else
                {
                    if (processAccountInformation.updatePasswordAdmin(password.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo");
                        fLogin.Instance.account.AccountPassword = password.Text;
                        reset();
                        return;
                    }
                }
            }
            else
            {
                if (name.Text == "")
                {
                    MessageBox.Show("Họ tên không được để trống", "Thông báo");
                    return;
                }
                else if ((name.Text.Any(Char.IsSymbol)) || (name.Text.Any(Char.IsDigit)))
                {
                    MessageBox.Show("Họ tên chỉ được nhập chữ", "Thông báo");
                    return;
                }
                else if(phone.Text == "")
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
                else if ((password.Enabled == true) && ((password.Text == string.Empty) || (confirmPassword.Text == string.Empty)))
                {
                    MessageBox.Show("Mật khẩu hoặc nhập lại mật khẩu không được để trống", "Thông báo");
                    return;
                }
                else if ((password.Enabled == true) && (password.Text != confirmPassword.Text))
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác", "Thông báo");
                    return;
                }
                else
                {
                    if (processAccountInformation.updateStaffInformation(new DTO_Staff(staff.StaffID, name.Text, phone.Text, staff.StaffUsername, staff.StaffRole), 
                                                                        new DTO_Account(staff.StaffUsername, password.Text, fLogin.Instance.account.AccountRole)))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                        fLogin.Instance.account.AccountPassword = password.Text;
                        reset();
                        return;
                    }
                }
            }
        }
    }
}
