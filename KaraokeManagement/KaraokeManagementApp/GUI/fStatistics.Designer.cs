namespace GUI
{
    partial class fStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.panelBillList = new System.Windows.Forms.Panel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.dataGridViewBillList = new System.Windows.Forms.DataGridView();
            this.panelControlTime = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.toTime = new System.Windows.Forms.Label();
            this.dateTimePickerTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTimeStart = new System.Windows.Forms.DateTimePicker();
            this.fromTime = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.NumericUpDown();
            this.panelStatistics.SuspendLayout();
            this.panelBillList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillList)).BeginInit();
            this.panelControlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.panelBillList);
            this.panelStatistics.Controls.Add(this.panelControlTime);
            this.panelStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistics.Location = new System.Drawing.Point(0, 0);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(1344, 761);
            this.panelStatistics.TabIndex = 0;
            // 
            // panelBillList
            // 
            this.panelBillList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBillList.Controls.Add(this.page);
            this.panelBillList.Controls.Add(this.btnNextPage);
            this.panelBillList.Controls.Add(this.btnPreviousPage);
            this.panelBillList.Controls.Add(this.btnLastPage);
            this.panelBillList.Controls.Add(this.btnFirstPage);
            this.panelBillList.Controls.Add(this.dataGridViewBillList);
            this.panelBillList.Location = new System.Drawing.Point(12, 80);
            this.panelBillList.Name = "panelBillList";
            this.panelBillList.Size = new System.Drawing.Size(1320, 669);
            this.panelBillList.TabIndex = 3;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Enabled = false;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(724, 606);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(180, 60);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.TabStop = false;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Enabled = false;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.Location = new System.Drawing.Point(380, 606);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(180, 60);
            this.btnPreviousPage.TabIndex = 7;
            this.btnPreviousPage.TabStop = false;
            this.btnPreviousPage.Text = "Trang trước";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Enabled = false;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.Location = new System.Drawing.Point(1162, 606);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(155, 60);
            this.btnLastPage.TabIndex = 5;
            this.btnLastPage.TabStop = false;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Enabled = false;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.Location = new System.Drawing.Point(3, 606);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(155, 60);
            this.btnFirstPage.TabIndex = 4;
            this.btnFirstPage.TabStop = false;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // dataGridViewBillList
            // 
            this.dataGridViewBillList.AllowUserToAddRows = false;
            this.dataGridViewBillList.AllowUserToDeleteRows = false;
            this.dataGridViewBillList.AllowUserToResizeRows = false;
            this.dataGridViewBillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBillList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBillList.Name = "dataGridViewBillList";
            this.dataGridViewBillList.ReadOnly = true;
            this.dataGridViewBillList.Size = new System.Drawing.Size(1314, 597);
            this.dataGridViewBillList.TabIndex = 0;
            // 
            // panelControlTime
            // 
            this.panelControlTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControlTime.Controls.Add(this.btnStatistics);
            this.panelControlTime.Controls.Add(this.toTime);
            this.panelControlTime.Controls.Add(this.dateTimePickerTimeEnd);
            this.panelControlTime.Controls.Add(this.dateTimePickerTimeStart);
            this.panelControlTime.Controls.Add(this.fromTime);
            this.panelControlTime.Location = new System.Drawing.Point(12, 12);
            this.panelControlTime.Name = "panelControlTime";
            this.panelControlTime.Size = new System.Drawing.Size(1320, 62);
            this.panelControlTime.TabIndex = 2;
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(551, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(180, 60);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.TabStop = false;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // toTime
            // 
            this.toTime.AutoSize = true;
            this.toTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTime.Location = new System.Drawing.Point(866, 15);
            this.toTime.Name = "toTime";
            this.toTime.Size = new System.Drawing.Size(64, 31);
            this.toTime.TabIndex = 4;
            this.toTime.Text = "Đến";
            // 
            // dateTimePickerTimeEnd
            // 
            this.dateTimePickerTimeEnd.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeEnd.Location = new System.Drawing.Point(994, 13);
            this.dateTimePickerTimeEnd.Name = "dateTimePickerTimeEnd";
            this.dateTimePickerTimeEnd.Size = new System.Drawing.Size(159, 38);
            this.dateTimePickerTimeEnd.TabIndex = 3;
            this.dateTimePickerTimeEnd.TabStop = false;
            this.dateTimePickerTimeEnd.ValueChanged += new System.EventHandler(this.dateTimePickerTimeEnd_ValueChanged);
            // 
            // dateTimePickerTimeStart
            // 
            this.dateTimePickerTimeStart.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeStart.Location = new System.Drawing.Point(253, 13);
            this.dateTimePickerTimeStart.Name = "dateTimePickerTimeStart";
            this.dateTimePickerTimeStart.Size = new System.Drawing.Size(159, 38);
            this.dateTimePickerTimeStart.TabIndex = 2;
            this.dateTimePickerTimeStart.TabStop = false;
            this.dateTimePickerTimeStart.ValueChanged += new System.EventHandler(this.dateTimePickerTimeStart_ValueChanged);
            // 
            // fromTime
            // 
            this.fromTime.AutoSize = true;
            this.fromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTime.Location = new System.Drawing.Point(147, 15);
            this.fromTime.Name = "fromTime";
            this.fromTime.Size = new System.Drawing.Size(46, 31);
            this.fromTime.TabIndex = 1;
            this.fromTime.Text = "Từ";
            // 
            // page
            // 
            this.page.Enabled = false;
            this.page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page.InterceptArrowKeys = false;
            this.page.Location = new System.Drawing.Point(591, 619);
            this.page.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(100, 38);
            this.page.TabIndex = 9;
            this.page.TabStop = false;
            this.page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.page.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.page.ValueChanged += new System.EventHandler(this.page_ValueChanged);
            // 
            // fStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 761);
            this.Controls.Add(this.panelStatistics);
            this.MaximumSize = new System.Drawing.Size(1602, 800);
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "fStatistics";
            this.Text = "fStatistics";
            this.Load += new System.EventHandler(this.fStatistics_Load);
            this.panelStatistics.ResumeLayout(false);
            this.panelBillList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillList)).EndInit();
            this.panelControlTime.ResumeLayout(false);
            this.panelControlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Panel panelControlTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeStart;
        private System.Windows.Forms.Label fromTime;
        private System.Windows.Forms.Panel panelBillList;
        private System.Windows.Forms.DataGridView dataGridViewBillList;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeEnd;
        private System.Windows.Forms.Label toTime;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.NumericUpDown page;
    }
}