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
            this.btnResetGrid = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenProductUC = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGatetoryOfForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductGatetoryOfForm
            // 
            this.dgvProductGatetoryOfForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductGatetoryOfForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductGatetoryOfForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProductGatetoryOfForm.Location = new System.Drawing.Point(222, 294);
            this.dgvProductGatetoryOfForm.Name = "dgvProductGatetoryOfForm";
            this.dgvProductGatetoryOfForm.RowHeadersWidth = 82;
            this.dgvProductGatetoryOfForm.RowTemplate.Height = 33;
            this.dgvProductGatetoryOfForm.Size = new System.Drawing.Size(939, 382);
            this.dgvProductGatetoryOfForm.TabIndex = 0;
            this.dgvProductGatetoryOfForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductGatetoryOfForm_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhà Cung Cấp";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thể Loại";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // txtSearchIDorNameOfProduct
            // 
            this.txtSearchIDorNameOfProduct.Location = new System.Drawing.Point(564, 121);
            this.txtSearchIDorNameOfProduct.Multiline = true;
            this.txtSearchIDorNameOfProduct.Name = "txtSearchIDorNameOfProduct";
            this.txtSearchIDorNameOfProduct.Size = new System.Drawing.Size(228, 49);
            this.txtSearchIDorNameOfProduct.TabIndex = 1;
            // 
            // lblOfIDorNameProduct
            // 
            this.lblOfIDorNameProduct.AutoSize = true;
            this.lblOfIDorNameProduct.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfIDorNameProduct.Location = new System.Drawing.Point(170, 138);
            this.lblOfIDorNameProduct.Name = "lblOfIDorNameProduct";
            this.lblOfIDorNameProduct.Size = new System.Drawing.Size(361, 32);
            this.lblOfIDorNameProduct.TabIndex = 2;
            this.lblOfIDorNameProduct.Text = "Nhập mã hoặc tên sản phẩm";
            // 
            // btnFilterDataOfProductGate
            // 
            this.btnFilterDataOfProductGate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFilterDataOfProductGate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilterDataOfProductGate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDataOfProductGate.Location = new System.Drawing.Point(960, 222);
            this.btnFilterDataOfProductGate.Name = "btnFilterDataOfProductGate";
            this.btnFilterDataOfProductGate.Size = new System.Drawing.Size(172, 49);
            this.btnFilterDataOfProductGate.TabIndex = 3;
            this.btnFilterDataOfProductGate.Text = "Lọc";
            this.btnFilterDataOfProductGate.UseVisualStyleBackColor = false;
            this.btnFilterDataOfProductGate.Click += new System.EventHandler(this.BtnFilterDataOfProductGate_Click);
            // 
            // btnResetGrid
            // 
            this.btnResetGrid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResetGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetGrid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGrid.Location = new System.Drawing.Point(716, 222);
            this.btnResetGrid.Name = "btnResetGrid";
            this.btnResetGrid.Size = new System.Drawing.Size(172, 49);
            this.btnResetGrid.TabIndex = 3;
            this.btnResetGrid.Text = "Làm Mới";
            this.btnResetGrid.UseVisualStyleBackColor = false;
            this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(549, 42);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(275, 33);
            this.cmbSupplier.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn nhà cung cấp";
            // 
            // btnOpenProductUC
            // 
            this.btnOpenProductUC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOpenProductUC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenProductUC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProductUC.Location = new System.Drawing.Point(103, 209);
            this.btnOpenProductUC.Name = "btnOpenProductUC";
            this.btnOpenProductUC.Size = new System.Drawing.Size(283, 49);
            this.btnOpenProductUC.TabIndex = 3;
            this.btnOpenProductUC.Text = "Thêm Sản Phẩm";
            this.btnOpenProductUC.UseVisualStyleBackColor = false;
            this.btnOpenProductUC.Click += new System.EventHandler(this.btnOpenProductUC_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBackToHomePage_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddProduct.BackgroundImage")));
            this.pnlAddProduct.Location = new System.Drawing.Point(1055, 28);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(800, 500);
            this.pnlAddProduct.TabIndex = 6;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(465, 222);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(172, 49);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // ProductGatetoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.pnlAddProduct);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.btnOpenProductUC);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnResetGrid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFilterDataOfProductGate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOfIDorNameProduct);
            this.Controls.Add(this.txtSearchIDorNameOfProduct);
            this.Controls.Add(this.dgvProductGatetoryOfForm);
            this.Name = "ProductGatetoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.ProductGatetoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGatetoryOfForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductGatetoryOfForm;
        private System.Windows.Forms.TextBox txtSearchIDorNameOfProduct;
        private System.Windows.Forms.Label lblOfIDorNameProduct;
        private System.Windows.Forms.Button btnFilterDataOfProductGate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnResetGrid;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenProductUC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}