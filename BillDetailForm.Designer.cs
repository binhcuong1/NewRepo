namespace QuanLyCuaHang
{
    partial class BillDetailForm
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
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dvgChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.txtCustomerFeedback = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(658, 412);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(259, 40);
            this.lblTongTien.TabIndex = 13;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(29, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(206, 23);
            this.lblCustomerName.TabIndex = 12;
            // 
            // dvgChiTietHoaDon
            // 
            this.dvgChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgChiTietHoaDon.Location = new System.Drawing.Point(34, 60);
            this.dvgChiTietHoaDon.Name = "dvgChiTietHoaDon";
            this.dvgChiTietHoaDon.RowHeadersWidth = 51;
            this.dvgChiTietHoaDon.RowTemplate.Height = 24;
            this.dvgChiTietHoaDon.Size = new System.Drawing.Size(869, 339);
            this.dvgChiTietHoaDon.TabIndex = 11;
            // 
            // txtCustomerFeedback
            // 
            this.txtCustomerFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFeedback.Location = new System.Drawing.Point(36, 413);
            this.txtCustomerFeedback.Name = "txtCustomerFeedback";
            this.txtCustomerFeedback.Size = new System.Drawing.Size(247, 27);
            this.txtCustomerFeedback.TabIndex = 1;
            // 
            // btnRefund
            // 
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Location = new System.Drawing.Point(36, 449);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(98, 32);
            this.btnRefund.TabIndex = 2;
            this.btnRefund.Text = "Hoàn trả";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust.Location = new System.Drawing.Point(169, 449);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(114, 32);
            this.btnAdjust.TabIndex = 3;
            this.btnAdjust.Text = "Điều chỉnh";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 492);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.txtCustomerFeedback);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dvgChiTietHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillDetailForm";
            this.Text = "BillDetailForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillDetailForm_FormClosed);
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dvgChiTietHoaDon;
        private System.Windows.Forms.TextBox txtCustomerFeedback;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnAdjust;
    }
}