﻿namespace QuanLyCuaHang
{
    partial class PurchaseHistoryForm
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dgvBillInfo = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtFindDetails = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(0, 93);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 62);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(168, 333);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(235, 31);
            this.txtNgayLap.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày Lập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoHD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(4, 387);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 412);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(30, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ghi Chú";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(171, 161);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(232, 31);
            this.txtMaNV.TabIndex = 23;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(171, 77);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(232, 31);
            this.txtMaKH.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(30, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số Hóa Đơn";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(168, 252);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(235, 31);
            this.txtSoHD.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(26, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng Tiền";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(-1, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tìm Kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(148, 301);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 44);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(564, 501);
            this.dgvInvoiceDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.RowHeadersWidth = 51;
            this.dgvInvoiceDetails.RowTemplate.Height = 24;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(1332, 414);
            this.dgvInvoiceDetails.TabIndex = 58;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewDetails.Location = new System.Drawing.Point(227, 808);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(220, 44);
            this.btnViewDetails.TabIndex = 57;
            this.btnViewDetails.Text = "Xem Chi Tiết";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillInfo.Location = new System.Drawing.Point(564, 151);
            this.dgvBillInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.RowHeadersWidth = 51;
            this.dgvBillInfo.RowTemplate.Height = 24;
            this.dgvBillInfo.Size = new System.Drawing.Size(1332, 341);
            this.dgvBillInfo.TabIndex = 56;
            // 
            // btnLoc
            // 
            this.btnLoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoc.Location = new System.Drawing.Point(4, 301);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(135, 44);
            this.btnLoc.TabIndex = 55;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 251);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 31);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.Value = new System.DateTime(2024, 10, 16, 18, 16, 31, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-1, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Lọc hóa đơn theo ngày";
            // 
            // btnSearch
            // 
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(420, 155);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 44);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(102, 165);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(304, 31);
            this.txtTimKiem.TabIndex = 51;
            // 
            // txtFindDetails
            // 
            this.txtFindDetails.Location = new System.Drawing.Point(4, 812);
            this.txtFindDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindDetails.Name = "txtFindDetails";
            this.txtFindDetails.Size = new System.Drawing.Size(212, 31);
            this.txtFindDetails.TabIndex = 62;
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvInvoiceDetails);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.dgvBillInfo);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtFindDetails);
            this.Name = "PurchaseHistoryForm";
            this.Text = "PurchaseHistoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseHistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DataGridView dgvBillInfo;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFindDetails;
    }
}