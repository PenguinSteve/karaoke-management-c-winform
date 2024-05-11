using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class fTransaction : Form
    {
        BUS_Transaction processTransaction;
        
        double total = 0;

        public fTransaction(DTO_Room room, DTO_BookRoom bookRoom, DTO_Bill bill)
        {
            InitializeComponent();
            loadBillDetail(bill.BillID);
            loadData(room, bookRoom, bill);
        }

        public void loadData(DTO_Room room, DTO_BookRoom bookRoom, DTO_Bill bill)
        {
            
            dateTimePicker.Value = DateTime.Now;
            time.Text = dateTimePicker.Value.ToString("HH:mm");

            billID.Text = bill.BillID;
            bookID.Text = bill.BookID;
            staffID.Text = bill.StaffID;
            billDate.Value = DateTime.Now;
            customerName.Text = bill.CustomerName;
            phone.Text = bill.CustomerPhone;
            customerUsername.Text = bill.CustomerUsername;
            roomID.Text = bookRoom.RoomID;
            roomName.Text = room.RoomName;
            roomType.Text = room.RoomType;
            roomPrice.Text = room.RoomPrice.ToString();
            timeStart.Value = bookRoom.TimeStart;
            timeEnd.Value = DateTime.Now;

            TimeSpan duration = timeEnd.Value - timeStart.Value;
            total += Double.Parse(roomPrice.Text)*duration.Hours;
            if(duration.Minutes > 20)
            {
                total += Double.Parse(roomPrice.Text);
            }
            
            totalPrice.Text = total.ToString();
        }

        private void loadBillDetail(string billID)
        {
            processTransaction = new BUS_Transaction();
            
            DataTable BillDetail = processTransaction.getBillDetail(billID);
            if(BillDetail.Rows.Count > 0)
            {
                foreach (DataRow row in BillDetail.Rows)
                {
                    ListViewItem listViewItem = new ListViewItem(row["Mã dịch vụ"].ToString());
                    listViewItem.SubItems.Add(row["Tên dịch vụ"].ToString());
                    listViewItem.SubItems.Add(row["Giá"].ToString());
                    listViewItem.SubItems.Add(row["Số lượng"].ToString());
                    listViewItem.SubItems.Add(row["Tổng"].ToString());
                    total += Double.Parse(row["Tổng"].ToString());
                    listViewBillDetail.Items.Add(listViewItem);   
                }
            }
            listViewBillDetail.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                processTransaction = new BUS_Transaction();
                if (processTransaction.confirmTransaction(billID.Text, bookID.Text, billDate.Value, Double.Parse(totalPrice.Text), timeEnd.Value))
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công", "Thông báo");
                }
            }
        }


        private void print(Panel panel)
        {
            pictureBox1.Visible = false;
            btnCancel.Visible = false;
            btnConfirmTransaction.Visible = false;
            PrinterSettings printerSettings = new PrinterSettings();
            getPrintArea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryImg;

        private void getPrintArea(Panel panel)
        {
            memoryImg = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryImg, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            double scale = 0.95;
            int newWidth = (int)(memoryImg.Width * scale);
            int newHeight = (int)(memoryImg.Height * scale);

            e.Graphics.DrawImage(memoryImg, ((pageArea.Width/2) - newWidth/2), ((pageArea.Height / 2) - newHeight / 2), newWidth, newHeight);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            print(this.panelTransaction);
            pictureBox1.Visible = true;
            btnCancel.Visible = true;
            btnConfirmTransaction.Visible = true;
        }
    }
}