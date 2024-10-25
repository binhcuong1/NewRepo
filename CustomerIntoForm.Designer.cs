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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchCustomerInfo = new System.Windows.Forms.Button();
            this.btnDelectCustomerInfo = new System.Windows.Forms.Button();
            this.btnEditCustomerInfo = new System.Windows.Forms.Button();
            this.btnAddCustomerInfo = new System.Windows.Forms.Button();
            this.btnResertCustomerInfo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(167, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(689, 28);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(167, 127);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(205, 28);
            this.txtSDT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(297, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(316, 28);
            this.txtTimKiem.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnSearchCustomerInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(233, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 64);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nhập tên hoặc sdt ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(167, 35);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(316, 28);
            this.txtTenKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Location = new System.Drawing.Point(259, 372);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.RowHeadersWidth = 51;
            this.dgvCustomerInfo.RowTemplate.Height = 24;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(749, 386);
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
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(163, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 207);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.button1.Image = global::QuanLyCuaHang.Properties.Resources.Back5;
            this.button1.Location = new System.Drawing.Point(2, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchCustomerInfo
            // 
            this.btnSearchCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnSearchCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnSearchCustomerInfo.Image = global::QuanLyCuaHang.Properties.Resources.Search1;
            this.btnSearchCustomerInfo.Location = new System.Drawing.Point(663, 13);
            this.btnSearchCustomerInfo.Name = "btnSearchCustomerInfo";
            this.btnSearchCustomerInfo.Size = new System.Drawing.Size(130, 45);
            this.btnSearchCustomerInfo.TabIndex = 8;
            this.btnSearchCustomerInfo.UseVisualStyleBackColor = false;
            this.btnSearchCustomerInfo.Click += new System.EventHandler(this.btnSearchCustomerInfo_Click);
            // 
            // btnDelectCustomerInfo
            // 
            this.btnDelectCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelectCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnDelectCustomerInfo.Image = global::QuanLyCuaHang.Properties.Resources.Delete1;
            this.btnDelectCustomerInfo.Location = new System.Drawing.Point(877, 132);
            this.btnDelectCustomerInfo.Name = "btnDelectCustomerInfo";
            this.btnDelectCustomerInfo.Size = new System.Drawing.Size(121, 63);
            this.btnDelectCustomerInfo.TabIndex = 6;
            this.btnDelectCustomerInfo.UseVisualStyleBackColor = true;
            this.btnDelectCustomerInfo.Click += new System.EventHandler(this.btnDelectCustomerInfo_Click);
            // 
            // btnEditCustomerInfo
            // 
            this.btnEditCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnEditCustomerInfo.Image = global::QuanLyCuaHang.Properties.Resources.Maintenance;
            this.btnEditCustomerInfo.Location = new System.Drawing.Point(732, 132);
            this.btnEditCustomerInfo.Name = "btnEditCustomerInfo";
            this.btnEditCustomerInfo.Size = new System.Drawing.Size(121, 63);
            this.btnEditCustomerInfo.TabIndex = 5;
            this.btnEditCustomerInfo.UseVisualStyleBackColor = true;
            this.btnEditCustomerInfo.Click += new System.EventHandler(this.btnEditCustomerInfo_Click);
            // 
            // btnAddCustomerInfo
            // 
            this.btnAddCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnAddCustomerInfo.Image = global::QuanLyCuaHang.Properties.Resources.Add2;
            this.btnAddCustomerInfo.Location = new System.Drawing.Point(575, 132);
            this.btnAddCustomerInfo.Name = "btnAddCustomerInfo";
            this.btnAddCustomerInfo.Size = new System.Drawing.Size(122, 63);
            this.btnAddCustomerInfo.TabIndex = 4;
            this.btnAddCustomerInfo.UseVisualStyleBackColor = true;
            this.btnAddCustomerInfo.Click += new System.EventHandler(this.btnAddCustomerInfo_Click);
            // 
            // btnResertCustomerInfo
            // 
            this.btnResertCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnResertCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResertCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResertCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btnResertCustomerInfo.Image = global::QuanLyCuaHang.Properties.Resources.Update_Left_Rotation1;
            this.btnResertCustomerInfo.Location = new System.Drawing.Point(105, 288);
            this.btnResertCustomerInfo.Name = "btnResertCustomerInfo";
            this.btnResertCustomerInfo.Size = new System.Drawing.Size(122, 45);
            this.btnResertCustomerInfo.TabIndex = 9;
            this.btnResertCustomerInfo.UseVisualStyleBackColor = false;
            this.btnResertCustomerInfo.Click += new System.EventHandler(this.btnResertCustomerInfo_Click);
            // 
            // CustomerIntoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1263, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCustomerInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResertCustomerInfo);
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
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResertCustomerInfo;
        private System.Windows.Forms.Button btnSearchCustomerInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}