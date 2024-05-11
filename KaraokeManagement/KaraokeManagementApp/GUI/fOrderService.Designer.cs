namespace GUI
{
    partial class fOrderService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerSynchrony = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.groupBoxBookingDetail = new System.Windows.Forms.GroupBox();
            this.dataGridViewBookingDetail = new System.Windows.Forms.DataGridView();
            this.panelOrderSerivce = new System.Windows.Forms.Panel();
            this.groupBoxOrderService = new System.Windows.Forms.GroupBox();
            this.listViewBillDetail = new System.Windows.Forms.ListView();
            this.columnServiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelQuantity = new System.Windows.Forms.Panel();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panelServiceName = new System.Windows.Forms.Panel();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.btnOrderService = new System.Windows.Forms.Button();
            this.panelRoomName = new System.Windows.Forms.Panel();
            this.underlineRoomName = new System.Windows.Forms.Panel();
            this.roomName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.panelRoomID = new System.Windows.Forms.Panel();
            this.underlineRoomID = new System.Windows.Forms.Panel();
            this.roomID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.panelBookID = new System.Windows.Forms.Panel();
            this.underlineBookID = new System.Windows.Forms.Panel();
            this.bookID = new System.Windows.Forms.TextBox();
            this.lblbookID = new System.Windows.Forms.Label();
            this.panelRoom = new System.Windows.Forms.Panel();
            this.panelControlTime = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.Label();
            this.groupBoxRoom = new System.Windows.Forms.GroupBox();
            this.roomList = new System.Windows.Forms.FlowLayoutPanel();
            this.timerRealtime = new System.Windows.Forms.Timer(this.components);
            this.panelControl.SuspendLayout();
            this.panelRoomInformation.SuspendLayout();
            this.groupBoxBookingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetail)).BeginInit();
            this.panelOrderSerivce.SuspendLayout();
            this.groupBoxOrderService.SuspendLayout();
            this.panelQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.panelServiceName.SuspendLayout();
            this.panelRoomName.SuspendLayout();
            this.panelRoomID.SuspendLayout();
            this.panelBookID.SuspendLayout();
            this.panelRoom.SuspendLayout();
            this.panelControlTime.SuspendLayout();
            this.groupBoxRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSynchrony
            // 
            this.timerSynchrony.Enabled = true;
            this.timerSynchrony.Interval = 30000;
            this.timerSynchrony.Tick += new System.EventHandler(this.timerSynchrony_Tick);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelRoomInformation);
            this.panelControl.Controls.Add(this.panelOrderSerivce);
            this.panelControl.Controls.Add(this.panelRoom);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1344, 761);
            this.panelControl.TabIndex = 0;
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRoomInformation.Controls.Add(this.groupBoxBookingDetail);
            this.panelRoomInformation.Location = new System.Drawing.Point(12, 515);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(900, 243);
            this.panelRoomInformation.TabIndex = 2;
            // 
            // groupBoxBookingDetail
            // 
            this.groupBoxBookingDetail.Controls.Add(this.dataGridViewBookingDetail);
            this.groupBoxBookingDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBookingDetail.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBookingDetail.Name = "groupBoxBookingDetail";
            this.groupBoxBookingDetail.Size = new System.Drawing.Size(894, 240);
            this.groupBoxBookingDetail.TabIndex = 0;
            this.groupBoxBookingDetail.TabStop = false;
            this.groupBoxBookingDetail.Text = "Chi tiết đặt phòng";
            // 
            // dataGridViewBookingDetail
            // 
            this.dataGridViewBookingDetail.AllowUserToAddRows = false;
            this.dataGridViewBookingDetail.AllowUserToDeleteRows = false;
            this.dataGridViewBookingDetail.AllowUserToResizeRows = false;
            this.dataGridViewBookingDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBookingDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookingDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingDetail.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewBookingDetail.Name = "dataGridViewBookingDetail";
            this.dataGridViewBookingDetail.ReadOnly = true;
            this.dataGridViewBookingDetail.RowHeadersWidth = 51;
            this.dataGridViewBookingDetail.Size = new System.Drawing.Size(894, 200);
            this.dataGridViewBookingDetail.TabIndex = 0;
            this.dataGridViewBookingDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookingDetail_CellClick);
            // 
            // panelOrderSerivce
            // 
            this.panelOrderSerivce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOrderSerivce.BackColor = System.Drawing.SystemColors.Control;
            this.panelOrderSerivce.Controls.Add(this.groupBoxOrderService);
            this.panelOrderSerivce.Enabled = false;
            this.panelOrderSerivce.Location = new System.Drawing.Point(918, 12);
            this.panelOrderSerivce.Name = "panelOrderSerivce";
            this.panelOrderSerivce.Size = new System.Drawing.Size(414, 746);
            this.panelOrderSerivce.TabIndex = 1;
            // 
            // groupBoxOrderService
            // 
            this.groupBoxOrderService.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOrderService.Controls.Add(this.listViewBillDetail);
            this.groupBoxOrderService.Controls.Add(this.panelQuantity);
            this.groupBoxOrderService.Controls.Add(this.panelServiceName);
            this.groupBoxOrderService.Controls.Add(this.btnOrderService);
            this.groupBoxOrderService.Controls.Add(this.panelRoomName);
            this.groupBoxOrderService.Controls.Add(this.panelRoomID);
            this.groupBoxOrderService.Controls.Add(this.panelBookID);
            this.groupBoxOrderService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderService.Location = new System.Drawing.Point(3, 8);
            this.groupBoxOrderService.Name = "groupBoxOrderService";
            this.groupBoxOrderService.Size = new System.Drawing.Size(408, 735);
            this.groupBoxOrderService.TabIndex = 0;
            this.groupBoxOrderService.TabStop = false;
            this.groupBoxOrderService.Text = "Thông tin đặt phòng";
            // 
            // listViewBillDetail
            // 
            this.listViewBillDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServiceID,
            this.columnServiceName,
            this.columnPrice,
            this.columnQuantity,
            this.columnTotalAmount});
            this.listViewBillDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBillDetail.HideSelection = false;
            this.listViewBillDetail.Location = new System.Drawing.Point(3, 305);
            this.listViewBillDetail.Name = "listViewBillDetail";
            this.listViewBillDetail.Size = new System.Drawing.Size(402, 354);
            this.listViewBillDetail.TabIndex = 18;
            this.listViewBillDetail.UseCompatibleStateImageBehavior = false;
            this.listViewBillDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnServiceID
            // 
            this.columnServiceID.Text = "Mã dịch vụ";
            // 
            // columnServiceName
            // 
            this.columnServiceName.Text = "Tên dịch vụ";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Đơn giá";
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Số lượng";
            // 
            // columnTotalAmount
            // 
            this.columnTotalAmount.Text = "Thành tiền";
            // 
            // panelQuantity
            // 
            this.panelQuantity.Controls.Add(this.quantity);
            this.panelQuantity.Controls.Add(this.lblQuantity);
            this.panelQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuantity.Location = new System.Drawing.Point(3, 246);
            this.panelQuantity.Name = "panelQuantity";
            this.panelQuantity.Size = new System.Drawing.Size(402, 53);
            this.panelQuantity.TabIndex = 17;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(248, 9);
            this.quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(150, 38);
            this.quantity.TabIndex = 1;
            this.quantity.TabStop = false;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 11);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(120, 31);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // panelServiceName
            // 
            this.panelServiceName.Controls.Add(this.comboBoxServices);
            this.panelServiceName.Controls.Add(this.lblService);
            this.panelServiceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServiceName.Location = new System.Drawing.Point(3, 193);
            this.panelServiceName.Name = "panelServiceName";
            this.panelServiceName.Size = new System.Drawing.Size(402, 53);
            this.panelServiceName.TabIndex = 16;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(248, 8);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(150, 39);
            this.comboBoxServices.TabIndex = 1;
            this.comboBoxServices.TabStop = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(3, 11);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(105, 31);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Dịch vụ";
            // 
            // btnOrderService
            // 
            this.btnOrderService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOrderService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOrderService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderService.Location = new System.Drawing.Point(3, 665);
            this.btnOrderService.Name = "btnOrderService";
            this.btnOrderService.Size = new System.Drawing.Size(402, 70);
            this.btnOrderService.TabIndex = 15;
            this.btnOrderService.TabStop = false;
            this.btnOrderService.Text = "Đặt dịch vụ";
            this.btnOrderService.UseVisualStyleBackColor = true;
            this.btnOrderService.Click += new System.EventHandler(this.btnOrderService_Click);
            // 
            // panelRoomName
            // 
            this.panelRoomName.Controls.Add(this.underlineRoomName);
            this.panelRoomName.Controls.Add(this.roomName);
            this.panelRoomName.Controls.Add(this.lblRoomName);
            this.panelRoomName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomName.Location = new System.Drawing.Point(3, 140);
            this.panelRoomName.Name = "panelRoomName";
            this.panelRoomName.Size = new System.Drawing.Size(402, 53);
            this.panelRoomName.TabIndex = 3;
            // 
            // underlineRoomName
            // 
            this.underlineRoomName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineRoomName.Location = new System.Drawing.Point(248, 41);
            this.underlineRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.underlineRoomName.Name = "underlineRoomName";
            this.underlineRoomName.Size = new System.Drawing.Size(150, 1);
            this.underlineRoomName.TabIndex = 3;
            // 
            // roomName
            // 
            this.roomName.BackColor = System.Drawing.Color.Silver;
            this.roomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomName.Enabled = false;
            this.roomName.Location = new System.Drawing.Point(248, 8);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(151, 31);
            this.roomName.TabIndex = 1;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(3, 11);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(143, 31);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "Tên phòng";
            // 
            // panelRoomID
            // 
            this.panelRoomID.Controls.Add(this.underlineRoomID);
            this.panelRoomID.Controls.Add(this.roomID);
            this.panelRoomID.Controls.Add(this.lblRoomID);
            this.panelRoomID.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomID.Location = new System.Drawing.Point(3, 87);
            this.panelRoomID.Name = "panelRoomID";
            this.panelRoomID.Size = new System.Drawing.Size(402, 53);
            this.panelRoomID.TabIndex = 2;
            // 
            // underlineRoomID
            // 
            this.underlineRoomID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineRoomID.Location = new System.Drawing.Point(248, 41);
            this.underlineRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.underlineRoomID.Name = "underlineRoomID";
            this.underlineRoomID.Size = new System.Drawing.Size(150, 1);
            this.underlineRoomID.TabIndex = 3;
            // 
            // roomID
            // 
            this.roomID.BackColor = System.Drawing.Color.Silver;
            this.roomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomID.Enabled = false;
            this.roomID.Location = new System.Drawing.Point(248, 8);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(151, 31);
            this.roomID.TabIndex = 1;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(3, 11);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(133, 31);
            this.lblRoomID.TabIndex = 0;
            this.lblRoomID.Text = "Mã phòng";
            // 
            // panelBookID
            // 
            this.panelBookID.Controls.Add(this.underlineBookID);
            this.panelBookID.Controls.Add(this.bookID);
            this.panelBookID.Controls.Add(this.lblbookID);
            this.panelBookID.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookID.Location = new System.Drawing.Point(3, 34);
            this.panelBookID.Name = "panelBookID";
            this.panelBookID.Size = new System.Drawing.Size(402, 53);
            this.panelBookID.TabIndex = 1;
            // 
            // underlineBookID
            // 
            this.underlineBookID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineBookID.Location = new System.Drawing.Point(248, 41);
            this.underlineBookID.Margin = new System.Windows.Forms.Padding(2);
            this.underlineBookID.Name = "underlineBookID";
            this.underlineBookID.Size = new System.Drawing.Size(150, 1);
            this.underlineBookID.TabIndex = 3;
            // 
            // bookID
            // 
            this.bookID.BackColor = System.Drawing.Color.Silver;
            this.bookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookID.Enabled = false;
            this.bookID.Location = new System.Drawing.Point(248, 8);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(151, 31);
            this.bookID.TabIndex = 1;
            // 
            // lblbookID
            // 
            this.lblbookID.AutoSize = true;
            this.lblbookID.Location = new System.Drawing.Point(3, 11);
            this.lblbookID.Name = "lblbookID";
            this.lblbookID.Size = new System.Drawing.Size(178, 31);
            this.lblbookID.TabIndex = 0;
            this.lblbookID.Text = "Mã đặt phòng";
            // 
            // panelRoom
            // 
            this.panelRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRoom.Controls.Add(this.panelControlTime);
            this.panelRoom.Controls.Add(this.groupBoxRoom);
            this.panelRoom.Location = new System.Drawing.Point(12, 12);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(900, 500);
            this.panelRoom.TabIndex = 0;
            // 
            // panelControlTime
            // 
            this.panelControlTime.Controls.Add(this.dateTimePicker);
            this.panelControlTime.Controls.Add(this.time);
            this.panelControlTime.Location = new System.Drawing.Point(3, 3);
            this.panelControlTime.Name = "panelControlTime";
            this.panelControlTime.Size = new System.Drawing.Size(894, 56);
            this.panelControlTime.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(259, 8);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(159, 38);
            this.dateTimePicker.TabIndex = 2;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(424, 12);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(74, 31);
            this.time.TabIndex = 1;
            this.time.Text = "Time";
            // 
            // groupBoxRoom
            // 
            this.groupBoxRoom.Controls.Add(this.roomList);
            this.groupBoxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoom.Location = new System.Drawing.Point(6, 65);
            this.groupBoxRoom.Name = "groupBoxRoom";
            this.groupBoxRoom.Size = new System.Drawing.Size(888, 432);
            this.groupBoxRoom.TabIndex = 0;
            this.groupBoxRoom.TabStop = false;
            this.groupBoxRoom.Text = "Danh sách phòng";
            // 
            // roomList
            // 
            this.roomList.AutoScroll = true;
            this.roomList.Location = new System.Drawing.Point(6, 37);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(876, 389);
            this.roomList.TabIndex = 0;
            // 
            // timerRealtime
            // 
            this.timerRealtime.Enabled = true;
            this.timerRealtime.Interval = 1000;
            this.timerRealtime.Tick += new System.EventHandler(this.timerRealtime_Tick);
            // 
            // fOrderService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelControl);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fOrderService";
            this.Text = "fOrderService";
            this.Load += new System.EventHandler(this.fAdvanceBooking_Load);
            this.panelControl.ResumeLayout(false);
            this.panelRoomInformation.ResumeLayout(false);
            this.groupBoxBookingDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetail)).EndInit();
            this.panelOrderSerivce.ResumeLayout(false);
            this.groupBoxOrderService.ResumeLayout(false);
            this.panelQuantity.ResumeLayout(false);
            this.panelQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.panelServiceName.ResumeLayout(false);
            this.panelServiceName.PerformLayout();
            this.panelRoomName.ResumeLayout(false);
            this.panelRoomName.PerformLayout();
            this.panelRoomID.ResumeLayout(false);
            this.panelRoomID.PerformLayout();
            this.panelBookID.ResumeLayout(false);
            this.panelBookID.PerformLayout();
            this.panelRoom.ResumeLayout(false);
            this.panelControlTime.ResumeLayout(false);
            this.panelControlTime.PerformLayout();
            this.groupBoxRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSynchrony;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.Panel panelOrderSerivce;
        private System.Windows.Forms.Panel panelControlTime;
        private System.Windows.Forms.GroupBox groupBoxRoom;
        private System.Windows.Forms.GroupBox groupBoxOrderService;
        private System.Windows.Forms.DataGridView dataGridViewBookingDetail;
        private System.Windows.Forms.Label lblbookID;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Panel panelBookID;
        private System.Windows.Forms.Panel underlineBookID;
        private System.Windows.Forms.Panel panelRoomID;
        private System.Windows.Forms.Panel underlineRoomID;
        private System.Windows.Forms.TextBox roomID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.FlowLayoutPanel roomList;
        private System.Windows.Forms.Panel panelRoomName;
        private System.Windows.Forms.Panel underlineRoomName;
        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.GroupBox groupBoxBookingDetail;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timerRealtime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnOrderService;
        private System.Windows.Forms.Panel panelServiceName;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Panel panelQuantity;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListView listViewBillDetail;
        private System.Windows.Forms.ColumnHeader columnServiceID;
        private System.Windows.Forms.ColumnHeader columnServiceName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnTotalAmount;
    }
}