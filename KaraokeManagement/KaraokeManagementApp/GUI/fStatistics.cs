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
    public partial class fStatistics : Form
    {
        BUS_Statistics processStatistics;
        public fStatistics()
        {
            InitializeComponent();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            processStatistics = new BUS_Statistics();
            DataTable tableBillList = processStatistics.getBillListByDate(dateTimePickerTimeStart.Value, dateTimePickerTimeEnd.Value);
            int rows = tableBillList.Rows.Count;
            if (rows <= 0)
            {
                MessageBox.Show("Không có hóa đơn trong khoảng thời gian trên", "Thông báo");
                return;
            }
            btnFirstPage.Enabled = true;
            btnPreviousPage.Enabled = true;
            btnNextPage.Enabled = true;
            btnLastPage.Enabled = true;
            page.Enabled = true;

            if(rows % 15 == 0)
            {
                page.Maximum = rows / 15;
            }
            else
            {
                page.Maximum = (rows / 15) + 1;
            }
            loadBillList();
        }

        private void loadBillList()
        {
            processStatistics = new BUS_Statistics();
            dataGridViewBillList.DataSource = processStatistics.getBillListByDateAndPage(dateTimePickerTimeStart.Value, dateTimePickerTimeEnd.Value, page.Value.ToString());
        }

        private void fStatistics_Load(object sender, EventArgs e)
        {
            dateTimePickerTimeStart.MaxDate = DateTime.Now;
            dateTimePickerTimeEnd.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 0);
            dateTimePickerTimeStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dateTimePickerTimeEnd.MinDate = dateTimePickerTimeStart.Value;
        }

        private void dateTimePickerTimeStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTimeStart.Value = new DateTime(dateTimePickerTimeStart.Value.Year, dateTimePickerTimeStart.Value.Month, dateTimePickerTimeStart.Value.Day, 0, 0, 0);
            dateTimePickerTimeEnd.MinDate = dateTimePickerTimeStart.Value;
            dateTimePickerTimeEnd.Value = new DateTime(dateTimePickerTimeEnd.Value.Year, dateTimePickerTimeEnd.Value.Month, dateTimePickerTimeEnd.Value.Day, 23, 59, 0);
            reset();
        }
        private void dateTimePickerTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTimeEnd.Value = new DateTime(dateTimePickerTimeEnd.Value.Year, dateTimePickerTimeEnd.Value.Month, dateTimePickerTimeEnd.Value.Day, 23, 59, 0);
            reset();
        }

        private void reset()
        {
            btnFirstPage.Enabled = false;
            btnPreviousPage.Enabled = false;
            btnNextPage.Enabled = false;
            btnLastPage.Enabled = false;
            page.Enabled = false;
            dataGridViewBillList.DataSource = "";
        }

        private void page_ValueChanged(object sender, EventArgs e)
        {
            loadBillList();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            page.Value = page.Minimum;
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            page.Value = page.Maximum;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (page.Value > page.Minimum)
            {
                page.Value--;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if(page.Value < page.Maximum)
            {
                page.Value++;
            }
        }
    }
}
