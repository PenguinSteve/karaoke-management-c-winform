namespace GUI
{
    partial class fServiceManagement
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
            this.panelServiceManagement = new System.Windows.Forms.Panel();
            this.panelServiceInformation = new System.Windows.Forms.Panel();
            this.groupBoxServiceInformation = new System.Windows.Forms.GroupBox();
            this.panelServiceQuantity = new System.Windows.Forms.Panel();
            this.underlineServiceQuantity = new System.Windows.Forms.Panel();
            this.serviceQuantity = new System.Windows.Forms.TextBox();
            this.lblServiceQuantity = new System.Windows.Forms.Label();
            this.panelServicePrice = new System.Windows.Forms.Panel();
            this.underlineServicePrice = new System.Windows.Forms.Panel();
            this.servicePrice = new System.Windows.Forms.TextBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.panelServiceName = new System.Windows.Forms.Panel();
            this.underlineServiceName = new System.Windows.Forms.Panel();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.panelServiceID = new System.Windows.Forms.Panel();
            this.underlineServiceID = new System.Windows.Forms.Panel();
            this.serviceID = new System.Windows.Forms.TextBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnCreateService = new System.Windows.Forms.Button();
            this.panelServiceList = new System.Windows.Forms.Panel();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.dataGridViewServiceList = new System.Windows.Forms.DataGridView();
            this.panelServiceManagement.SuspendLayout();
            this.panelServiceInformation.SuspendLayout();
            this.groupBoxServiceInformation.SuspendLayout();
            this.panelServiceQuantity.SuspendLayout();
            this.panelServicePrice.SuspendLayout();
            this.panelServiceName.SuspendLayout();
            this.panelServiceID.SuspendLayout();
            this.panelServiceList.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServiceManagement
            // 
            this.panelServiceManagement.Controls.Add(this.panelServiceInformation);
            this.panelServiceManagement.Controls.Add(this.panelServiceList);
            this.panelServiceManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServiceManagement.Location = new System.Drawing.Point(0, 0);
            this.panelServiceManagement.Name = "panelServiceManagement";
            this.panelServiceManagement.Size = new System.Drawing.Size(1344, 761);
            this.panelServiceManagement.TabIndex = 0;
            // 
            // panelServiceInformation
            // 
            this.panelServiceInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelServiceInformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelServiceInformation.Controls.Add(this.groupBoxServiceInformation);
            this.panelServiceInformation.Location = new System.Drawing.Point(918, 12);
            this.panelServiceInformation.Name = "panelServiceInformation";
            this.panelServiceInformation.Size = new System.Drawing.Size(414, 737);
            this.panelServiceInformation.TabIndex = 1;
            // 
            // groupBoxServiceInformation
            // 
            this.groupBoxServiceInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxServiceInformation.Controls.Add(this.panelServiceQuantity);
            this.groupBoxServiceInformation.Controls.Add(this.panelServicePrice);
            this.groupBoxServiceInformation.Controls.Add(this.panelServiceName);
            this.groupBoxServiceInformation.Controls.Add(this.panelServiceID);
            this.groupBoxServiceInformation.Controls.Add(this.btnReset2);
            this.groupBoxServiceInformation.Controls.Add(this.btnCreateService);
            this.groupBoxServiceInformation.Controls.Add(this.btnDeleteService);
            this.groupBoxServiceInformation.Controls.Add(this.btnEditRoom);
            this.groupBoxServiceInformation.Controls.Add(this.btnReset);
            this.groupBoxServiceInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServiceInformation.Location = new System.Drawing.Point(3, 8);
            this.groupBoxServiceInformation.Name = "groupBoxServiceInformation";
            this.groupBoxServiceInformation.Size = new System.Drawing.Size(408, 726);
            this.groupBoxServiceInformation.TabIndex = 0;
            this.groupBoxServiceInformation.TabStop = false;
            this.groupBoxServiceInformation.Text = "Thông tin dịch vụ";
            // 
            // panelServiceQuantity
            // 
            this.panelServiceQuantity.Controls.Add(this.underlineServiceQuantity);
            this.panelServiceQuantity.Controls.Add(this.serviceQuantity);
            this.panelServiceQuantity.Controls.Add(this.lblServiceQuantity);
            this.panelServiceQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServiceQuantity.Location = new System.Drawing.Point(3, 193);
            this.panelServiceQuantity.Name = "panelServiceQuantity";
            this.panelServiceQuantity.Size = new System.Drawing.Size(402, 53);
            this.panelServiceQuantity.TabIndex = 14;
            // 
            // underlineServiceQuantity
            // 
            this.underlineServiceQuantity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineServiceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineServiceQuantity.Location = new System.Drawing.Point(248, 41);
            this.underlineServiceQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.underlineServiceQuantity.Name = "underlineServiceQuantity";
            this.underlineServiceQuantity.Size = new System.Drawing.Size(150, 1);
            this.underlineServiceQuantity.TabIndex = 3;
            // 
            // serviceQuantity
            // 
            this.serviceQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.serviceQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceQuantity.Location = new System.Drawing.Point(248, 8);
            this.serviceQuantity.Name = "serviceQuantity";
            this.serviceQuantity.Size = new System.Drawing.Size(151, 31);
            this.serviceQuantity.TabIndex = 1;
            // 
            // lblServiceQuantity
            // 
            this.lblServiceQuantity.AutoSize = true;
            this.lblServiceQuantity.Location = new System.Drawing.Point(3, 11);
            this.lblServiceQuantity.Name = "lblServiceQuantity";
            this.lblServiceQuantity.Size = new System.Drawing.Size(120, 31);
            this.lblServiceQuantity.TabIndex = 0;
            this.lblServiceQuantity.Text = "Số lượng";
            // 
            // panelServicePrice
            // 
            this.panelServicePrice.Controls.Add(this.underlineServicePrice);
            this.panelServicePrice.Controls.Add(this.servicePrice);
            this.panelServicePrice.Controls.Add(this.lblServicePrice);
            this.panelServicePrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServicePrice.Location = new System.Drawing.Point(3, 140);
            this.panelServicePrice.Name = "panelServicePrice";
            this.panelServicePrice.Size = new System.Drawing.Size(402, 53);
            this.panelServicePrice.TabIndex = 8;
            // 
            // underlineServicePrice
            // 
            this.underlineServicePrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineServicePrice.Location = new System.Drawing.Point(248, 41);
            this.underlineServicePrice.Margin = new System.Windows.Forms.Padding(2);
            this.underlineServicePrice.Name = "underlineServicePrice";
            this.underlineServicePrice.Size = new System.Drawing.Size(150, 1);
            this.underlineServicePrice.TabIndex = 3;
            // 
            // servicePrice
            // 
            this.servicePrice.BackColor = System.Drawing.SystemColors.Control;
            this.servicePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicePrice.Location = new System.Drawing.Point(248, 8);
            this.servicePrice.Name = "servicePrice";
            this.servicePrice.Size = new System.Drawing.Size(151, 31);
            this.servicePrice.TabIndex = 1;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(3, 11);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(149, 31);
            this.lblServicePrice.TabIndex = 0;
            this.lblServicePrice.Text = "Giá dịch vụ";
            // 
            // panelServiceName
            // 
            this.panelServiceName.Controls.Add(this.underlineServiceName);
            this.panelServiceName.Controls.Add(this.serviceName);
            this.panelServiceName.Controls.Add(this.lblServiceName);
            this.panelServiceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServiceName.Location = new System.Drawing.Point(3, 87);
            this.panelServiceName.Name = "panelServiceName";
            this.panelServiceName.Size = new System.Drawing.Size(402, 53);
            this.panelServiceName.TabIndex = 2;
            // 
            // underlineServiceName
            // 
            this.underlineServiceName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineServiceName.Location = new System.Drawing.Point(248, 41);
            this.underlineServiceName.Margin = new System.Windows.Forms.Padding(2);
            this.underlineServiceName.Name = "underlineServiceName";
            this.underlineServiceName.Size = new System.Drawing.Size(150, 1);
            this.underlineServiceName.TabIndex = 3;
            // 
            // serviceName
            // 
            this.serviceName.BackColor = System.Drawing.SystemColors.Control;
            this.serviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceName.Location = new System.Drawing.Point(248, 8);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(151, 31);
            this.serviceName.TabIndex = 1;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(3, 11);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(154, 31);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Tên dịch vụ";
            // 
            // panelServiceID
            // 
            this.panelServiceID.Controls.Add(this.underlineServiceID);
            this.panelServiceID.Controls.Add(this.serviceID);
            this.panelServiceID.Controls.Add(this.lblServiceID);
            this.panelServiceID.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServiceID.Location = new System.Drawing.Point(3, 34);
            this.panelServiceID.Name = "panelServiceID";
            this.panelServiceID.Size = new System.Drawing.Size(402, 53);
            this.panelServiceID.TabIndex = 1;
            // 
            // underlineServiceID
            // 
            this.underlineServiceID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineServiceID.Location = new System.Drawing.Point(248, 41);
            this.underlineServiceID.Margin = new System.Windows.Forms.Padding(2);
            this.underlineServiceID.Name = "underlineServiceID";
            this.underlineServiceID.Size = new System.Drawing.Size(150, 1);
            this.underlineServiceID.TabIndex = 3;
            // 
            // serviceID
            // 
            this.serviceID.BackColor = System.Drawing.Color.Silver;
            this.serviceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceID.Enabled = false;
            this.serviceID.Location = new System.Drawing.Point(248, 8);
            this.serviceID.Name = "serviceID";
            this.serviceID.Size = new System.Drawing.Size(151, 31);
            this.serviceID.TabIndex = 1;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(3, 11);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(144, 31);
            this.lblServiceID.TabIndex = 0;
            this.lblServiceID.Text = "Mã dịch vụ";
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
            // btnDeleteService
            // 
            this.btnDeleteService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Location = new System.Drawing.Point(3, 650);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(402, 70);
            this.btnDeleteService.TabIndex = 18;
            this.btnDeleteService.TabStop = false;
            this.btnDeleteService.Text = "Xóa dịch vụ";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Visible = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnCreateService
            // 
            this.btnCreateService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateService.Location = new System.Drawing.Point(3, 650);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(402, 70);
            this.btnCreateService.TabIndex = 10;
            this.btnCreateService.TabStop = false;
            this.btnCreateService.Text = "Thêm dịch vụ";
            this.btnCreateService.UseVisualStyleBackColor = true;
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // panelServiceList
            // 
            this.panelServiceList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelServiceList.Controls.Add(this.groupBoxService);
            this.panelServiceList.Location = new System.Drawing.Point(12, 12);
            this.panelServiceList.Name = "panelServiceList";
            this.panelServiceList.Size = new System.Drawing.Size(900, 737);
            this.panelServiceList.TabIndex = 0;
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.dataGridViewServiceList);
            this.groupBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxService.Location = new System.Drawing.Point(3, 8);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(894, 726);
            this.groupBoxService.TabIndex = 0;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Danh sách dịch vụ";
            // 
            // dataGridViewServiceList
            // 
            this.dataGridViewServiceList.AllowUserToAddRows = false;
            this.dataGridViewServiceList.AllowUserToDeleteRows = false;
            this.dataGridViewServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceList.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewServiceList.Name = "dataGridViewServiceList";
            this.dataGridViewServiceList.ReadOnly = true;
            this.dataGridViewServiceList.Size = new System.Drawing.Size(882, 686);
            this.dataGridViewServiceList.TabIndex = 0;
            this.dataGridViewServiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffList_CellClick);
            // 
            // fServiceManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelServiceManagement);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fServiceManagement";
            this.Text = "fRoomManagement";
            this.Load += new System.EventHandler(this.fAdvanceBooking_Load);
            this.panelServiceManagement.ResumeLayout(false);
            this.panelServiceInformation.ResumeLayout(false);
            this.groupBoxServiceInformation.ResumeLayout(false);
            this.panelServiceQuantity.ResumeLayout(false);
            this.panelServiceQuantity.PerformLayout();
            this.panelServicePrice.ResumeLayout(false);
            this.panelServicePrice.PerformLayout();
            this.panelServiceName.ResumeLayout(false);
            this.panelServiceName.PerformLayout();
            this.panelServiceID.ResumeLayout(false);
            this.panelServiceID.PerformLayout();
            this.panelServiceList.ResumeLayout(false);
            this.groupBoxService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelServiceManagement;
        private System.Windows.Forms.Panel panelServiceList;
        private System.Windows.Forms.Panel panelServiceInformation;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.GroupBox groupBoxServiceInformation;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox serviceID;
        private System.Windows.Forms.Panel panelServiceID;
        private System.Windows.Forms.Panel underlineServiceID;
        private System.Windows.Forms.Panel panelServiceName;
        private System.Windows.Forms.Panel underlineServiceName;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Panel panelServicePrice;
        private System.Windows.Forms.Panel underlineServicePrice;
        private System.Windows.Forms.TextBox servicePrice;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Button btnCreateService;
        private System.Windows.Forms.DataGridView dataGridViewServiceList;
        private System.Windows.Forms.Panel panelServiceQuantity;
        private System.Windows.Forms.Panel underlineServiceQuantity;
        private System.Windows.Forms.TextBox serviceQuantity;
        private System.Windows.Forms.Label lblServiceQuantity;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
    }
}