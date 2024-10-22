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
            ((System.ComponentModel.ISupportInitialize)(this.dvgChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(987, 644);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(388, 62);
            this.lblTongTien.TabIndex = 13;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(44, 31);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(309, 36);
            this.lblCustomerName.TabIndex = 12;
            // 
            // dvgChiTietHoaDon
            // 
            this.dvgChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgChiTietHoaDon.Location = new System.Drawing.Point(51, 94);
            this.dvgChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgChiTietHoaDon.Name = "dvgChiTietHoaDon";
            this.dvgChiTietHoaDon.RowHeadersWidth = 51;
            this.dvgChiTietHoaDon.RowTemplate.Height = 24;
            this.dvgChiTietHoaDon.Size = new System.Drawing.Size(1304, 530);
            this.dvgChiTietHoaDon.TabIndex = 11;
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 736);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dvgChiTietHoaDon);
            this.Name = "BillDetailForm";
            this.Text = "BillDetailForm";
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dvgChiTietHoaDon;
    }
}