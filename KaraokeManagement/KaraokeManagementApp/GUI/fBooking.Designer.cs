namespace GUI
{
    partial class fBooking
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
            this.panelBooking = new System.Windows.Forms.Panel();
            this.groupBoxBooking = new System.Windows.Forms.GroupBox();
            this.btnDeleteUsingRoom = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.panelCustomerUsername = new System.Windows.Forms.Panel();
            this.underlineCustomerUsername = new System.Windows.Forms.Panel();
            this.customerUsername = new System.Windows.Forms.TextBox();
            this.lblCustomerUsername = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.panelCustomerName = new System.Windows.Forms.Panel();
            this.underlineCustomerName = new System.Windows.Forms.Panel();
            this.customerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.underlinePhone = new System.Windows.Forms.Panel();
            this.phone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelTimeStart = new System.Windows.Forms.Panel();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.panelRoomPrice = new System.Windows.Forms.Panel();
            this.underlineRoomPrice = new System.Windows.Forms.Panel();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.panelRoomType = new System.Windows.Forms.Panel();
            this.underlineRoomType = new System.Windows.Forms.Panel();
            this.roomType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
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
            this.timerUpdateTimeStart = new System.Windows.Forms.Timer(this.components);
            this.panelControl.SuspendLayout();
            this.panelRoomInformation.SuspendLayout();
            this.groupBoxBookingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetail)).BeginInit();
            this.panelBooking.SuspendLayout();
            this.groupBoxBooking.SuspendLayout();
            this.panelCustomerUsername.SuspendLayout();
            this.panelCustomerName.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.panelTimeStart.SuspendLayout();
            this.panelRoomPrice.SuspendLayout();
            this.panelRoomType.SuspendLayout();
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
            this.panelControl.Controls.Add(this.panelBooking);
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
            // panelBooking
            // 
            this.panelBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBooking.BackColor = System.Drawing.SystemColors.Control;
            this.panelBooking.Controls.Add(this.groupBoxBooking);
            this.panelBooking.Enabled = false;
            this.panelBooking.Location = new System.Drawing.Point(918, 12);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(414, 746);
            this.panelBooking.TabIndex = 1;
            // 
            // groupBoxBooking
            // 
            this.groupBoxBooking.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBooking.Controls.Add(this.btnDeleteUsingRoom);
            this.groupBoxBooking.Controls.Add(this.btnPay);
            this.groupBoxBooking.Controls.Add(this.btnConfirmBooking);
            this.groupBoxBooking.Controls.Add(this.panelCustomerUsername);
            this.groupBoxBooking.Controls.Add(this.btnDelete);
            this.groupBoxBooking.Controls.Add(this.btnEdit);
            this.groupBoxBooking.Controls.Add(this.btnBooking);
            this.groupBoxBooking.Controls.Add(this.panelCustomerName);
            this.groupBoxBooking.Controls.Add(this.panelPhone);
            this.groupBoxBooking.Controls.Add(this.panelTimeStart);
            this.groupBoxBooking.Controls.Add(this.panelRoomPrice);
            this.groupBoxBooking.Controls.Add(this.panelRoomType);
            this.groupBoxBooking.Controls.Add(this.panelRoomName);
            this.groupBoxBooking.Controls.Add(this.panelRoomID);
            this.groupBoxBooking.Controls.Add(this.panelBookID);
            this.groupBoxBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBooking.Location = new System.Drawing.Point(3, 8);
            this.groupBoxBooking.Name = "groupBoxBooking";
            this.groupBoxBooking.Size = new System.Drawing.Size(408, 735);
            this.groupBoxBooking.TabIndex = 0;
            this.groupBoxBooking.TabStop = false;
            this.groupBoxBooking.Text = "Thông tin đặt phòng";
            // 
            // btnDeleteUsingRoom
            // 
            this.btnDeleteUsingRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteUsingRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteUsingRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsingRoom.Location = new System.Drawing.Point(3, 513);
            this.btnDeleteUsingRoom.Name = "btnDeleteUsingRoom";
            this.btnDeleteUsingRoom.Size = new System.Drawing.Size(402, 70);
            this.btnDeleteUsingRoom.TabIndex = 16;
            this.btnDeleteUsingRoom.TabStop = false;
            this.btnDeleteUsingRoom.Text = "Hủy đặt phòng";
            this.btnDeleteUsingRoom.UseVisualStyleBackColor = true;
            this.btnDeleteUsingRoom.Visible = false;
            this.btnDeleteUsingRoom.Click += new System.EventHandler(this.btnDeleteUsingRoom_Click);
            // 
            // btnPay
            // 
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(3, 665);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(402, 70);
            this.btnPay.TabIndex = 15;
            this.btnPay.TabStop = false;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConfirmBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Location = new System.Drawing.Point(3, 589);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(402, 70);
            this.btnConfirmBooking.TabIndex = 14;
            this.btnConfirmBooking.TabStop = false;
            this.btnConfirmBooking.Text = "Xác nhận đặt phòng";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Visible = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // panelCustomerUsername
            // 
            this.panelCustomerUsername.Controls.Add(this.underlineCustomerUsername);
            this.panelCustomerUsername.Controls.Add(this.customerUsername);
            this.panelCustomerUsername.Controls.Add(this.lblCustomerUsername);
            this.panelCustomerUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerUsername.Location = new System.Drawing.Point(3, 458);
            this.panelCustomerUsername.Name = "panelCustomerUsername";
            this.panelCustomerUsername.Size = new System.Drawing.Size(402, 53);
            this.panelCustomerUsername.TabIndex = 13;
            this.panelCustomerUsername.Visible = false;
            // 
            // underlineCustomerUsername
            // 
            this.underlineCustomerUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineCustomerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineCustomerUsername.Location = new System.Drawing.Point(248, 41);
            this.underlineCustomerUsername.Margin = new System.Windows.Forms.Padding(2);
            this.underlineCustomerUsername.Name = "underlineCustomerUsername";
            this.underlineCustomerUsername.Size = new System.Drawing.Size(150, 1);
            this.underlineCustomerUsername.TabIndex = 3;
            // 
            // customerUsername
            // 
            this.customerUsername.BackColor = System.Drawing.Color.Silver;
            this.customerUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerUsername.Enabled = false;
            this.customerUsername.Location = new System.Drawing.Point(248, 8);
            this.customerUsername.Name = "customerUsername";
            this.customerUsername.Size = new System.Drawing.Size(151, 31);
            this.customerUsername.TabIndex = 1;
            // 
            // lblCustomerUsername
            // 
            this.lblCustomerUsername.AutoSize = true;
            this.lblCustomerUsername.Location = new System.Drawing.Point(3, 11);
            this.lblCustomerUsername.Name = "lblCustomerUsername";
            this.lblCustomerUsername.Size = new System.Drawing.Size(133, 31);
            this.lblCustomerUsername.TabIndex = 0;
            this.lblCustomerUsername.Text = "Tài khoản";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(3, 665);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(402, 70);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Hủy đặt phòng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(3, 589);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(402, 70);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Sửa đặt phòng";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Location = new System.Drawing.Point(3, 665);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(402, 70);
            this.btnBooking.TabIndex = 10;
            this.btnBooking.TabStop = false;
            this.btnBooking.Text = "Đặt phòng";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Visible = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // panelCustomerName
            // 
            this.panelCustomerName.Controls.Add(this.underlineCustomerName);
            this.panelCustomerName.Controls.Add(this.customerName);
            this.panelCustomerName.Controls.Add(this.lblCustomerName);
            this.panelCustomerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerName.Location = new System.Drawing.Point(3, 405);
            this.panelCustomerName.Name = "panelCustomerName";
            this.panelCustomerName.Size = new System.Drawing.Size(402, 53);
            this.panelCustomerName.TabIndex = 9;
            // 
            // underlineCustomerName
            // 
            this.underlineCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineCustomerName.Location = new System.Drawing.Point(248, 41);
            this.underlineCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.underlineCustomerName.Name = "underlineCustomerName";
            this.underlineCustomerName.Size = new System.Drawing.Size(150, 1);
            this.underlineCustomerName.TabIndex = 3;
            // 
            // customerName
            // 
            this.customerName.BackColor = System.Drawing.SystemColors.Control;
            this.customerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerName.Location = new System.Drawing.Point(248, 8);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(151, 31);
            this.customerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 11);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(208, 31);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Tên khách hàng";
            // 
            // panelPhone
            // 
            this.panelPhone.Controls.Add(this.underlinePhone);
            this.panelPhone.Controls.Add(this.phone);
            this.panelPhone.Controls.Add(this.lblPhone);
            this.panelPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhone.Location = new System.Drawing.Point(3, 352);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(402, 53);
            this.panelPhone.TabIndex = 8;
            // 
            // underlinePhone
            // 
            this.underlinePhone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlinePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlinePhone.Location = new System.Drawing.Point(248, 41);
            this.underlinePhone.Margin = new System.Windows.Forms.Padding(2);
            this.underlinePhone.Name = "underlinePhone";
            this.underlinePhone.Size = new System.Drawing.Size(150, 1);
            this.underlinePhone.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.Control;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Location = new System.Drawing.Point(248, 8);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(151, 31);
            this.phone.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 11);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(171, 31);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // panelTimeStart
            // 
            this.panelTimeStart.Controls.Add(this.timeStart);
            this.panelTimeStart.Controls.Add(this.lblTimeStart);
            this.panelTimeStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeStart.Location = new System.Drawing.Point(3, 299);
            this.panelTimeStart.Name = "panelTimeStart";
            this.panelTimeStart.Size = new System.Drawing.Size(402, 53);
            this.panelTimeStart.TabIndex = 7;
            // 
            // timeStart
            // 
            this.timeStart.Checked = false;
            this.timeStart.CustomFormat = "HH:mm";
            this.timeStart.Enabled = false;
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(248, 9);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(150, 38);
            this.timeStart.TabIndex = 1;
            this.timeStart.Value = new System.DateTime(2024, 4, 28, 23, 17, 0, 0);
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(3, 11);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(101, 31);
            this.lblTimeStart.TabIndex = 0;
            this.lblTimeStart.Text = "Giờ đặt";
            // 
            // panelRoomPrice
            // 
            this.panelRoomPrice.Controls.Add(this.underlineRoomPrice);
            this.panelRoomPrice.Controls.Add(this.roomPrice);
            this.panelRoomPrice.Controls.Add(this.lblRoomPrice);
            this.panelRoomPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomPrice.Location = new System.Drawing.Point(3, 246);
            this.panelRoomPrice.Name = "panelRoomPrice";
            this.panelRoomPrice.Size = new System.Drawing.Size(402, 53);
            this.panelRoomPrice.TabIndex = 5;
            // 
            // underlineRoomPrice
            // 
            this.underlineRoomPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineRoomPrice.Location = new System.Drawing.Point(248, 41);
            this.underlineRoomPrice.Margin = new System.Windows.Forms.Padding(2);
            this.underlineRoomPrice.Name = "underlineRoomPrice";
            this.underlineRoomPrice.Size = new System.Drawing.Size(150, 1);
            this.underlineRoomPrice.TabIndex = 3;
            // 
            // roomPrice
            // 
            this.roomPrice.BackColor = System.Drawing.Color.Silver;
            this.roomPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomPrice.Enabled = false;
            this.roomPrice.Location = new System.Drawing.Point(248, 8);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(151, 31);
            this.roomPrice.TabIndex = 1;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(3, 11);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(138, 31);
            this.lblRoomPrice.TabIndex = 0;
            this.lblRoomPrice.Text = "Giá phòng";
            // 
            // panelRoomType
            // 
            this.panelRoomType.Controls.Add(this.underlineRoomType);
            this.panelRoomType.Controls.Add(this.roomType);
            this.panelRoomType.Controls.Add(this.lblRoomType);
            this.panelRoomType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomType.Location = new System.Drawing.Point(3, 193);
            this.panelRoomType.Name = "panelRoomType";
            this.panelRoomType.Size = new System.Drawing.Size(402, 53);
            this.panelRoomType.TabIndex = 4;
            // 
            // underlineRoomType
            // 
            this.underlineRoomType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineRoomType.Location = new System.Drawing.Point(248, 41);
            this.underlineRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.underlineRoomType.Name = "underlineRoomType";
            this.underlineRoomType.Size = new System.Drawing.Size(150, 1);
            this.underlineRoomType.TabIndex = 3;
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.Color.Silver;
            this.roomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomType.Enabled = false;
            this.roomType.Location = new System.Drawing.Point(248, 8);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(151, 31);
            this.roomType.TabIndex = 1;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(3, 11);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(147, 31);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Loại phòng";
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
            // timerUpdateTimeStart
            // 
            this.timerUpdateTimeStart.Interval = 1000;
            this.timerUpdateTimeStart.Tick += new System.EventHandler(this.timerUpdateTimeStart_Tick);
            // 
            // fBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelControl);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fBooking";
            this.Text = "fBooking";
            this.Load += new System.EventHandler(this.fAdvanceBooking_Load);
            this.panelControl.ResumeLayout(false);
            this.panelRoomInformation.ResumeLayout(false);
            this.groupBoxBookingDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetail)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.groupBoxBooking.ResumeLayout(false);
            this.panelCustomerUsername.ResumeLayout(false);
            this.panelCustomerUsername.PerformLayout();
            this.panelCustomerName.ResumeLayout(false);
            this.panelCustomerName.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.panelTimeStart.ResumeLayout(false);
            this.panelTimeStart.PerformLayout();
            this.panelRoomPrice.ResumeLayout(false);
            this.panelRoomPrice.PerformLayout();
            this.panelRoomType.ResumeLayout(false);
            this.panelRoomType.PerformLayout();
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
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Panel panelControlTime;
        private System.Windows.Forms.GroupBox groupBoxRoom;
        private System.Windows.Forms.GroupBox groupBoxBooking;
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
        private System.Windows.Forms.Panel panelRoomPrice;
        private System.Windows.Forms.Panel underlineRoomPrice;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Panel panelRoomType;
        private System.Windows.Forms.Panel underlineRoomType;
        private System.Windows.Forms.TextBox roomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Panel panelCustomerName;
        private System.Windows.Forms.Panel underlineCustomerName;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel underlinePhone;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panelTimeStart;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxBookingDetail;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timerRealtime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timerUpdateTimeStart;
        private System.Windows.Forms.Panel panelCustomerUsername;
        private System.Windows.Forms.Panel underlineCustomerUsername;
        private System.Windows.Forms.TextBox customerUsername;
        private System.Windows.Forms.Label lblCustomerUsername;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDeleteUsingRoom;
    }
}