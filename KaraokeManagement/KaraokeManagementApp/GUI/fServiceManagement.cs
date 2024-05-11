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
    public partial class fServiceManagement : Form
    {
        BUS_ServiceManagement processServiceManagement;

        public fServiceManagement()
        {
            InitializeComponent();
        }


        private void fAdvanceBooking_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            processServiceManagement = new BUS_ServiceManagement();
            serviceID.Text = processServiceManagement.autoGenerateServiceID();
            dataGridViewServiceList.DataSource = processServiceManagement.getServiceList();
        }

        private void reset()
        {
            processServiceManagement = new BUS_ServiceManagement();
            serviceID.Text = processServiceManagement.autoGenerateServiceID();
            serviceName.Text = "";
            serviceQuantity.Text = "";
            servicePrice.Text = "";

            btnDeleteService.Visible = false;
            btnEditRoom.Visible = false;
            btnReset2.Visible = false;

            btnReset.Visible = true;
            btnCreateService.Visible = true;
        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            processServiceManagement = new BUS_ServiceManagement();
            if (serviceName.Text == "")
            {
                MessageBox.Show("Tên dịch vụ không được để trống", "Thông báo");
                return;
            }
            else if ((serviceName.Text.Any(Char.IsSymbol)))
            {
                MessageBox.Show("Tên dịch vụ chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (servicePrice.Text == "")
            {
                MessageBox.Show("Giá dịch vụ không được để trống", "Thông báo");
                return;
            }
            else if (!servicePrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Giá dịch vụ chỉ được nhập số", "Thông báo");
                return;
            }
            else if (serviceQuantity.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Thông báo");
                return;
            }
            else if (!serviceQuantity.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số lượng chỉ được nhập số", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    if (processServiceManagement.createService(serviceID.Text, serviceName.Text, servicePrice.Text, serviceQuantity.Text))
                    {
                        MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            processServiceManagement = new BUS_ServiceManagement();
            if (serviceName.Text == "")
            {
                MessageBox.Show("Tên dịch vụ không được để trống", "Thông báo");
                return;
            }
            else if ((serviceName.Text.Any(Char.IsSymbol)))
            {
                MessageBox.Show("Tên dịch vụ chỉ được nhập chữ", "Thông báo");
                return;
            }
            else if (servicePrice.Text == "")
            {
                MessageBox.Show("Giá dịch vụ không được để trống", "Thông báo");
                return;
            }
            else if (!servicePrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Giá dịch vụ chỉ được nhập số", "Thông báo");
                return;
            }
            else if (serviceQuantity.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Thông báo");
                return;
            }
            else if (!serviceQuantity.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số lượng chỉ được nhập số", "Thông báo");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn với thông tin đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    if (processServiceManagement.editService(serviceID.Text, serviceName.Text, servicePrice.Text, serviceQuantity.Text))
                    {
                        MessageBox.Show("Chỉnh sửa thông tin dịch vụ thành công", "Thông báo");
                        loadData();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa thông tin dịch vụ không thành công", "Thông báo");
                    }
                }
                return;
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dịch vụ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processServiceManagement = new BUS_ServiceManagement();
                if (processServiceManagement.deleteService(serviceID.Text))
                {
                    MessageBox.Show("Xóa dịch vụ thành công", "Thông báo");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ không thành công", "Thông báo");
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
                DataGridViewRow row = dataGridViewServiceList.Rows[e.RowIndex];
                serviceID.Text = row.Cells["Mã dịch vụ"].Value.ToString();
                serviceName.Text = row.Cells["Tên dịch vụ"].Value.ToString();
                servicePrice.Text = row.Cells["Giá dịch vụ"].Value.ToString();
                serviceQuantity.Text = row.Cells["Số lượng"].Value.ToString();

                btnEditRoom.Visible = true;
                btnReset2.Visible = true;
                btnDeleteService.Visible = true;

                btnCreateService.Visible = false;
                btnReset.Visible = false;
            }
        }
    }
}