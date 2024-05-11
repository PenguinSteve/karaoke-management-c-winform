using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fLogin : Form
    {
        private static fLogin instance;
        public DTO_Account account;

        public static fLogin Instance
        { 
            get {
                if (instance == null)
                {
                    instance = new fLogin();
                }
                return instance;
            }
            private set { instance = value; }
        }

        public fLogin()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            username.ForeColor = Color.White;
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            password.ForeColor = Color.White;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(147, 73, 227);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void username_GotFocus(object sender, EventArgs e)
        {
            if (username.Text == "Nhập tài khoản")
            {
                username.Text = "";
                errorUsername.Visible = false;
            }
        }

        private void username_LostFocus(object sender, EventArgs e)
        {
            if(username.Text == String.Empty)
            {
                username.Text = "Nhập tài khoản";
                username.ForeColor = Color.Gray;
            }
        }

        private void password_GotFocus(object sender, EventArgs e)
        {   
            if(password.Text == "Nhập mật khẩu")
            {
                password.UseSystemPasswordChar = true;
                password.Text = "";
                errorPassword.Visible = false;
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

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fRegister fRegister = new fRegister();
            this.Hide();
            fRegister.ShowDialog();

            username.Text = "Nhập tài khoản";
            username.ForeColor = Color.Gray;

            password.Text = "Nhập mật khẩu";
            password.ForeColor = Color.Gray;
            password.UseSystemPasswordChar = false;
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string passWord = password.Text;
            fLogin.Instance.account = Login(userName, passWord);

            if (fLogin.Instance.account.AccountRole == "admin")
            {
                fMainMenuAdmin mainMenuAdmin = new fMainMenuAdmin();
                this.Hide();
                mainMenuAdmin.ShowDialog();
            }
            else if(fLogin.Instance.account.AccountRole == "Nhân viên lễ tân")
            {
                fMainMenuReceptionists mainMenuReceptionists = new fMainMenuReceptionists();
                this.Hide();
                mainMenuReceptionists.ShowDialog();
            }
            else if(fLogin.Instance.account.AccountRole == "Nhân viên phục vụ")
            {
                fMainMenuStaff mainMenuStaff = new fMainMenuStaff();
                this.Hide();
                mainMenuStaff.ShowDialog();
            }
            else if(fLogin.Instance.account.AccountRole == "khách")
            {
                fMainMenuCustomer mainMenuCustomer = new fMainMenuCustomer();
                this.Hide();
                mainMenuCustomer.ShowDialog();
            }
            else
            {
                errorUsername.Visible = true;
                errorPassword.Visible = true;
            }

            username.Text = "Nhập tài khoản";
            username.ForeColor = Color.Gray;
            password.Text = "Nhập mật khẩu";
            password.ForeColor = Color.Gray;
            password.UseSystemPasswordChar = false;

            this.Show();
        }

        private DTO_Account Login(string username, string password)
        {
            BUS_Login processLogin = new BUS_Login(username, password);
            return processLogin.validateAccount();
        }
    }
}
