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
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttAddProduct = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.bttPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgXuatHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(891, 404);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(259, 50);
            this.lblTongTien.TabIndex = 14;
            // 
            // dvgXuatHoaDon
            // 
            this.dvgXuatHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dvgXuatHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgXuatHoaDon.Location = new System.Drawing.Point(39, 33);
            this.dvgXuatHoaDon.Name = "dvgXuatHoaDon";
            this.dvgXuatHoaDon.RowHeadersWidth = 51;
            this.dvgXuatHoaDon.RowTemplate.Height = 24;
            this.dvgXuatHoaDon.ShowEditingIcon = false;
            this.dvgXuatHoaDon.Size = new System.Drawing.Size(1093, 350);
            this.dvgXuatHoaDon.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(415, 100);
            this.numericUpDownSoLuong.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(56, 28);
            this.numericUpDownSoLuong.TabIndex = 5;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(415, 58);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(263, 28);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.Text = "Sản Phẩm";
            // 
            // cmbProductType
            // 
            this.cmbProductType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(415, 10);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(263, 28);
            this.cmbProductType.TabIndex = 2;
            this.cmbProductType.Text = "Loại Sản Phẩm";
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(213, 16);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(196, 22);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "SĐT Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.bttAddProduct);
            this.groupBox1.Controls.Add(this.numericUpDownSoLuong);
            this.groupBox1.Controls.Add(this.cmbPaymentMethod);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.cmbProductType);
            this.groupBox1.Location = new System.Drawing.Point(39, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 159);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hình thức thanh toán";
            // 
            // bttAddProduct
            // 
            this.bttAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttAddProduct.Image = global::QuanLyCuaHang.Properties.Resources.Add5;
            this.bttAddProduct.Location = new System.Drawing.Point(586, 88);
            this.bttAddProduct.Name = "bttAddProduct";
            this.bttAddProduct.Size = new System.Drawing.Size(92, 60);
            this.bttAddProduct.TabIndex = 6;
            this.bttAddProduct.UseVisualStyleBackColor = true;
            this.bttAddProduct.Click += new System.EventHandler(this.bttAddProduct_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(213, 63);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(196, 28);
            this.cmbPaymentMethod.TabIndex = 3;
            // 
            // bttPay
            // 
            this.bttPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttPay.Image = global::QuanLyCuaHang.Properties.Resources.Cash_in_Hand;
            this.bttPay.Location = new System.Drawing.Point(925, 487);
            this.bttPay.Name = "bttPay";
            this.bttPay.Size = new System.Drawing.Size(171, 55);
            this.bttPay.TabIndex = 7;
            this.bttPay.UseVisualStyleBackColor = true;
            this.bttPay.Click += new System.EventHandler(this.bttPay_Click);
            // 
            // OutputBillUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dvgXuatHoaDon);
            this.Controls.Add(this.bttPay);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OutputBillUC";
            this.Size = new System.Drawing.Size(1188, 581);
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
        private System.Windows.Forms.Button bttAddProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Button bttPay;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
    }
}
