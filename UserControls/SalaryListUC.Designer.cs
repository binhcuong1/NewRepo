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
            this.txtSumSalary = new System.Windows.Forms.TextBox();
            this.txtTotalWorkingHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowNameStaff = new System.Windows.Forms.Label();
            this.lblShowIDStaff = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnCheckSalary = new System.Windows.Forms.Button();
            this.btnBackToProductGateFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSumSalary
            // 
            this.txtSumSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumSalary.Location = new System.Drawing.Point(335, 301);
            this.txtSumSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumSalary.Name = "txtSumSalary";
            this.txtSumSalary.Size = new System.Drawing.Size(143, 30);
            this.txtSumSalary.TabIndex = 10;
            // 
            // txtTotalWorkingHours
            // 
            this.txtTotalWorkingHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWorkingHours.Location = new System.Drawing.Point(335, 343);
            this.txtTotalWorkingHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalWorkingHours.Name = "txtTotalWorkingHours";
            this.txtTotalWorkingHours.Size = new System.Drawing.Size(143, 30);
            this.txtTotalWorkingHours.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng Giờ Làm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chọn tháng cần xem lương";
            // 
            // lblShowNameStaff
            // 
            this.lblShowNameStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowNameStaff.AutoSize = true;
            this.lblShowNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameStaff.Location = new System.Drawing.Point(166, 92);
            this.lblShowNameStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowNameStaff.Name = "lblShowNameStaff";
            this.lblShowNameStaff.Size = new System.Drawing.Size(184, 29);
            this.lblShowNameStaff.TabIndex = 12;
            this.lblShowNameStaff.Text = "Tên nhân viên:";
            // 
            // lblShowIDStaff
            // 
            this.lblShowIDStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowIDStaff.AutoSize = true;
            this.lblShowIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowIDStaff.Location = new System.Drawing.Point(166, 55);
            this.lblShowIDStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowIDStaff.Name = "lblShowIDStaff";
            this.lblShowIDStaff.Size = new System.Drawing.Size(62, 29);
            this.lblShowIDStaff.TabIndex = 12;
            this.lblShowIDStaff.Text = "Mã: ";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbMonth.Location = new System.Drawing.Point(361, 166);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(199, 33);
            this.cmbMonth.TabIndex = 14;
            // 
            // btnCheckSalary
            // 
            this.btnCheckSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckSalary.BackColor = System.Drawing.Color.White;
            this.btnCheckSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSalary.ForeColor = System.Drawing.Color.White;
            this.btnCheckSalary.Image = global::QuanLyCuaHang.Properties.Resources.Search4;
            this.btnCheckSalary.Location = new System.Drawing.Point(479, 203);
            this.btnCheckSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckSalary.Name = "btnCheckSalary";
            this.btnCheckSalary.Size = new System.Drawing.Size(81, 54);
            this.btnCheckSalary.TabIndex = 9;
            this.btnCheckSalary.UseVisualStyleBackColor = false;
            this.btnCheckSalary.Click += new System.EventHandler(this.BtnCheckSalary_Click);
            // 
            // btnBackToProductGateFrm
            // 
            this.btnBackToProductGateFrm.BackColor = System.Drawing.Color.White;
            this.btnBackToProductGateFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToProductGateFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProductGateFrm.ForeColor = System.Drawing.Color.White;
            this.btnBackToProductGateFrm.Image = global::QuanLyCuaHang.Properties.Resources.Cancel1;
            this.btnBackToProductGateFrm.Location = new System.Drawing.Point(0, 2);
            this.btnBackToProductGateFrm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToProductGateFrm.Name = "btnBackToProductGateFrm";
            this.btnBackToProductGateFrm.Size = new System.Drawing.Size(69, 47);
            this.btnBackToProductGateFrm.TabIndex = 9;
            this.btnBackToProductGateFrm.UseVisualStyleBackColor = false;
            this.btnBackToProductGateFrm.Click += new System.EventHandler(this.btnBackToProductGateFrm_Click);
            // 
            // SalaryListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
