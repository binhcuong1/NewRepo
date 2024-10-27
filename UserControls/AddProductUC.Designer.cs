namespace QuanLyCuaHang
{
    partial class AddProductUC
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnBackToProductGateFrm = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(438, 172);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(437, 49);
            this.txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Tên Sản Phẩm";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(438, 275);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(437, 49);
            this.txtPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Đơn Giá";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(438, 375);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(530, 50);
            this.cmbSupplier.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn Thể Loại";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(438, 471);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(530, 50);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnBackToProductGateFrm
            // 
            this.btnBackToProductGateFrm.BackColor = System.Drawing.Color.White;
            this.btnBackToProductGateFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToProductGateFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProductGateFrm.ForeColor = System.Drawing.Color.White;
            this.btnBackToProductGateFrm.Image = global::QuanLyCuaHang.Properties.Resources.Cancel5;
            this.btnBackToProductGateFrm.Location = new System.Drawing.Point(3, 0);
            this.btnBackToProductGateFrm.Name = "btnBackToProductGateFrm";
            this.btnBackToProductGateFrm.Size = new System.Drawing.Size(110, 73);
            this.btnBackToProductGateFrm.TabIndex = 0;
            this.btnBackToProductGateFrm.UseVisualStyleBackColor = false;
            this.btnBackToProductGateFrm.Click += new System.EventHandler(this.btnBackToProductGateFrm_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::QuanLyCuaHang.Properties.Resources.Add3;
            this.btnAddProduct.Location = new System.Drawing.Point(386, 573);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(222, 84);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.Remove_bg8;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(704, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 156);
            this.panel1.TabIndex = 17;
            // 
            // AddProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToProductGateFrm);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnAddProduct);
            this.DoubleBuffered = true;
            this.Name = "AddProductUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.AddProductUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnBackToProductGateFrm;
        private System.Windows.Forms.Panel panel1;
    }
}
