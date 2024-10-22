namespace QuanLyCuaHang.UserControls
{
    partial class OutputBillUC
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
            this.components = new System.ComponentModel.Container();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dvgXuatHoaDon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bttThemMon = new System.Windows.Forms.Button();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.bttThanhToan = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgXuatHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(1336, 632);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(388, 78);
            this.lblTongTien.TabIndex = 14;
            // 
            // dvgXuatHoaDon
            // 
            this.dvgXuatHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgXuatHoaDon.Location = new System.Drawing.Point(59, 51);
            this.dvgXuatHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgXuatHoaDon.Name = "dvgXuatHoaDon";
            this.dvgXuatHoaDon.RowHeadersWidth = 51;
            this.dvgXuatHoaDon.RowTemplate.Height = 24;
            this.dvgXuatHoaDon.ShowEditingIcon = false;
            this.dvgXuatHoaDon.Size = new System.Drawing.Size(1640, 547);
            this.dvgXuatHoaDon.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bttThemMon
            // 
            this.bttThemMon.Location = new System.Drawing.Point(758, 139);
            this.bttThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttThemMon.Name = "bttThemMon";
            this.bttThemMon.Size = new System.Drawing.Size(260, 66);
            this.bttThemMon.TabIndex = 6;
            this.bttThemMon.Text = "Thêm móm";
            this.bttThemMon.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(622, 156);
            this.numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(84, 31);
            this.numericUpDownSoLuong.TabIndex = 5;
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Location = new System.Drawing.Point(622, 91);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(392, 33);
            this.cbbSanPham.TabIndex = 4;
            this.cbbSanPham.Text = "Sản Phẩm";
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(622, 16);
            this.cbbLoaiSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(392, 33);
            this.cbbLoaiSP.TabIndex = 4;
            this.cbbLoaiSP.Text = "Loại Sản Phẩm";
            // 
            // bttThanhToan
            // 
            this.bttThanhToan.Location = new System.Drawing.Point(1327, 759);
            this.bttThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttThanhToan.Name = "bttThanhToan";
            this.bttThanhToan.Size = new System.Drawing.Size(370, 61);
            this.bttThanhToan.TabIndex = 15;
            this.bttThanhToan.Text = "Thanh Toán";
            this.bttThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(222, 19);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(292, 31);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "SĐT Khách Hàng";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(222, 91);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(292, 31);
            this.txtCustomerName.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.bttThemMon);
            this.groupBox1.Controls.Add(this.numericUpDownSoLuong);
            this.groupBox1.Controls.Add(this.cbbSanPham);
            this.groupBox1.Controls.Add(this.cbbLoaiSP);
            this.groupBox1.Location = new System.Drawing.Point(59, 632);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1059, 225);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // OutputBillUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dvgXuatHoaDon);
            this.Controls.Add(this.bttThanhToan);
            this.Controls.Add(this.groupBox1);
            this.Name = "OutputBillUC";
            this.Size = new System.Drawing.Size(1782, 908);
            this.Load += new System.EventHandler(this.OutputBillUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgXuatHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dvgXuatHoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttThemMon;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.Button bttThanhToan;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
