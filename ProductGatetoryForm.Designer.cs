namespace QuanLyCuaHang
{
    partial class ProductGatetoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGatetoryForm));
            this.dgvProductGatetoryOfForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchIDorNameOfProduct = new System.Windows.Forms.TextBox();
            this.lblOfIDorNameProduct = new System.Windows.Forms.Label();
            this.btnFilterDataOfProductGate = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenProductUC = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnResetGrid = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGatetoryOfForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductGatetoryOfForm
            // 
            this.dgvProductGatetoryOfForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductGatetoryOfForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.dgvProductGatetoryOfForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductGatetoryOfForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProductGatetoryOfForm.Location = new System.Drawing.Point(93, 321);
            this.dgvProductGatetoryOfForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProductGatetoryOfForm.Name = "dgvProductGatetoryOfForm";
            this.dgvProductGatetoryOfForm.RowHeadersWidth = 82;
            this.dgvProductGatetoryOfForm.RowTemplate.Height = 33;
            this.dgvProductGatetoryOfForm.Size = new System.Drawing.Size(1079, 410);
            this.dgvProductGatetoryOfForm.TabIndex = 0;
            this.dgvProductGatetoryOfForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductGatetoryOfForm_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhà Cung Cấp";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thể Loại";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 350;
            // 
            // txtSearchIDorNameOfProduct
            // 
            this.txtSearchIDorNameOfProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchIDorNameOfProduct.Location = new System.Drawing.Point(615, 65);
            this.txtSearchIDorNameOfProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchIDorNameOfProduct.Multiline = true;
            this.txtSearchIDorNameOfProduct.Name = "txtSearchIDorNameOfProduct";
            this.txtSearchIDorNameOfProduct.Size = new System.Drawing.Size(353, 37);
            this.txtSearchIDorNameOfProduct.TabIndex = 1;
            // 
            // lblOfIDorNameProduct
            // 
            this.lblOfIDorNameProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOfIDorNameProduct.AutoSize = true;
            this.lblOfIDorNameProduct.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfIDorNameProduct.Location = new System.Drawing.Point(100, 65);
            this.lblOfIDorNameProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOfIDorNameProduct.Name = "lblOfIDorNameProduct";
            this.lblOfIDorNameProduct.Size = new System.Drawing.Size(466, 42);
            this.lblOfIDorNameProduct.TabIndex = 2;
            this.lblOfIDorNameProduct.Text = "Nhập mã hoặc tên sản phẩm";
            // 
            // btnFilterDataOfProductGate
            // 
            this.btnFilterDataOfProductGate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilterDataOfProductGate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.btnFilterDataOfProductGate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterDataOfProductGate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDataOfProductGate.Image = global::QuanLyCuaHang.Properties.Resources.Search;
            this.btnFilterDataOfProductGate.Location = new System.Drawing.Point(829, 161);
            this.btnFilterDataOfProductGate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilterDataOfProductGate.Name = "btnFilterDataOfProductGate";
            this.btnFilterDataOfProductGate.Size = new System.Drawing.Size(267, 74);
            this.btnFilterDataOfProductGate.TabIndex = 3;
            this.btnFilterDataOfProductGate.UseVisualStyleBackColor = false;
            this.btnFilterDataOfProductGate.Click += new System.EventHandler(this.BtnFilterDataOfProductGate_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(615, 17);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(353, 37);
            this.cmbSupplier.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnFilterDataOfProductGate);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.txtSearchIDorNameOfProduct);
            this.panel1.Controls.Add(this.btnOpenProductUC);
            this.panel1.Controls.Add(this.lblOfIDorNameProduct);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnResetGrid);
            this.panel1.Location = new System.Drawing.Point(78, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 252);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, -43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh Mục Sản Phẩm";
            // 
            // btnOpenProductUC
            // 
            this.btnOpenProductUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenProductUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.btnOpenProductUC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenProductUC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProductUC.Image = global::QuanLyCuaHang.Properties.Resources.Add;
            this.btnOpenProductUC.Location = new System.Drawing.Point(12, 161);
            this.btnOpenProductUC.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenProductUC.Name = "btnOpenProductUC";
            this.btnOpenProductUC.Size = new System.Drawing.Size(237, 74);
            this.btnOpenProductUC.TabIndex = 3;
            this.btnOpenProductUC.UseVisualStyleBackColor = false;
            this.btnOpenProductUC.Click += new System.EventHandler(this.btnOpenProductUC_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Image = global::QuanLyCuaHang.Properties.Resources.Delete;
            this.btnDeleteProduct.Location = new System.Drawing.Point(276, 161);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(244, 76);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnResetGrid
            // 
            this.btnResetGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.btnResetGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetGrid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGrid.Image = global::QuanLyCuaHang.Properties.Resources.Update_Left_Rotation;
            this.btnResetGrid.Location = new System.Drawing.Point(547, 159);
            this.btnResetGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetGrid.Name = "btnResetGrid";
            this.btnResetGrid.Size = new System.Drawing.Size(255, 76);
            this.btnResetGrid.TabIndex = 3;
            this.btnResetGrid.UseVisualStyleBackColor = false;
            this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnBack.Image = global::QuanLyCuaHang.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBackToHomePage_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddProduct.BackgroundImage")));
            this.pnlAddProduct.Location = new System.Drawing.Point(1203, 21);
            this.pnlAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(667, 448);
            this.pnlAddProduct.TabIndex = 6;
            // 
            // ProductGatetoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvProductGatetoryOfForm);
            this.Controls.Add(this.pnlAddProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ProductGatetoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sản Phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductGatetoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGatetoryOfForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductGatetoryOfForm;
        private System.Windows.Forms.TextBox txtSearchIDorNameOfProduct;
        private System.Windows.Forms.Label lblOfIDorNameProduct;
        private System.Windows.Forms.Button btnFilterDataOfProductGate;
        private System.Windows.Forms.Button btnResetGrid;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenProductUC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
    }
}