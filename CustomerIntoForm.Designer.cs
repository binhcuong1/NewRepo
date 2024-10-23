namespace QuanLyCuaHang
{
    partial class CustomerIntoForm
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelectCustomerInfo = new System.Windows.Forms.Button();
            this.btnEditCustomerInfo = new System.Windows.Forms.Button();
            this.btnAddCustomerInfo = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResertCustomerInfo = new System.Windows.Forms.Button();
            this.btnSearchCustomerInfo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(385, 96);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 52);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(167, 111);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(689, 30);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(167, 188);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(205, 30);
            this.txtSDT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(506, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(316, 30);
            this.txtTimKiem.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(514, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 64);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // btnDelectCustomerInfo
            // 
            this.btnDelectCustomerInfo.Location = new System.Drawing.Point(873, 236);
            this.btnDelectCustomerInfo.Name = "btnDelectCustomerInfo";
            this.btnDelectCustomerInfo.Size = new System.Drawing.Size(130, 45);
            this.btnDelectCustomerInfo.TabIndex = 7;
            this.btnDelectCustomerInfo.Text = "Xóa";
            this.btnDelectCustomerInfo.UseVisualStyleBackColor = true;
            this.btnDelectCustomerInfo.Click += new System.EventHandler(this.btnDelectCustomerInfo_Click);
            // 
            // btnEditCustomerInfo
            // 
            this.btnEditCustomerInfo.Location = new System.Drawing.Point(873, 164);
            this.btnEditCustomerInfo.Name = "btnEditCustomerInfo";
            this.btnEditCustomerInfo.Size = new System.Drawing.Size(121, 45);
            this.btnEditCustomerInfo.TabIndex = 6;
            this.btnEditCustomerInfo.Text = "Sửa";
            this.btnEditCustomerInfo.UseVisualStyleBackColor = true;
            this.btnEditCustomerInfo.Click += new System.EventHandler(this.btnEditCustomerInfo_Click);
            // 
            // btnAddCustomerInfo
            // 
            this.btnAddCustomerInfo.Location = new System.Drawing.Point(872, 85);
            this.btnAddCustomerInfo.Name = "btnAddCustomerInfo";
            this.btnAddCustomerInfo.Size = new System.Drawing.Size(122, 45);
            this.btnAddCustomerInfo.TabIndex = 5;
            this.btnAddCustomerInfo.Text = "Thêm";
            this.btnAddCustomerInfo.UseVisualStyleBackColor = true;
            this.btnAddCustomerInfo.Click += new System.EventHandler(this.btnAddCustomerInfo_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(540, 45);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(316, 30);
            this.txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(167, 48);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(187, 30);
            this.txtMaKH.TabIndex = 0;
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Location = new System.Drawing.Point(219, 447);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.RowHeadersWidth = 51;
            this.dgvCustomerInfo.RowTemplate.Height = 24;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(1106, 408);
            this.dgvCustomerInfo.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDelectCustomerInfo);
            this.groupBox1.Controls.Add(this.btnEditCustomerInfo);
            this.groupBox1.Controls.Add(this.btnAddCustomerInfo);
            this.groupBox1.Controls.Add(this.btnResertCustomerInfo);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(505, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 287);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnResertCustomerInfo
            // 
            this.btnResertCustomerInfo.Location = new System.Drawing.Point(872, 10);
            this.btnResertCustomerInfo.Name = "btnResertCustomerInfo";
            this.btnResertCustomerInfo.Size = new System.Drawing.Size(122, 45);
            this.btnResertCustomerInfo.TabIndex = 4;
            this.btnResertCustomerInfo.Text = "Làm Mới ";
            this.btnResertCustomerInfo.UseVisualStyleBackColor = true;
            this.btnResertCustomerInfo.Click += new System.EventHandler(this.btnResertCustomerInfo_Click);
            // 
            // btnSearchCustomerInfo
            // 
            this.btnSearchCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomerInfo.Location = new System.Drawing.Point(1387, 398);
            this.btnSearchCustomerInfo.Name = "btnSearchCustomerInfo";
            this.btnSearchCustomerInfo.Size = new System.Drawing.Size(130, 45);
            this.btnSearchCustomerInfo.TabIndex = 31;
            this.btnSearchCustomerInfo.Text = "Tìm";
            this.btnSearchCustomerInfo.UseVisualStyleBackColor = true;
            this.btnSearchCustomerInfo.Click += new System.EventHandler(this.btnSearchCustomerInfo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CustomerIntoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 845);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCustomerInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchCustomerInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerIntoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerIntoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerIntoForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelectCustomerInfo;
        private System.Windows.Forms.Button btnEditCustomerInfo;
        private System.Windows.Forms.Button btnAddCustomerInfo;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResertCustomerInfo;
        private System.Windows.Forms.Button btnSearchCustomerInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}