namespace GUI
{
    partial class fStaffManagement
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
            this.panelStaffManagement = new System.Windows.Forms.Panel();
            this.panelStaffInformation = new System.Windows.Forms.Panel();
            this.groupBoxStaffInformation = new System.Windows.Forms.GroupBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.panelRole = new System.Windows.Forms.Panel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.underlineUsername = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.underlinePhone = new System.Windows.Forms.Panel();
            this.phone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelStaffName = new System.Windows.Forms.Panel();
            this.underlineStaffName = new System.Windows.Forms.Panel();
            this.staffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.panelStaffID = new System.Windows.Forms.Panel();
            this.underlineStaffID = new System.Windows.Forms.Panel();
            this.staffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.panelStaffList = new System.Windows.Forms.Panel();
            this.groupBoxStaff = new System.Windows.Forms.GroupBox();
            this.dataGridViewStaffList = new System.Windows.Forms.DataGridView();
            this.btnSetDefaultPassword = new System.Windows.Forms.Button();
            this.panelStaffManagement.SuspendLayout();
            this.panelStaffInformation.SuspendLayout();
            this.groupBoxStaffInformation.SuspendLayout();
            this.panelRole.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.panelStaffName.SuspendLayout();
            this.panelStaffID.SuspendLayout();
            this.panelStaffList.SuspendLayout();
            this.groupBoxStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStaffManagement
            // 
            this.panelStaffManagement.Controls.Add(this.panelStaffInformation);
            this.panelStaffManagement.Controls.Add(this.panelStaffList);
            this.panelStaffManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStaffManagement.Location = new System.Drawing.Point(0, 0);
            this.panelStaffManagement.Name = "panelStaffManagement";
            this.panelStaffManagement.Size = new System.Drawing.Size(1344, 761);
            this.panelStaffManagement.TabIndex = 0;
            // 
            // panelStaffInformation
            // 
            this.panelStaffInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStaffInformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelStaffInformation.Controls.Add(this.groupBoxStaffInformation);
            this.panelStaffInformation.Location = new System.Drawing.Point(918, 12);
            this.panelStaffInformation.Name = "panelStaffInformation";
            this.panelStaffInformation.Size = new System.Drawing.Size(414, 737);
            this.panelStaffInformation.TabIndex = 1;
            // 
            // groupBoxStaffInformation
            // 
            this.groupBoxStaffInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxStaffInformation.Controls.Add(this.btnSetDefaultPassword);
            this.groupBoxStaffInformation.Controls.Add(this.btnReset2);
            this.groupBoxStaffInformation.Controls.Add(this.panelRole);
            this.groupBoxStaffInformation.Controls.Add(this.panelUsername);
            this.groupBoxStaffInformation.Controls.Add(this.panelPhone);
            this.groupBoxStaffInformation.Controls.Add(this.panelStaffName);
            this.groupBoxStaffInformation.Controls.Add(this.panelStaffID);
            this.groupBoxStaffInformation.Controls.Add(this.btnEditStaff);
            this.groupBoxStaffInformation.Controls.Add(this.btnReset);
            this.groupBoxStaffInformation.Controls.Add(this.btnDeleteStaff);
            this.groupBoxStaffInformation.Controls.Add(this.btnCreateStaff);
            this.groupBoxStaffInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStaffInformation.Location = new System.Drawing.Point(3, 8);
            this.groupBoxStaffInformation.Name = "groupBoxStaffInformation";
            this.groupBoxStaffInformation.Size = new System.Drawing.Size(408, 726);
            this.groupBoxStaffInformation.TabIndex = 0;
            this.groupBoxStaffInformation.TabStop = false;
            this.groupBoxStaffInformation.Text = "Thông tin nhân viên";
            // 
            // btnReset2
            // 
            this.btnReset2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReset2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset2.Location = new System.Drawing.Point(3, 422);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(402, 70);
            this.btnReset2.TabIndex = 20;
            this.btnReset2.TabStop = false;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Visible = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelRole
            // 
            this.panelRole.Controls.Add(this.comboBoxRole);
            this.panelRole.Controls.Add(this.lblRole);
            this.panelRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRole.Location = new System.Drawing.Point(3, 246);
            this.panelRole.Name = "panelRole";
            this.panelRole.Size = new System.Drawing.Size(402, 53);
            this.panelRole.TabIndex = 17;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(248, 6);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(151, 39);
            this.comboBoxRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(3, 11);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(114, 31);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Chức vụ";
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.underlineUsername);
            this.panelUsername.Controls.Add(this.username);
            this.panelUsername.Controls.Add(this.lblUsername);
            this.panelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsername.Location = new System.Drawing.Point(3, 193);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(402, 53);
            this.panelUsername.TabIndex = 14;
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
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.panelPhone.Location = new System.Drawing.Point(3, 140);
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
            // panelStaffName
            // 
            this.panelStaffName.Controls.Add(this.underlineStaffName);
            this.panelStaffName.Controls.Add(this.staffName);
            this.panelStaffName.Controls.Add(this.lblStaffName);
            this.panelStaffName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffName.Location = new System.Drawing.Point(3, 87);
            this.panelStaffName.Name = "panelStaffName";
            this.panelStaffName.Size = new System.Drawing.Size(402, 53);
            this.panelStaffName.TabIndex = 2;
            // 
            // underlineStaffName
            // 
            this.underlineStaffName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineStaffName.Location = new System.Drawing.Point(248, 41);
            this.underlineStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.underlineStaffName.Name = "underlineStaffName";
            this.underlineStaffName.Size = new System.Drawing.Size(150, 1);
            this.underlineStaffName.TabIndex = 3;
            // 
            // staffName
            // 
            this.staffName.BackColor = System.Drawing.SystemColors.Control;
            this.staffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffName.Location = new System.Drawing.Point(248, 8);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(151, 31);
            this.staffName.TabIndex = 1;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(3, 11);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(185, 31);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Tên nhân viên";
            // 
            // panelStaffID
            // 
            this.panelStaffID.Controls.Add(this.underlineStaffID);
            this.panelStaffID.Controls.Add(this.staffID);
            this.panelStaffID.Controls.Add(this.lblStaffID);
            this.panelStaffID.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffID.Location = new System.Drawing.Point(3, 34);
            this.panelStaffID.Name = "panelStaffID";
            this.panelStaffID.Size = new System.Drawing.Size(402, 53);
            this.panelStaffID.TabIndex = 1;
            // 
            // underlineStaffID
            // 
            this.underlineStaffID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.underlineStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineStaffID.Location = new System.Drawing.Point(248, 41);
            this.underlineStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.underlineStaffID.Name = "underlineStaffID";
            this.underlineStaffID.Size = new System.Drawing.Size(150, 1);
            this.underlineStaffID.TabIndex = 3;
            // 
            // staffID
            // 
            this.staffID.BackColor = System.Drawing.Color.Silver;
            this.staffID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffID.Enabled = false;
            this.staffID.Location = new System.Drawing.Point(248, 8);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(151, 31);
            this.staffID.TabIndex = 1;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(3, 11);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(175, 31);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Mã nhân viên";
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Location = new System.Drawing.Point(3, 574);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(402, 70);
            this.btnEditStaff.TabIndex = 11;
            this.btnEditStaff.TabStop = false;
            this.btnEditStaff.Text = "Sửa thông tin";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Visible = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEdit_Click);
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
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Location = new System.Drawing.Point(3, 650);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(402, 70);
            this.btnDeleteStaff.TabIndex = 18;
            this.btnDeleteStaff.TabStop = false;
            this.btnDeleteStaff.Text = "Xóa nhân viên";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Visible = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStaff.Location = new System.Drawing.Point(3, 650);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(402, 70);
            this.btnCreateStaff.TabIndex = 10;
            this.btnCreateStaff.TabStop = false;
            this.btnCreateStaff.Text = "Thêm nhân viên";
            this.btnCreateStaff.UseVisualStyleBackColor = true;
            this.btnCreateStaff.Click += new System.EventHandler(this.btnCreateStaff_Click);
            // 
            // panelStaffList
            // 
            this.panelStaffList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStaffList.Controls.Add(this.groupBoxStaff);
            this.panelStaffList.Location = new System.Drawing.Point(12, 12);
            this.panelStaffList.Name = "panelStaffList";
            this.panelStaffList.Size = new System.Drawing.Size(900, 737);
            this.panelStaffList.TabIndex = 0;
            // 
            // groupBoxStaff
            // 
            this.groupBoxStaff.Controls.Add(this.dataGridViewStaffList);
            this.groupBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStaff.Location = new System.Drawing.Point(3, 8);
            this.groupBoxStaff.Name = "groupBoxStaff";
            this.groupBoxStaff.Size = new System.Drawing.Size(894, 726);
            this.groupBoxStaff.TabIndex = 0;
            this.groupBoxStaff.TabStop = false;
            this.groupBoxStaff.Text = "Danh sách nhân viên";
            // 
            // dataGridViewStaffList
            // 
            this.dataGridViewStaffList.AllowUserToAddRows = false;
            this.dataGridViewStaffList.AllowUserToDeleteRows = false;
            this.dataGridViewStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewStaffList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffList.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewStaffList.Name = "dataGridViewStaffList";
            this.dataGridViewStaffList.ReadOnly = true;
            this.dataGridViewStaffList.Size = new System.Drawing.Size(882, 686);
            this.dataGridViewStaffList.TabIndex = 0;
            this.dataGridViewStaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffList_CellClick);
            // 
            // btnSetDefaultPassword
            // 
            this.btnSetDefaultPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSetDefaultPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSetDefaultPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDefaultPassword.Location = new System.Drawing.Point(3, 498);
            this.btnSetDefaultPassword.Name = "btnSetDefaultPassword";
            this.btnSetDefaultPassword.Size = new System.Drawing.Size(402, 70);
            this.btnSetDefaultPassword.TabIndex = 22;
            this.btnSetDefaultPassword.TabStop = false;
            this.btnSetDefaultPassword.Text = "Đặt lại mật khẩu";
            this.btnSetDefaultPassword.UseVisualStyleBackColor = true;
            this.btnSetDefaultPassword.Click += new System.EventHandler(this.btnSetDefaultPassword_Click);
            // 
            // fStaffManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelStaffManagement);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fStaffManagement";
            this.Text = "fStaffManagement";
            this.Load += new System.EventHandler(this.fStaffManagement_Load);
            this.panelStaffManagement.ResumeLayout(false);
            this.panelStaffInformation.ResumeLayout(false);
            this.groupBoxStaffInformation.ResumeLayout(false);
            this.panelRole.ResumeLayout(false);
            this.panelRole.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.panelStaffName.ResumeLayout(false);
            this.panelStaffName.PerformLayout();
            this.panelStaffID.ResumeLayout(false);
            this.panelStaffID.PerformLayout();
            this.panelStaffList.ResumeLayout(false);
            this.groupBoxStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelStaffManagement;
        private System.Windows.Forms.Panel panelStaffList;
        private System.Windows.Forms.Panel panelStaffInformation;
        private System.Windows.Forms.GroupBox groupBoxStaff;
        private System.Windows.Forms.GroupBox groupBoxStaffInformation;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.Panel panelStaffID;
        private System.Windows.Forms.Panel underlineStaffID;
        private System.Windows.Forms.Panel panelStaffName;
        private System.Windows.Forms.Panel underlineStaffName;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel underlinePhone;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCreateStaff;
        private System.Windows.Forms.DataGridView dataGridViewStaffList;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel underlineUsername;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnSetDefaultPassword;
    }
}