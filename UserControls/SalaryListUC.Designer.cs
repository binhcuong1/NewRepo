namespace QuanLyCuaHang.UserControls
{
    partial class SalaryListUC
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
            this.btnBackToProductGateFrm = new System.Windows.Forms.Button();
            this.txtSumSalary = new System.Windows.Forms.TextBox();
            this.txtTotalWorkingHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowNameStaff = new System.Windows.Forms.Label();
            this.lblShowIDStaff = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnCheckSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToProductGateFrm
            // 
            this.btnBackToProductGateFrm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBackToProductGateFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToProductGateFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProductGateFrm.Location = new System.Drawing.Point(2, 2);
            this.btnBackToProductGateFrm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToProductGateFrm.Name = "btnBackToProductGateFrm";
            this.btnBackToProductGateFrm.Size = new System.Drawing.Size(161, 47);
            this.btnBackToProductGateFrm.TabIndex = 9;
            this.btnBackToProductGateFrm.Text = "Quay Lại";
            this.btnBackToProductGateFrm.UseVisualStyleBackColor = false;
            this.btnBackToProductGateFrm.Click += new System.EventHandler(this.btnBackToProductGateFrm_Click);
            // 
            // txtSumSalary
            // 
            this.txtSumSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumSalary.Location = new System.Drawing.Point(318, 259);
            this.txtSumSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumSalary.Name = "txtSumSalary";
            this.txtSumSalary.Size = new System.Drawing.Size(143, 22);
            this.txtSumSalary.TabIndex = 10;
            // 
            // txtTotalWorkingHours
            // 
            this.txtTotalWorkingHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalWorkingHours.Location = new System.Drawing.Point(318, 292);
            this.txtTotalWorkingHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalWorkingHours.Name = "txtTotalWorkingHours";
            this.txtTotalWorkingHours.Size = new System.Drawing.Size(143, 22);
            this.txtTotalWorkingHours.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng Giờ Làm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chọn tháng cần xem lương";
            // 
            // lblShowNameStaff
            // 
            this.lblShowNameStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowNameStaff.AutoSize = true;
            this.lblShowNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameStaff.Location = new System.Drawing.Point(231, 79);
            this.lblShowNameStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowNameStaff.Name = "lblShowNameStaff";
            this.lblShowNameStaff.Size = new System.Drawing.Size(242, 29);
            this.lblShowNameStaff.TabIndex = 12;
            this.lblShowNameStaff.Text = "Chỗ này hiển thị tên";
            // 
            // lblShowIDStaff
            // 
            this.lblShowIDStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowIDStaff.AutoSize = true;
            this.lblShowIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowIDStaff.Location = new System.Drawing.Point(232, 47);
            this.lblShowIDStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowIDStaff.Name = "lblShowIDStaff";
            this.lblShowIDStaff.Size = new System.Drawing.Size(241, 29);
            this.lblShowIDStaff.TabIndex = 12;
            this.lblShowIDStaff.Text = "Chỗ này hiển thị Mã";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cmbMonth.Location = new System.Drawing.Point(318, 163);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(199, 24);
            this.cmbMonth.TabIndex = 14;
            // 
            // btnCheckSalary
            // 
            this.btnCheckSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckSalary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCheckSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSalary.Location = new System.Drawing.Point(477, 204);
            this.btnCheckSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckSalary.Name = "btnCheckSalary";
            this.btnCheckSalary.Size = new System.Drawing.Size(121, 29);
            this.btnCheckSalary.TabIndex = 9;
            this.btnCheckSalary.Text = "Kiểm Tra";
            this.btnCheckSalary.UseVisualStyleBackColor = false;
            this.btnCheckSalary.Click += new System.EventHandler(this.BtnCheckSalary_Click);
            // 
            // SalaryListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShowIDStaff);
            this.Controls.Add(this.lblShowNameStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalWorkingHours);
            this.Controls.Add(this.txtSumSalary);
            this.Controls.Add(this.btnCheckSalary);
            this.Controls.Add(this.btnBackToProductGateFrm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalaryListUC";
            this.Size = new System.Drawing.Size(667, 448);
            this.Load += new System.EventHandler(this.SalaryListUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToProductGateFrm;
        private System.Windows.Forms.TextBox txtSumSalary;
        private System.Windows.Forms.TextBox txtTotalWorkingHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowNameStaff;
        private System.Windows.Forms.Label lblShowIDStaff;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnCheckSalary;
    }
}
