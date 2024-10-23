namespace QuanLyCuaHang
{
    partial class StaffForm
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(12, 105);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 82;
            this.dgvStaff.RowTemplate.Height = 33;
            this.dgvStaff.Size = new System.Drawing.Size(1325, 834);
            this.dgvStaff.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1468, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 722);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 1009);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStaff);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}