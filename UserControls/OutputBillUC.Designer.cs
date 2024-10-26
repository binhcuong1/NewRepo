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
            this.btnCancelProduct = new System.Windows.Forms.Button();
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
            this.lblTongTien.Location = new System.Drawing.Point(1336, 631);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(388, 78);
            this.lblTongTien.TabIndex = 14;
            // 
            // dvgXuatHoaDon
            // 
            this.dvgXuatHoaDon.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dvgXuatHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgXuatHoaDon.Location = new System.Drawing.Point(58, 52);
            this.dvgXuatHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgXuatHoaDon.Name = "dvgXuatHoaDon";
            this.dvgXuatHoaDon.RowHeadersWidth = 51;
            this.dvgXuatHoaDon.RowTemplate.Height = 24;
            this.dvgXuatHoaDon.ShowEditingIcon = false;
            this.dvgXuatHoaDon.Size = new System.Drawing.Size(1640, 547);
            this.dvgXuatHoaDon.TabIndex = 13;
            this.dvgXuatHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgXuatHoaDon_CellContentClick);
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
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(639, 164);
            this.numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(84, 41);
            this.numericUpDownSoLuong.TabIndex = 5;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(636, 86);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(392, 40);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.Text = "Sản Phẩm";
            // 
            // cmbProductType
            // 
            this.cmbProductType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(636, 25);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(392, 40);
            this.cmbProductType.TabIndex = 2;
            this.cmbProductType.Text = "Loại Sản Phẩm";
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(320, 25);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(292, 38);
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
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "SĐT Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.btnCancelProduct);
            this.groupBox1.Controls.Add(this.bttAddProduct);
            this.groupBox1.Controls.Add(this.numericUpDownSoLuong);
            this.groupBox1.Controls.Add(this.cmbPaymentMethod);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.cmbProductType);
            this.groupBox1.Location = new System.Drawing.Point(58, 631);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1059, 248);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hình thức thanh toán";
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelProduct.Image = global::QuanLyCuaHang.Properties.Resources.Delete;
            this.btnCancelProduct.Location = new System.Drawing.Point(732, 138);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(138, 94);
            this.btnCancelProduct.TabIndex = 6;
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // bttAddProduct
            // 
            this.bttAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttAddProduct.Image = global::QuanLyCuaHang.Properties.Resources.Add5;
            this.bttAddProduct.Location = new System.Drawing.Point(879, 138);
            this.bttAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttAddProduct.Name = "bttAddProduct";
            this.bttAddProduct.Size = new System.Drawing.Size(138, 94);
            this.bttAddProduct.TabIndex = 6;
            this.bttAddProduct.UseVisualStyleBackColor = true;
            this.bttAddProduct.Click += new System.EventHandler(this.bttAddProduct_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(320, 86);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(292, 40);
            this.cmbPaymentMethod.TabIndex = 3;
            // 
            // bttPay
            // 
            this.bttPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttPay.Image = global::QuanLyCuaHang.Properties.Resources.Cash_in_Hand;
            this.bttPay.Location = new System.Drawing.Point(1388, 761);
            this.bttPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttPay.Name = "bttPay";
            this.bttPay.Size = new System.Drawing.Size(256, 86);
            this.bttPay.TabIndex = 7;
            this.bttPay.UseVisualStyleBackColor = true;
            this.bttPay.Click += new System.EventHandler(this.bttPay_Click);
            // 
            // OutputBillUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dvgXuatHoaDon);
            this.Controls.Add(this.bttPay);
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
        private System.Windows.Forms.Button btnCancelProduct;
    }
}
