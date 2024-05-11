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
    public partial class fCustomerManagement : Form
    {
        BUS_CustomerManagement processCustomerManagement;

        public fCustomerManagement()
        {
            InitializeComponent();
        }


        private void fStaffManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            processCustomerManagement = new BUS_CustomerManagement();
            dataGridViewCustomerList.DataSource = processCustomerManagement.getCustomerList();
        }

        private void reset()
        {
            processCustomerManagement = new BUS_CustomerManagement();
            customerName.Text = "";
            username.Text = "";
            phone.Text = "";
            username.BackColor = SystemColors.Control;
            username.Enabled = true;

            btnDeleteCustomer.Visible = false;
            btnEditCustomer.Visible = false;
            btnReset2.Visible = false;
            btnSetDefaultPassword.Visible = false;

            btnReset.Visible = true;
            btnCreateCustomer.Visible = true;
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            processCustomerManagement = new BUS_CustomerManagement();
            if (customerName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                return;
            }
            else if ((customerName.Text.Any(Char.IsSymbol)) || (customerName.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ", "Thông báo");
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
                MessageBox.Show("Tài khoản khách hàng không được để trống", "Thông báo");
                return;
            }
            else if (processCustomerManagement.checkExistUsername(username.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    if (processCustomerManagement.createCustomer(customerName.Text, phone.Text, username.Text))
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            processCustomerManagement = new BUS_CustomerManagement();
            if (customerName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                return;
            }
            else if ((customerName.Text.Any(Char.IsSymbol)) || (customerName.Text.Any(Char.IsDigit)))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ", "Thông báo");
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
                MessageBox.Show("Tài khoản khách hàng không được để trống", "Thông báo");
                return;
            }
            else if (processCustomerManagement.checkExistUsername(username.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    processCustomerManagement = new BUS_CustomerManagement();
                    if (processCustomerManagement.editCustomer(customerName.Text, phone.Text, username.Text))
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin khách hàng không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processCustomerManagement = new BUS_CustomerManagement();
                if (processCustomerManagement.deleteCustomer(username.Text))
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
                DataGridViewRow row = dataGridViewCustomerList.Rows[e.RowIndex];
                customerName.Text = row.Cells["Tên khách hàng"].Value.ToString();
                phone.Text = row.Cells["Số điện thoại"].Value.ToString();
                username.Text = row.Cells["Tên tài khoản"].Value.ToString();

                username.Enabled = false;
                username.BackColor = Color.Silver;

                btnEditCustomer.Visible = true;
                btnDeleteCustomer.Visible = true;
                btnReset2.Visible = true;
                btnSetDefaultPassword.Visible = true;

                btnCreateCustomer.Visible = false;
                btnReset.Visible = false;
            }
        }

        private void btnSetDefaultPassword_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đặt lại mật khẩu?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processCustomerManagement = new BUS_CustomerManagement();
                if (processCustomerManagement.setDefaultPassword(username.Text))
                {
                    MessageBox.Show("Đặt lại mật khẩu khách hàng thành công", "Thông báo");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Đặt lại mật khẩu khách hàng không thành công", "Thông báo");
                }
            }
            return;
        }
    }
}
