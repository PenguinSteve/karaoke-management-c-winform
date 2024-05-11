using DTO;
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
    public partial class fMainMenuCustomer : Form
    {
        public fMainMenuCustomer()
        {
            InitializeComponent();
            accountName.Text = fLogin.Instance.account.AccountUsername;
        }

        Button currentBtn;
        Form activatedForm;
        bool sidebarExpand = true;

        private void activeButton(object sender)
        {
            if (sender != null)
            {
                if (currentBtn != (Button)sender)
                {
                    disableButton();
                    currentBtn = (Button)sender;
                    currentBtn.BackColor = Color.FromArgb(22, 16, 52);
                    titleHeading.Text = currentBtn.Text;
                    btnHome.Visible = true;
                }
            }
        }

        private void disableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
            currentBtn = null;
        }
        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 22;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                panelMenu.Width += 22;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            disableButton();
            titleHeading.Text = "Trang chủ";
            btnHome.Visible = false;
            if (activatedForm != null)
            {
                activatedForm.Close();
                activatedForm = null;
            }
        }

        private void openChildForm(Form childForm, object sender)
        {
            if (activatedForm == null)
            {
                activeButton(sender);
                activatedForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else if(activatedForm.GetType() == childForm.GetType())
            {
                return;
            }
            else
            {
                activatedForm.Close();
                activatedForm = null;
                openChildForm(childForm, sender);
            }
        }

        

        private void btnAdvanceBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new fAdvanceBooking(), sender);
        }

        private void btnAccountInfomation_Click(object sender, EventArgs e)
        {
            openChildForm(new fAccountInformationCustomer(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}