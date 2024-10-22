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
            this.bttFind = new System.Windows.Forms.Button();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerPhoneNumer = new System.Windows.Forms.TextBox();
            this.txtSoHD = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.bttFind);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.txtCustomerPhoneNumer);
            this.groupBox1.Controls.Add(this.txtSoHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(453, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // bttRefresh
            // 
            this.bttRefresh.Location = new System.Drawing.Point(219, 242);
            this.bttRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(195, 53);
            this.bttRefresh.TabIndex = 3;
            this.bttRefresh.Text = "Làm mới";
            this.bttRefresh.UseVisualStyleBackColor = true;
            // 
            // bttFind
            // 
            this.bttFind.Location = new System.Drawing.Point(14, 242);
            this.bttFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttFind.Name = "bttFind";
            this.bttFind.Size = new System.Drawing.Size(176, 53);
            this.bttFind.TabIndex = 3;
            this.bttFind.Text = "Tìm";
            this.bttFind.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(184, 183);
            this.dateTimePickerNgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(250, 31);
            this.dateTimePickerNgayLap.TabIndex = 2;
            // 
            // txtCustomerPhoneNumer
            // 
            this.txtCustomerPhoneNumer.Location = new System.Drawing.Point(184, 106);
            this.txtCustomerPhoneNumer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerPhoneNumer.Name = "txtCustomerPhoneNumer";
            this.txtCustomerPhoneNumer.Size = new System.Drawing.Size(252, 31);
            this.txtCustomerPhoneNumer.TabIndex = 1;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(184, 50);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(252, 31);
            this.txtSoHD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "SDT Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // dvgListHoaDon
            // 
            this.dvgListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListHoaDon.Location = new System.Drawing.Point(496, 63);
            this.dvgListHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgListHoaDon.Name = "dvgListHoaDon";
            this.dvgListHoaDon.RowHeadersWidth = 51;
            this.dvgListHoaDon.RowTemplate.Height = 24;
            this.dvgListHoaDon.Size = new System.Drawing.Size(1172, 886);
            this.dvgListHoaDon.TabIndex = 2;
            this.dvgListHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListHoaDon_CellContentClick);
            // 
            // BillListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgListHoaDon);
            this.Name = "BillListUC";
            this.Size = new System.Drawing.Size(1702, 1012);
            this.Load += new System.EventHandler(this.BillListUC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttRefresh;
        private System.Windows.Forms.Button bttFind;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumer;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgListHoaDon;
    }
}
