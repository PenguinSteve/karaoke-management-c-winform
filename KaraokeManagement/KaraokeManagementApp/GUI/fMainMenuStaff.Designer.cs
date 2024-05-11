namespace GUI
{
    partial class fMainMenuStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainMenuStaff));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.titleHeading = new System.Windows.Forms.Label();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.roleName = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.btnOrderService = new System.Windows.Forms.Button();
            this.btnAccountInfomation = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelHeading.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(300, 100);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildForm.MaximumSize = new System.Drawing.Size(1602, 800);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(1360, 800);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1360, 800);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Tag = "asd";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 300);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(300, 100);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 10;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1243, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 100);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1126, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(117, 100);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 100);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.titleHeading);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(201, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(925, 100);
            this.panelTitle.TabIndex = 4;
            // 
            // titleHeading
            // 
            this.titleHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeading.ForeColor = System.Drawing.Color.White;
            this.titleHeading.Location = new System.Drawing.Point(0, 0);
            this.titleHeading.Margin = new System.Windows.Forms.Padding(0);
            this.titleHeading.Name = "titleHeading";
            this.titleHeading.Size = new System.Drawing.Size(925, 100);
            this.titleHeading.TabIndex = 0;
            this.titleHeading.Text = "Trang chủ";
            this.titleHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelHeading.Controls.Add(this.panelTitle);
            this.panelHeading.Controls.Add(this.btnHome);
            this.panelHeading.Controls.Add(this.btnMinimize);
            this.panelHeading.Controls.Add(this.btnClose);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(300, 0);
            this.panelHeading.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeading.MaximumSize = new System.Drawing.Size(1602, 100);
            this.panelHeading.MinimumSize = new System.Drawing.Size(1360, 100);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(1360, 100);
            this.panelHeading.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnOrderService);
            this.panelMenu.Controls.Add(this.btnAccountInfomation);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.MaximumSize = new System.Drawing.Size(300, 900);
            this.panelMenu.MinimumSize = new System.Drawing.Size(58, 900);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 900);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.roleName);
            this.panelLogo.Controls.Add(this.accountName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(57, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(55, 100);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // roleName
            // 
            this.roleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleName.ForeColor = System.Drawing.Color.White;
            this.roleName.Location = new System.Drawing.Point(60, 20);
            this.roleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleName.Name = "roleName";
            this.roleName.Size = new System.Drawing.Size(232, 40);
            this.roleName.TabIndex = 2;
            this.roleName.Text = "Nhân viên phục vụ";
            this.roleName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accountName
            // 
            this.accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.ForeColor = System.Drawing.Color.White;
            this.accountName.Location = new System.Drawing.Point(78, 60);
            this.accountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(181, 24);
            this.accountName.TabIndex = 3;
            this.accountName.Text = "Tên nhân viên";
            this.accountName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnOrderService
            // 
            this.btnOrderService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderService.FlatAppearance.BorderSize = 0;
            this.btnOrderService.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnOrderService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOrderService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnOrderService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderService.ForeColor = System.Drawing.Color.White;
            this.btnOrderService.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderService.Image")));
            this.btnOrderService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderService.Location = new System.Drawing.Point(0, 100);
            this.btnOrderService.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderService.Name = "btnOrderService";
            this.btnOrderService.Size = new System.Drawing.Size(300, 100);
            this.btnOrderService.TabIndex = 3;
            this.btnOrderService.TabStop = false;
            this.btnOrderService.Text = "Đặt dịch vụ";
            this.btnOrderService.UseVisualStyleBackColor = true;
            this.btnOrderService.Click += new System.EventHandler(this.btnOrderService_Click);
            // 
            // btnAccountInfomation
            // 
            this.btnAccountInfomation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountInfomation.FlatAppearance.BorderSize = 0;
            this.btnAccountInfomation.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAccountInfomation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAccountInfomation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.btnAccountInfomation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountInfomation.ForeColor = System.Drawing.Color.White;
            this.btnAccountInfomation.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountInfomation.Image")));
            this.btnAccountInfomation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountInfomation.Location = new System.Drawing.Point(0, 200);
            this.btnAccountInfomation.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccountInfomation.Name = "btnAccountInfomation";
            this.btnAccountInfomation.Size = new System.Drawing.Size(300, 100);
            this.btnAccountInfomation.TabIndex = 7;
            this.btnAccountInfomation.TabStop = false;
            this.btnAccountInfomation.Text = "Thông tin tài khoản";
            this.btnAccountInfomation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountInfomation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountInfomation.UseVisualStyleBackColor = true;
            this.btnAccountInfomation.Click += new System.EventHandler(this.btnAccountInfomation_Click);
            // 
            // fMainMenuStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1660, 900);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelHeading);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1660, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1660, 900);
            this.Name = "fMainMenuStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuAdmin";
            this.panelTitle.ResumeLayout(false);
            this.panelHeading.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label titleHeading;
        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label roleName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrderService;
        private System.Windows.Forms.Button btnAccountInfomation;
    }
}