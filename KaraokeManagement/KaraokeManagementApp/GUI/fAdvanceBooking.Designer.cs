namespace GUI
{
    partial class fAdvanceBooking
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
            this.panelAdvanceBooking = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.tabControlBooking = new System.Windows.Forms.TabControl();
            this.tabPageBookingDetail = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingDetail = new System.Windows.Forms.DataGridView();
            this.tabPageBookingHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingHistory = new System.Windows.Forms.DataGridView();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.groupBoxBookingInformation = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.panelUsesrname = new System.Windows.Forms.Panel();
            this.underlineUsername = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRoom = new System.Windows.Forms.GroupBox();
            this.roomList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAdvanceBooking.SuspendLayout();
            this.panelRoomInformation.SuspendLayout();
            this.tabControlBooking.SuspendLayout();
            this.tabPageBookingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetail)).BeginInit();
            this.tabPageBookingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingHistory)).BeginInit();
            this.panelBooking.SuspendLayout();
            this.groupBoxBookingInformation.SuspendLayout();
            this.panelUsesrname.SuspendLayout();
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
            // panelAdvanceBooking
            // 
            this.panelAdvanceBooking.Controls.Add(this.panelRoomInformation);
            this.panelAdvanceBooking.Controls.Add(this.panelBooking);
            this.panelAdvanceBooking.Controls.Add(this.panelRoom);
            this.panelAdvanceBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdvanceBooking.Location = new System.Drawing.Point(0, 0);
            this.panelAdvanceBooking.Name = "panelAdvanceBooking";
            this.panelAdvanceBooking.Size = new System.Drawing.Size(1344, 761);
            this.panelAdvanceBooking.TabIndex = 0;
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRoomInformation.Controls.Add(this.tabControlBooking);
            this.panelRoomInformation.Location = new System.Drawing.Point(12, 515);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(900, 231);
            this.panelRoomInformation.TabIndex = 2;
            // 
            // tabControlBooking
            // 
            this.tabControlBooking.Controls.Add(this.tabPageBookingDetail);
            this.tabControlBooking.Controls.Add(this.tabPageBookingHistory);
            this.tabControlBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBooking.Location = new System.Drawing.Point(3, 3);
            this.tabControlBooking.Name = "tabControlBooking";
            this.tabControlBooking.SelectedIndex = 0;
            this.tabControlBooking.Size = new System.Drawing.Size(891, 222);
            this.tabControlBooking.TabIndex = 0;
            this.tabControlBooking.SelectedIndexChanged += new System.EventHandler(this.tabControlRoomInformation_SelectedIndexChanged);
            // 
            // tabPageBookingDetail
            // 
            this.tabPageBookingDetail.Controls.Add(this.dataGridViewBookingDetail);
            this.tabPageBookingDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBookingDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPageBookingDetail.Name = "tabPageBookingDetail";
            this.tabPageBookingDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookingDetail.Size = new System.Drawing.Size(883, 184);
            this.tabPageBookingDetail.TabIndex = 0;
            this.tabPageBookingDetail.Text = "Chi tiết đặt phòng";
            this.tabPageBookingDetail.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingDetail
            // 
            this.dataGridViewBookingDetail.AllowUserToAddRows = false;
            this.dataGridViewBookingDetail.AllowUserToDeleteRows = false;
            this.dataGridViewBookingDetail.AllowUserToResizeRows = false;
            this.dataGridViewBookingDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookingDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookingDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingDetail.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookingDetail.Name = "dataGridViewBookingDetail";
            this.dataGridViewBookingDetail.ReadOnly = true;
            this.dataGridViewBookingDetail.RowHeadersWidth = 51;
            this.dataGridViewBookingDetail.Size = new System.Drawing.Size(877, 178);
            this.dataGridViewBookingDetail.TabIndex = 0;
            // 
            // tabPageBookingHistory
            // 
            this.tabPageBookingHistory.Controls.Add(this.dataGridViewBookingHistory);
            this.tabPageBookingHistory.Location = new System.Drawing.Point(4, 34);
            this.tabPageBookingHistory.Name = "tabPageBookingHistory";
            this.tabPageBookingHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookingHistory.Size = new System.Drawing.Size(883, 184);
            this.tabPageBookingHistory.TabIndex = 1;
            this.tabPageBookingHistory.Text = "Lịch sử đặt phòng của bản thân";
            this.tabPageBookingHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingHistory
            // 
            this.dataGridViewBookingHistory.AllowUserToAddRows = false;
            this.dataGridViewBookingHistory.AllowUserToDeleteRows = false;
            this.dataGridViewBookingHistory.AllowUserToResizeRows = false;
            this.dataGridViewBookingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBookingHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingHistory.Location = new System.Drawing.Point(3, 4);
            this.dataGridViewBookingHistory.Name = "dataGridViewBookingHistory";
            this.dataGridViewBookingHistory.ReadOnly = true;
            this.dataGridViewBookingHistory.RowHeadersWidth = 51;
            this.dataGridViewBookingHistory.Size = new System.Drawing.Size(877, 177);
            this.dataGridViewBookingHistory.TabIndex = 1;
            this.dataGridViewBookingHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookingHistory_CellClick);
            // 
            // panelBooking
            // 
            this.panelBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBooking.BackColor = System.Drawing.SystemColors.Control;
            this.panelBooking.Controls.Add(this.groupBoxBookingInformation);
            this.panelBooking.Enabled = false;
            this.panelBooking.Location = new System.Drawing.Point(918, 12);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(414, 737);
            this.panelBooking.TabIndex = 1;
            // 
            // groupBoxBookingInformation
            // 
            this.groupBoxBookingInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBookingInformation.Controls.Add(this.btnDelete);
            this.groupBoxBookingInformation.Controls.Add(this.btnEdit);
            this.groupBoxBookingInformation.Controls.Add(this.btnBooking);
            this.groupBoxBookingInformation.Controls.Add(this.panelUsesrname);
            this.groupBoxBookingInformation.Controls.Add(this.panelPhone);
            this.groupBoxBookingInformation.Controls.Add(this.panelTimeStart);
            this.groupBoxBookingInformation.Controls.Add(this.panelRoomPrice);
            this.groupBoxBookingInformation.Controls.Add(this.panelRoomType);
            this.groupBoxBookingInformation.Controls.Add(this.panelRoomName);
            this.groupBoxBookingInformation.Controls.Add(this.panelRoomID);
            this.groupBoxBookingInformation.Controls.Add(this.panelBookID);
            this.groupBoxBookingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBookingInformation.Location = new System.Drawing.Point(3, 8);
            this.groupBoxBookingInformation.Name = "groupBoxBookingInformation";
            this.groupBoxBookingInformation.Size = new System.Drawing.Size(408, 726);
            this.groupBoxBookingInformation.TabIndex = 0;
            this.groupBoxBookingInformation.TabStop = false;
            this.groupBoxBookingInformation.Text = "Thông tin đặt phòng";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(3, 650);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(402, 70);
            this.btnDelete.TabIndex = 12;
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
            this.btnEdit.Location = new System.Drawing.Point(3, 574);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(402, 70);
            this.btnEdit.TabIndex = 11;
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
            this.btnBooking.Location = new System.Drawing.Point(3, 650);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(402, 70);
            this.btnBooking.TabIndex = 10;
            this.btnBooking.Text = "Đặt phòng";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // panelUsesrname
            // 
            this.panelUsesrname.Controls.Add(this.underlineUsername);
            this.panelUsesrname.Controls.Add(this.username);
            this.panelUsesrname.Controls.Add(this.lblUsername);
            this.panelUsesrname.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsesrname.Location = new System.Drawing.Point(3, 405);
            this.panelUsesrname.Name = "panelUsesrname";
            this.panelUsesrname.Size = new System.Drawing.Size(402, 53);
            this.panelUsesrname.TabIndex = 9;
            // 
            // underlineUsername
            // 
            this.underlineUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineUsername.Location = new System.Drawing.Point(248, 41);
            this.underlineUsername.Margin = new System.Windows.Forms.Padding(2);
            this.underlineUsername.Name = "underlineUsername";
            this.underlineUsername.Size = new System.Drawing.Size(150, 1);
            this.underlineUsername.TabIndex = 3;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Silver;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(248, 8);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(151, 31);
            this.username.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(178, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên tài khoản";
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
            this.panelControlTime.Controls.Add(this.btnNextDay);
            this.panelControlTime.Controls.Add(this.btnPreviousDay);
            this.panelControlTime.Controls.Add(this.dateTimePicker);
            this.panelControlTime.Location = new System.Drawing.Point(3, 3);
            this.panelControlTime.Name = "panelControlTime";
            this.panelControlTime.Size = new System.Drawing.Size(894, 56);
            this.panelControlTime.TabIndex = 1;
            // 
            // btnNextDay
            // 
            this.btnNextDay.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNextDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDay.Location = new System.Drawing.Point(734, 5);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(157, 48);
            this.btnNextDay.TabIndex = 3;
            this.btnNextDay.Text = "Ngày sau";
            this.btnNextDay.UseVisualStyleBackColor = false;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousDay.Enabled = false;
            this.btnPreviousDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPreviousDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPreviousDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousDay.Location = new System.Drawing.Point(3, 5);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(157, 48);
            this.btnPreviousDay.TabIndex = 2;
            this.btnPreviousDay.Text = "Ngày trước";
            this.btnPreviousDay.UseVisualStyleBackColor = false;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(358, 8);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 38);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            this.roomList.Location = new System.Drawing.Point(6, 38);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(876, 388);
            this.roomList.TabIndex = 0;
            // 
            // fAdvanceBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelAdvanceBooking);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fAdvanceBooking";
            this.Text = "fAdvanceBooking";
            this.Load += new System.EventHandler(this.fAdvanceBooking_Load);
            this.panelAdvanceBooking.ResumeLayout(false);
            this.panelRoomInformation.ResumeLayout(false);
            this.tabControlBooking.ResumeLayout(false);
            this.tabPageBookingDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingDetail)).EndInit();
            this.tabPageBookingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingHistory)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.groupBoxBookingInformation.ResumeLayout(false);
            this.panelUsesrname.ResumeLayout(false);
            this.panelUsesrname.PerformLayout();
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
            this.groupBoxRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSynchrony;
        private System.Windows.Forms.Panel panelAdvanceBooking;
        private System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Panel panelControlTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBoxRoom;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.GroupBox groupBoxBookingInformation;
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
        private System.Windows.Forms.Panel panelUsesrname;
        private System.Windows.Forms.Panel underlineUsername;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel underlinePhone;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panelTimeStart;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TabControl tabControlBooking;
        private System.Windows.Forms.TabPage tabPageBookingDetail;
        private System.Windows.Forms.TabPage tabPageBookingHistory;
        private System.Windows.Forms.DataGridView dataGridViewBookingHistory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}