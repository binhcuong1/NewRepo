﻿namespace QuanLyCuaHang
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(250, 173);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(1032, 40);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(250, 294);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(306, 40);
            this.txtSDT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(445, 37);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(472, 40);
            this.txtTimKiem.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnSearchCustomerInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(348, 522);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1198, 100);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // btnDelectCustomerInfo
            // 
            this.btnDelectCustomerInfo.Location = new System.Drawing.Point(1310, 369);
            this.btnDelectCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelectCustomerInfo.Name = "btnDelectCustomerInfo";
            this.btnDelectCustomerInfo.Size = new System.Drawing.Size(181, 70);
            this.btnDelectCustomerInfo.TabIndex = 7;
            this.btnDelectCustomerInfo.Text = "Xóa";
            this.btnDelectCustomerInfo.UseVisualStyleBackColor = true;
            this.btnDelectCustomerInfo.Click += new System.EventHandler(this.btnDelectCustomerInfo_Click);
            // 
            // btnEditCustomerInfo
            // 
            this.btnEditCustomerInfo.Location = new System.Drawing.Point(1310, 256);
            this.btnEditCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCustomerInfo.Name = "btnEditCustomerInfo";
            this.btnEditCustomerInfo.Size = new System.Drawing.Size(182, 70);
            this.btnEditCustomerInfo.TabIndex = 6;
            this.btnEditCustomerInfo.Text = "Sửa";
            this.btnEditCustomerInfo.UseVisualStyleBackColor = true;
            this.btnEditCustomerInfo.Click += new System.EventHandler(this.btnEditCustomerInfo_Click);
            // 
            // btnAddCustomerInfo
            // 
            this.btnAddCustomerInfo.Location = new System.Drawing.Point(1308, 133);
            this.btnAddCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomerInfo.Name = "btnAddCustomerInfo";
            this.btnAddCustomerInfo.Size = new System.Drawing.Size(183, 70);
            this.btnAddCustomerInfo.TabIndex = 5;
            this.btnAddCustomerInfo.Text = "Thêm";
            this.btnAddCustomerInfo.UseVisualStyleBackColor = true;
            this.btnAddCustomerInfo.Click += new System.EventHandler(this.btnAddCustomerInfo_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(810, 70);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(472, 40);
            this.txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(250, 75);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(278, 40);
            this.txtMaKH.TabIndex = 0;
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Location = new System.Drawing.Point(386, 674);
            this.dgvCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.RowHeadersWidth = 51;
            this.dgvCustomerInfo.RowTemplate.Height = 24;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(1123, 603);
            this.dgvCustomerInfo.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1518, 459);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnResertCustomerInfo
            // 
            this.btnResertCustomerInfo.Location = new System.Drawing.Point(1308, 16);
            this.btnResertCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResertCustomerInfo.Name = "btnResertCustomerInfo";
            this.btnResertCustomerInfo.Size = new System.Drawing.Size(183, 70);
            this.btnResertCustomerInfo.TabIndex = 4;
            this.btnResertCustomerInfo.Text = "Làm Mới ";
            this.btnResertCustomerInfo.UseVisualStyleBackColor = true;
            this.btnResertCustomerInfo.Click += new System.EventHandler(this.btnResertCustomerInfo_Click);
            // 
            // btnSearchCustomerInfo
            // 
            this.btnSearchCustomerInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSearchCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomerInfo.Location = new System.Drawing.Point(994, 20);
            this.btnSearchCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchCustomerInfo.Name = "btnSearchCustomerInfo";
            this.btnSearchCustomerInfo.Size = new System.Drawing.Size(195, 70);
            this.btnSearchCustomerInfo.TabIndex = 31;
            this.btnSearchCustomerInfo.Text = "Tìm";
            this.btnSearchCustomerInfo.UseVisualStyleBackColor = false;
            this.btnSearchCustomerInfo.Click += new System.EventHandler(this.btnSearchCustomerInfo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 50);
            this.button1.TabIndex = 34;
            this.button1.Text = "Quay Lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomerIntoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCustomerInfo);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button button1;
    }
}