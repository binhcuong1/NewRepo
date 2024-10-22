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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttRefresh);
            this.groupBox1.Controls.Add(this.bttSearch);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.txtCustomerPhoneNumer);
            this.groupBox1.Controls.Add(this.txtBillID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // bttRefresh
            // 
            this.bttRefresh.Location = new System.Drawing.Point(146, 155);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(130, 34);
            this.bttRefresh.TabIndex = 3;
            this.bttRefresh.Text = "Làm mới";
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(9, 155);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(117, 34);
            this.bttSearch.TabIndex = 3;
            this.bttSearch.Text = "Tìm";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(123, 117);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(168, 22);
            this.dateTimePickerNgayLap.TabIndex = 2;
            this.dateTimePickerNgayLap.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLap_ValueChanged);
            // 
            // txtCustomerPhoneNumer
            // 
            this.txtCustomerPhoneNumer.Location = new System.Drawing.Point(123, 68);
            this.txtCustomerPhoneNumer.Name = "txtCustomerPhoneNumer";
            this.txtCustomerPhoneNumer.Size = new System.Drawing.Size(169, 22);
            this.txtCustomerPhoneNumer.TabIndex = 1;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(123, 32);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(169, 22);
            this.txtBillID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "SDT Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // dvgListHoaDon
            // 
            this.dvgListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListHoaDon.Location = new System.Drawing.Point(331, 40);
            this.dvgListHoaDon.Name = "dvgListHoaDon";
            this.dvgListHoaDon.RowHeadersWidth = 51;
            this.dvgListHoaDon.RowTemplate.Height = 24;
            this.dvgListHoaDon.Size = new System.Drawing.Size(781, 567);
            this.dvgListHoaDon.TabIndex = 2;
            this.dvgListHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListHoaDon_CellContentClick);
            // 
            // BillListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgListHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillListUC";
            this.Size = new System.Drawing.Size(1135, 648);
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
    }
}
