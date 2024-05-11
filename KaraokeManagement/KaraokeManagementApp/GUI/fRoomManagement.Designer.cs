namespace GUI
{
    partial class fRoomManagement
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
            this.panelRoomManagement = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.groupBoxRoomInformation = new System.Windows.Forms.GroupBox();
            this.panelRoomStatus = new System.Windows.Forms.Panel();
            this.underlineRoomStatus = new System.Windows.Forms.Panel();
            this.roomStatus = new System.Windows.Forms.TextBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
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
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnableRoom = new System.Windows.Forms.Button();
            this.btnDisableRoom = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.panelRoomList = new System.Windows.Forms.Panel();
            this.groupBoxRoom = new System.Windows.Forms.GroupBox();
            this.dataGridViewRoomList = new System.Windows.Forms.DataGridView();
            this.panelRoomManagement.SuspendLayout();
            this.panelRoomInformation.SuspendLayout();
            this.groupBoxRoomInformation.SuspendLayout();
            this.panelRoomStatus.SuspendLayout();
            this.panelRoomPrice.SuspendLayout();
            this.panelRoomType.SuspendLayout();
            this.panelRoomName.SuspendLayout();
            this.panelRoomID.SuspendLayout();
            this.panelRoomList.SuspendLayout();
            this.groupBoxRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoomManagement
            // 
            this.panelRoomManagement.Controls.Add(this.panelRoomInformation);
            this.panelRoomManagement.Controls.Add(this.panelRoomList);
            this.panelRoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomManagement.Location = new System.Drawing.Point(0, 0);
            this.panelRoomManagement.Name = "panelRoomManagement";
            this.panelRoomManagement.Size = new System.Drawing.Size(1344, 761);
            this.panelRoomManagement.TabIndex = 0;
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRoomInformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelRoomInformation.Controls.Add(this.groupBoxRoomInformation);
            this.panelRoomInformation.Location = new System.Drawing.Point(918, 12);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(414, 737);
            this.panelRoomInformation.TabIndex = 1;
            // 
            // groupBoxRoomInformation
            // 
            this.groupBoxRoomInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRoomInformation.Controls.Add(this.panelRoomStatus);
            this.groupBoxRoomInformation.Controls.Add(this.panelRoomPrice);
            this.groupBoxRoomInformation.Controls.Add(this.panelRoomType);
            this.groupBoxRoomInformation.Controls.Add(this.panelRoomName);
            this.groupBoxRoomInformation.Controls.Add(this.panelRoomID);
            this.groupBoxRoomInformation.Controls.Add(this.btnReset2);
            this.groupBoxRoomInformation.Controls.Add(this.btnEditRoom);
            this.groupBoxRoomInformation.Controls.Add(this.btnReset);
            this.groupBoxRoomInformation.Controls.Add(this.btnEnableRoom);
            this.groupBoxRoomInformation.Controls.Add(this.btnDisableRoom);
            this.groupBoxRoomInformation.Controls.Add(this.btnCreateRoom);
            this.groupBoxRoomInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoomInformation.Location = new System.Drawing.Point(3, 8);
            this.groupBoxRoomInformation.Name = "groupBoxRoomInformation";
            this.groupBoxRoomInformation.Size = new System.Drawing.Size(408, 726);
            this.groupBoxRoomInformation.TabIndex = 0;
            this.groupBoxRoomInformation.TabStop = false;
            this.groupBoxRoomInformation.Text = "Thông tin phòng";
            // 
            // panelRoomStatus
            // 
            this.panelRoomStatus.Controls.Add(this.underlineRoomStatus);
            this.panelRoomStatus.Controls.Add(this.roomStatus);
            this.panelRoomStatus.Controls.Add(this.lblRoomStatus);
            this.panelRoomStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomStatus.Location = new System.Drawing.Point(3, 246);
            this.panelRoomStatus.Name = "panelRoomStatus";
            this.panelRoomStatus.Size = new System.Drawing.Size(402, 53);
            this.panelRoomStatus.TabIndex = 16;
            // 
            // underlineRoomStatus
            // 
            this.underlineRoomStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineRoomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineRoomStatus.Location = new System.Drawing.Point(248, 41);
            this.underlineRoomStatus.Margin = new System.Windows.Forms.Padding(2);
            this.underlineRoomStatus.Name = "underlineRoomStatus";
            this.underlineRoomStatus.Size = new System.Drawing.Size(150, 1);
            this.underlineRoomStatus.TabIndex = 3;
            // 
            // roomStatus
            // 
            this.roomStatus.BackColor = System.Drawing.Color.Silver;
            this.roomStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomStatus.Enabled = false;
            this.roomStatus.Location = new System.Drawing.Point(248, 8);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.Size = new System.Drawing.Size(151, 31);
            this.roomStatus.TabIndex = 1;
            this.roomStatus.Visible = false;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(3, 11);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(136, 31);
            this.lblRoomStatus.TabIndex = 0;
            this.lblRoomStatus.Text = "Trạng thái";
            // 
            // panelRoomPrice
            // 
            this.panelRoomPrice.Controls.Add(this.underlineRoomPrice);
            this.panelRoomPrice.Controls.Add(this.roomPrice);
            this.panelRoomPrice.Controls.Add(this.lblRoomPrice);
            this.panelRoomPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomPrice.Location = new System.Drawing.Point(3, 193);
            this.panelRoomPrice.Name = "panelRoomPrice";
            this.panelRoomPrice.Size = new System.Drawing.Size(402, 53);
            this.panelRoomPrice.TabIndex = 14;
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
            this.roomPrice.BackColor = System.Drawing.SystemColors.Control;
            this.roomPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.panelRoomType.Location = new System.Drawing.Point(3, 140);
            this.panelRoomType.Name = "panelRoomType";
            this.panelRoomType.Size = new System.Drawing.Size(402, 53);
            this.panelRoomType.TabIndex = 8;
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
            this.roomType.BackColor = System.Drawing.SystemColors.Control;
            this.roomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.panelRoomName.Location = new System.Drawing.Point(3, 87);
            this.panelRoomName.Name = "panelRoomName";
            this.panelRoomName.Size = new System.Drawing.Size(402, 53);
            this.panelRoomName.TabIndex = 2;
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
            this.roomName.BackColor = System.Drawing.SystemColors.Control;
            this.roomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.panelRoomID.Location = new System.Drawing.Point(3, 34);
            this.panelRoomID.Name = "panelRoomID";
            this.panelRoomID.Size = new System.Drawing.Size(402, 53);
            this.panelRoomID.TabIndex = 1;
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
            // btnReset2
            // 
            this.btnReset2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReset2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset2.Location = new System.Drawing.Point(3, 498);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(402, 70);
            this.btnReset2.TabIndex = 20;
            this.btnReset2.TabStop = false;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Visible = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoom.Location = new System.Drawing.Point(3, 574);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(402, 70);
            this.btnEditRoom.TabIndex = 11;
            this.btnEditRoom.TabStop = false;
            this.btnEditRoom.Text = "Sửa thông tin";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Visible = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(3, 574);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(402, 70);
            this.btnReset.TabIndex = 19;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnableRoom
            // 
            this.btnEnableRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEnableRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnableRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableRoom.Location = new System.Drawing.Point(3, 650);
            this.btnEnableRoom.Name = "btnEnableRoom";
            this.btnEnableRoom.Size = new System.Drawing.Size(402, 70);
            this.btnEnableRoom.TabIndex = 21;
            this.btnEnableRoom.TabStop = false;
            this.btnEnableRoom.Text = "Kích hoạt";
            this.btnEnableRoom.UseVisualStyleBackColor = true;
            this.btnEnableRoom.Visible = false;
            this.btnEnableRoom.Click += new System.EventHandler(this.btnEnableRoom_Click);
            // 
            // btnDisableRoom
            // 
            this.btnDisableRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDisableRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisableRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableRoom.Location = new System.Drawing.Point(3, 650);
            this.btnDisableRoom.Name = "btnDisableRoom";
            this.btnDisableRoom.Size = new System.Drawing.Size(402, 70);
            this.btnDisableRoom.TabIndex = 18;
            this.btnDisableRoom.TabStop = false;
            this.btnDisableRoom.Text = "Vô hiệu hóa";
            this.btnDisableRoom.UseVisualStyleBackColor = true;
            this.btnDisableRoom.Visible = false;
            this.btnDisableRoom.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRoom.Location = new System.Drawing.Point(3, 650);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(402, 70);
            this.btnCreateRoom.TabIndex = 10;
            this.btnCreateRoom.TabStop = false;
            this.btnCreateRoom.Text = "Thêm phòng";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateStaff_Click);
            // 
            // panelRoomList
            // 
            this.panelRoomList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRoomList.Controls.Add(this.groupBoxRoom);
            this.panelRoomList.Location = new System.Drawing.Point(12, 12);
            this.panelRoomList.Name = "panelRoomList";
            this.panelRoomList.Size = new System.Drawing.Size(900, 737);
            this.panelRoomList.TabIndex = 0;
            // 
            // groupBoxRoom
            // 
            this.groupBoxRoom.Controls.Add(this.dataGridViewRoomList);
            this.groupBoxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoom.Location = new System.Drawing.Point(3, 8);
            this.groupBoxRoom.Name = "groupBoxRoom";
            this.groupBoxRoom.Size = new System.Drawing.Size(894, 726);
            this.groupBoxRoom.TabIndex = 0;
            this.groupBoxRoom.TabStop = false;
            this.groupBoxRoom.Text = "Danh sách phòng";
            // 
            // dataGridViewRoomList
            // 
            this.dataGridViewRoomList.AllowUserToAddRows = false;
            this.dataGridViewRoomList.AllowUserToDeleteRows = false;
            this.dataGridViewRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomList.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewRoomList.Name = "dataGridViewRoomList";
            this.dataGridViewRoomList.ReadOnly = true;
            this.dataGridViewRoomList.Size = new System.Drawing.Size(882, 686);
            this.dataGridViewRoomList.TabIndex = 0;
            this.dataGridViewRoomList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffList_CellClick);
            // 
            // fRoomManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelRoomManagement);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fRoomManagement";
            this.Text = "fRoomManagement";
            this.Load += new System.EventHandler(this.fAdvanceBooking_Load);
            this.panelRoomManagement.ResumeLayout(false);
            this.panelRoomInformation.ResumeLayout(false);
            this.groupBoxRoomInformation.ResumeLayout(false);
            this.panelRoomStatus.ResumeLayout(false);
            this.panelRoomStatus.PerformLayout();
            this.panelRoomPrice.ResumeLayout(false);
            this.panelRoomPrice.PerformLayout();
            this.panelRoomType.ResumeLayout(false);
            this.panelRoomType.PerformLayout();
            this.panelRoomName.ResumeLayout(false);
            this.panelRoomName.PerformLayout();
            this.panelRoomID.ResumeLayout(false);
            this.panelRoomID.PerformLayout();
            this.panelRoomList.ResumeLayout(false);
            this.groupBoxRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRoomManagement;
        private System.Windows.Forms.Panel panelRoomList;
        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.GroupBox groupBoxRoom;
        private System.Windows.Forms.GroupBox groupBoxRoomInformation;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox roomID;
        private System.Windows.Forms.Panel panelRoomID;
        private System.Windows.Forms.Panel underlineRoomID;
        private System.Windows.Forms.Panel panelRoomName;
        private System.Windows.Forms.Panel underlineRoomName;
        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panelRoomType;
        private System.Windows.Forms.Panel underlineRoomType;
        private System.Windows.Forms.TextBox roomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.DataGridView dataGridViewRoomList;
        private System.Windows.Forms.Panel panelRoomPrice;
        private System.Windows.Forms.Panel underlineRoomPrice;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Panel panelRoomStatus;
        private System.Windows.Forms.Panel underlineRoomStatus;
        private System.Windows.Forms.TextBox roomStatus;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDisableRoom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnEnableRoom;
    }
}