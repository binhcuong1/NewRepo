namespace QuanLyCuaHang
{
    partial class SaleForm
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
            this.txtSaleName = new System.Windows.Forms.TextBox();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchSale = new System.Windows.Forms.Button();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProductID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetGrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaleName
            // 
            this.txtSaleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleName.Location = new System.Drawing.Point(373, 445);
            this.txtSaleName.Name = "txtSaleName";
            this.txtSaleName.Size = new System.Drawing.Size(307, 30);
            this.txtSaleName.TabIndex = 1;
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSale.Location = new System.Drawing.Point(159, -5);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.Size = new System.Drawing.Size(1074, 408);
            this.dgvSale.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Khuyến Mãi";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 320;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sản Phẩm Áp Dụng";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mức Giá Khuyến Mãi";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Bắt Đầu ";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Kết Thúc";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(180, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Khuyến Mãi";
            // 
            // btnSearchSale
            // 
            this.btnSearchSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSale.Location = new System.Drawing.Point(841, 425);
            this.btnSearchSale.Name = "btnSearchSale";
            this.btnSearchSale.Size = new System.Drawing.Size(353, 34);
            this.btnSearchSale.TabIndex = 4;
            this.btnSearchSale.Text = "Tìm Khuyến Mãi Theo Sản Phẩm";
            this.btnSearchSale.UseVisualStyleBackColor = true;
            this.btnSearchSale.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Location = new System.Drawing.Point(298, 623);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(349, 30);
            this.dtNgayKetThuc.TabIndex = 25;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Location = new System.Drawing.Point(331, 563);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(349, 30);
            this.dtNgayBatDau.TabIndex = 24;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(971, 541);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(200, 30);
            this.txtSalePrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(747, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mức Giá Khuyến Mãi";
            // 
            // cmbProductID
            // 
            this.cmbProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.Location = new System.Drawing.Point(373, 501);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(307, 33);
            this.cmbProductID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(162, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(151, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(162, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày Bắt Đầu";
            // 
            // btnResetGrid
            // 
            this.btnResetGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnResetGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetGrid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnResetGrid.Image = global::QuanLyCuaHang.Properties.Resources.Update_Left_Rotation;
            this.btnResetGrid.Location = new System.Drawing.Point(1283, 518);
            this.btnResetGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetGrid.Name = "btnResetGrid";
            this.btnResetGrid.Size = new System.Drawing.Size(103, 72);
            this.btnResetGrid.TabIndex = 36;
            this.btnResetGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetGrid.UseVisualStyleBackColor = false;
            this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.button1.Image = global::QuanLyCuaHang.Properties.Resources.Back5;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnDeleteSale.Image = global::QuanLyCuaHang.Properties.Resources.Delete3;
            this.btnDeleteSale.Location = new System.Drawing.Point(782, 596);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(188, 65);
            this.btnDeleteSale.TabIndex = 3;
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click_1);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnAddSale.Image = global::QuanLyCuaHang.Properties.Resources.Add7;
            this.btnAddSale.Location = new System.Drawing.Point(992, 595);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(159, 66);
            this.btnAddSale.TabIndex = 2;
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click_2);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1390, 706);
            this.Controls.Add(this.btnResetGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSaleName);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchSale);
            this.Controls.Add(this.btnDeleteSale);
            this.Controls.Add(this.dtNgayKetThuc);
            this.Controls.Add(this.dtNgayBatDau);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSale);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SaleForm";
            this.Text = "Khuyến Mãi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaleName;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnResetGrid;
    }
}