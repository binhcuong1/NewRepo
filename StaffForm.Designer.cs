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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlEditStaff = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(32, -109);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 82;
            this.dgvStaff.RowTemplate.Height = 33;
            this.dgvStaff.Size = new System.Drawing.Size(1325, 1200);
            this.dgvStaff.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1468, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 722);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // pnlEditStaff
            // 
            this.pnlEditStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEditStaff.BackgroundImage")));
            this.pnlEditStaff.Location = new System.Drawing.Point(1977, 932);
            this.pnlEditStaff.Name = "pnlEditStaff";
            this.pnlEditStaff.Size = new System.Drawing.Size(1000, 700);
            this.pnlEditStaff.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnDeleteStaff_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(234, 50);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 1009);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEditStaff);
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
        private System.Windows.Forms.Panel pnlEditStaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
    }
}