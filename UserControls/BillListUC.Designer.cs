namespace QuanLyCuaHang.UserControls
{
    partial class BillListUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttRefresh = new System.Windows.Forms.Button();
            this.bttSearch = new System.Windows.Forms.Button();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerPhoneNumer = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgListHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToProductGateFrm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bttRefresh);
            this.groupBox1.Controls.Add(this.bttSearch);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.txtCustomerPhoneNumer);
            this.groupBox1.Controls.Add(this.txtBillID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(575, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // bttRefresh
            // 
            this.bttRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttRefresh.Image = global::QuanLyCuaHang.Properties.Resources.Update_Left_Rotation2;
            this.bttRefresh.Location = new System.Drawing.Point(352, 236);
            this.bttRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(114, 92);
            this.bttRefresh.TabIndex = 5;
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // bttSearch
            // 
            this.bttSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttSearch.Image = global::QuanLyCuaHang.Properties.Resources.Search2;
            this.bttSearch.Location = new System.Drawing.Point(110, 236);
            this.bttSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(94, 94);
            this.bttSearch.TabIndex = 4;
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayLap.CalendarFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(280, 183);
            this.dateTimePickerNgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(301, 41);
            this.dateTimePickerNgayLap.TabIndex = 3;
            this.dateTimePickerNgayLap.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLap_ValueChanged);
            // 
            // txtCustomerPhoneNumer
            // 
            this.txtCustomerPhoneNumer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerPhoneNumer.Location = new System.Drawing.Point(280, 125);
            this.txtCustomerPhoneNumer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerPhoneNumer.Name = "txtCustomerPhoneNumer";
            this.txtCustomerPhoneNumer.Size = new System.Drawing.Size(302, 31);
            this.txtCustomerPhoneNumer.TabIndex = 2;
            // 
            // txtBillID
            // 
            this.txtBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBillID.Location = new System.Drawing.Point(279, 62);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(304, 31);
            this.txtBillID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "SDT Khách Hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // dvgListHoaDon
            // 
            this.dvgListHoaDon.AllowUserToAddRows = false;
            this.dvgListHoaDon.AllowUserToDeleteRows = false;
            this.dvgListHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dvgListHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dvgListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListHoaDon.Location = new System.Drawing.Point(664, 78);
            this.dvgListHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgListHoaDon.Name = "dvgListHoaDon";
            this.dvgListHoaDon.ReadOnly = true;
            this.dvgListHoaDon.RowHeadersWidth = 51;
            this.dvgListHoaDon.RowTemplate.Height = 24;
            this.dvgListHoaDon.Size = new System.Drawing.Size(1227, 886);
            this.dvgListHoaDon.TabIndex = 2;
            this.dvgListHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListHoaDon_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.Remove_bg7;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(184, 557);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 348);
            this.panel1.TabIndex = 4;
            // 
            // btnBackToProductGateFrm
            // 
            this.btnBackToProductGateFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToProductGateFrm.BackColor = System.Drawing.Color.White;
            this.btnBackToProductGateFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToProductGateFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProductGateFrm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackToProductGateFrm.Image = global::QuanLyCuaHang.Properties.Resources.Cancel6;
            this.btnBackToProductGateFrm.Location = new System.Drawing.Point(1827, 3);
            this.btnBackToProductGateFrm.Name = "btnBackToProductGateFrm";
            this.btnBackToProductGateFrm.Size = new System.Drawing.Size(90, 73);
            this.btnBackToProductGateFrm.TabIndex = 38;
            this.btnBackToProductGateFrm.UseVisualStyleBackColor = false;
            this.btnBackToProductGateFrm.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BillListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBackToProductGateFrm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgListHoaDon);
            this.Name = "BillListUC";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.BillListUC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttRefresh;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumer;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgListHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackToProductGateFrm;
    }
}
