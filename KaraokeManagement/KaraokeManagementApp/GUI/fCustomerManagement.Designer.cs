namespace GUI
{
    partial class fCustomerManagement
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
            this.panelCustomerManagement = new System.Windows.Forms.Panel();
            this.panelCustomerInformation = new System.Windows.Forms.Panel();
            this.groupBoxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.btnSetDefaultPassword = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.underlineUsername = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.underlinePhone = new System.Windows.Forms.Panel();
            this.phone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelCustomerName = new System.Windows.Forms.Panel();
            this.underlineCustomerName = new System.Windows.Forms.Panel();
            this.customerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelCustomerList = new System.Windows.Forms.Panel();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomerList = new System.Windows.Forms.DataGridView();
            this.panelCustomerManagement.SuspendLayout();
            this.panelCustomerInformation.SuspendLayout();
            this.groupBoxCustomerInformation.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.panelCustomerName.SuspendLayout();
            this.panelCustomerList.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomerManagement
            // 
            this.panelCustomerManagement.Controls.Add(this.panelCustomerInformation);
            this.panelCustomerManagement.Controls.Add(this.panelCustomerList);
            this.panelCustomerManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerManagement.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerManagement.Name = "panelCustomerManagement";
            this.panelCustomerManagement.Size = new System.Drawing.Size(1344, 761);
            this.panelCustomerManagement.TabIndex = 0;
            // 
            // panelCustomerInformation
            // 
            this.panelCustomerInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCustomerInformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelCustomerInformation.Controls.Add(this.groupBoxCustomerInformation);
            this.panelCustomerInformation.Location = new System.Drawing.Point(918, 12);
            this.panelCustomerInformation.Name = "panelCustomerInformation";
            this.panelCustomerInformation.Size = new System.Drawing.Size(414, 737);
            this.panelCustomerInformation.TabIndex = 1;
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCustomerInformation.Controls.Add(this.btnSetDefaultPassword);
            this.groupBoxCustomerInformation.Controls.Add(this.btnReset2);
            this.groupBoxCustomerInformation.Controls.Add(this.panelUsername);
            this.groupBoxCustomerInformation.Controls.Add(this.panelPhone);
            this.groupBoxCustomerInformation.Controls.Add(this.panelCustomerName);
            this.groupBoxCustomerInformation.Controls.Add(this.btnCreateCustomer);
            this.groupBoxCustomerInformation.Controls.Add(this.btnEditCustomer);
            this.groupBoxCustomerInformation.Controls.Add(this.btnDeleteCustomer);
            this.groupBoxCustomerInformation.Controls.Add(this.btnReset);
            this.groupBoxCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(3, 8);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(408, 726);
            this.groupBoxCustomerInformation.TabIndex = 0;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Thông tin khách hàng";
            // 
            // btnSetDefaultPassword
            // 
            this.btnSetDefaultPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSetDefaultPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSetDefaultPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDefaultPassword.Location = new System.Drawing.Point(3, 498);
            this.btnSetDefaultPassword.Name = "btnSetDefaultPassword";
            this.btnSetDefaultPassword.Size = new System.Drawing.Size(402, 70);
            this.btnSetDefaultPassword.TabIndex = 21;
            this.btnSetDefaultPassword.TabStop = false;
            this.btnSetDefaultPassword.Text = "Đặt lại mật khẩu";
            this.btnSetDefaultPassword.UseVisualStyleBackColor = true;
            this.btnSetDefaultPassword.Visible = false;
            this.btnSetDefaultPassword.Click += new System.EventHandler(this.btnSetDefaultPassword_Click);
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
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.underlineUsername);
            this.panelUsername.Controls.Add(this.username);
            this.panelUsername.Controls.Add(this.lblUsername);
            this.panelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsername.Location = new System.Drawing.Point(3, 140);
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
            this.panelPhone.Location = new System.Drawing.Point(3, 87);
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
            // panelCustomerName
            // 
            this.panelCustomerName.Controls.Add(this.underlineCustomerName);
            this.panelCustomerName.Controls.Add(this.customerName);
            this.panelCustomerName.Controls.Add(this.lblCustomerName);
            this.panelCustomerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerName.Location = new System.Drawing.Point(3, 34);
            this.panelCustomerName.Name = "panelCustomerName";
            this.panelCustomerName.Size = new System.Drawing.Size(402, 53);
            this.panelCustomerName.TabIndex = 2;
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
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCustomer.Location = new System.Drawing.Point(3, 650);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(402, 70);
            this.btnCreateCustomer.TabIndex = 10;
            this.btnCreateCustomer.TabStop = false;
            this.btnCreateCustomer.Text = "Thêm khách hàng";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Location = new System.Drawing.Point(3, 574);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(402, 70);
            this.btnEditCustomer.TabIndex = 11;
            this.btnEditCustomer.TabStop = false;
            this.btnEditCustomer.Text = "Sửa thông tin";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Visible = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(3, 650);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(402, 70);
            this.btnDeleteCustomer.TabIndex = 18;
            this.btnDeleteCustomer.TabStop = false;
            this.btnDeleteCustomer.Text = "Xóa khách hàng";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Visible = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDelete_Click);
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
            // panelCustomerList
            // 
            this.panelCustomerList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCustomerList.Controls.Add(this.groupBoxCustomer);
            this.panelCustomerList.Location = new System.Drawing.Point(12, 12);
            this.panelCustomerList.Name = "panelCustomerList";
            this.panelCustomerList.Size = new System.Drawing.Size(900, 737);
            this.panelCustomerList.TabIndex = 0;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.dataGridViewCustomerList);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(3, 8);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(894, 726);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Danh sách khách hàng";
            // 
            // dataGridViewCustomerList
            // 
            this.dataGridViewCustomerList.AllowUserToAddRows = false;
            this.dataGridViewCustomerList.AllowUserToDeleteRows = false;
            this.dataGridViewCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerList.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewCustomerList.Name = "dataGridViewCustomerList";
            this.dataGridViewCustomerList.ReadOnly = true;
            this.dataGridViewCustomerList.Size = new System.Drawing.Size(882, 686);
            this.dataGridViewCustomerList.TabIndex = 0;
            this.dataGridViewCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffList_CellClick);
            // 
            // fCustomerManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelCustomerManagement);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fCustomerManagement";
            this.Text = "fStaffManagement";
            this.Load += new System.EventHandler(this.fStaffManagement_Load);
            this.panelCustomerManagement.ResumeLayout(false);
            this.panelCustomerInformation.ResumeLayout(false);
            this.groupBoxCustomerInformation.ResumeLayout(false);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.panelCustomerName.ResumeLayout(false);
            this.panelCustomerName.PerformLayout();
            this.panelCustomerList.ResumeLayout(false);
            this.groupBoxCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCustomerManagement;
        private System.Windows.Forms.Panel panelCustomerList;
        private System.Windows.Forms.Panel panelCustomerInformation;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.Panel panelCustomerName;
        private System.Windows.Forms.Panel underlineCustomerName;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel underlinePhone;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomerList;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel underlineUsername;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnSetDefaultPassword;
    }
}