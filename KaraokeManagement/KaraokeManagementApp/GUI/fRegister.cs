using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fRegister : Form
    {
        BUS_Register processRegister;

        public fRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.White;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.FromArgb(147, 73, 227);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.ForeColor = Color.White;
            errorUsername.Visible = false;
        }
        private void name_GotFocus(object sender, EventArgs e)
        {
            if (name.Text == "Nhập họ tên")
            {
                name.Text = "";
            }
        }
        private void name_LostFocus(object sender, EventArgs e)
        {
            if (name.Text == String.Empty)
            {
                name.Text = "Nhập họ tên";
                name.ForeColor = Color.Gray;
            }
        }
        private void username_TextChanged(object sender, EventArgs e)
        {
            username.ForeColor = Color.White;
            errorUsername.Visible = false;
        }
        private void username_GotFocus(object sender, EventArgs e)
        {
            if (username.Text == "Nhập tài khoản")
            {
                username.Text = "";
            }
        }
        private void username_LostFocus(object sender, EventArgs e)
        {
            if (username.Text == String.Empty)
            {
                username.Text = "Nhập tài khoản";
                username.ForeColor = Color.Gray;
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            phone.ForeColor = Color.White;
            errorPhone.Visible = false;
        }
        private void phone_GotFocus(object sender, EventArgs e)
        {
            if (phone.Text == "Nhập số điện thoại")
            {
                phone.Text = "";
            }
        }
        private void phone_LostFocus(object sender, EventArgs e)
        {
            if (phone.Text == String.Empty)
            {
                phone.Text = "Nhập số điện thoại";
                phone.ForeColor = Color.Gray;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.ForeColor = Color.White;
            errorPassword.Visible = false;
        }
        private void password_GotFocus(object sender, EventArgs e)
        {
            if (password.Text == "Nhập mật khẩu")
            {
                password.UseSystemPasswordChar = true;
                password.Text = "";
            }
        }
        private void password_LostFocus(object sender, EventArgs e)
        {
            if (password.Text == String.Empty)
            {
                password.Text = "Nhập mật khẩu";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
            }
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            confirmPassword.ForeColor = Color.White;
            errorConfirmPassword.Visible = false;
        }
        private void confirmPassword_GotFocus(object sender, EventArgs e)
        {
            if (confirmPassword.Text == "Nhập lại mật khẩu")
            {
                confirmPassword.UseSystemPasswordChar = true;
                confirmPassword.Text = "";
            }
        }

        private void confirmPassword_LostFocus(object sender, EventArgs e)
        {
            if (confirmPassword.Text == String.Empty)
            {
                confirmPassword.Text = "Nhập lại mật khẩu";
                confirmPassword.ForeColor = Color.Gray;
                confirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool validInput = true;
            if ((name.Text == string.Empty) || (name.Text == "Nhập họ tên"))
            {
                errorUsername.Visible = true;
                validInput = false;
            }
            else if ((name.Text.Any(Char.IsDigit)) || (name.Text.Any(Char.IsSymbol)))
            {
                errorName.Text = "Họ tên chỉ được nhập chữ";
                errorName.Visible = true;
                validInput = false;
            }
            if ((username.Text == string.Empty) || (username.Text == "Nhập tài khoản"))
            {
                errorUsername.Visible = true;
                validInput = false;
            }
            if ((phone.Text == string.Empty) || (phone.Text == "Nhập số điện thoại"))
            {
                errorPhone.Text = "Số điện thoại không được để trống";
                errorPhone.Visible = true;
                validInput = false;
            }
            else if (!phone.Text.All(Char.IsDigit))
            {
                errorPhone.Text = "Số điện thoại chỉ được nhập số";
                errorPhone.Visible= true;
                validInput = false;
            }
            else if (phone.Text.Length != 10)
            {
                errorPhone.Text = "Số điện thoại ít nhất 10 chữ số";
                errorPhone.Visible = true;
                validInput = false;
            }
            if ((password.Text == string.Empty) || (password.Text == "Nhập mật khẩu"))
            {
                errorPassword.Visible = true;
                validInput = false;
            }
            if ((confirmPassword.Text == string.Empty) || (confirmPassword.Text == "Nhập lại mật khẩu"))
            {
                errorConfirmPassword.Visible = true;
                validInput = false;
            }

            if (validInput)
            {
                string customerName = name.Text;
                string phoneNumber = phone.Text;
                string userName = username.Text;
                string passWord = password.Text;

                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (checkExistUsername(userName))
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại");
                        username.Focus();
                    }
                    else
                    {
                        bool result = registerAccount(customerName, phoneNumber, userName, passWord);
                        if (result)
                        {
                            MessageBox.Show("Tài khoản đã được đăng ký thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký tài khoản không thành công");
                        }
                    }
                }
            } 
        }

        private bool checkExistUsername(string username)
        {
            processRegister = new BUS_Register("", "", username, "");
            return processRegister.checkExistUsername();
        }
        private bool registerAccount(string name, string phone, string username, string password)
        {
            processRegister = new BUS_Register(name, phone, username, password);
            return processRegister.registerAccount();
        }
    }
}
