namespace QuanLyCuaHang.UserControls
{
    partial class ShiftUC
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLam = new System.Windows.Forms.DateTimePicker();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvOfShiftUC = new System.Windows.Forms.DataGridView();
            this.btnAddAndUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfShiftUC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStaff);
            this.groupBox1.Controls.Add(this.txtMaCa);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLam);
            this.groupBox1.Controls.Add(this.btnAddAndUpdate);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbShift);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(164, 27);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(172, 24);
            this.cmbStaff.TabIndex = 7;
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(295, 150);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(41, 22);
            this.txtMaCa.TabIndex = 6;
            this.txtMaCa.Visible = false;
            // 
            // dateTimePickerNgayLam
            // 
            this.dateTimePickerNgayLam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLam.Location = new System.Drawing.Point(116, 122);
            this.dateTimePickerNgayLam.Name = "dateTimePickerNgayLam";
            this.dateTimePickerNgayLam.Size = new System.Drawing.Size(220, 28);
            this.dateTimePickerNgayLam.TabIndex = 5;
            this.dateTimePickerNgayLam.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLam_ValueChanged);
            // 
            // cmbShift
            // 
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(164, 74);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(172, 24);
            this.cmbShift.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ca làm việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn Nhân Viên";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvOfShiftUC
            // 
            this.dgvOfShiftUC.BackgroundColor = System.Drawing.Color.White;
            this.dgvOfShiftUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfShiftUC.Location = new System.Drawing.Point(374, 49);
            this.dgvOfShiftUC.Name = "dgvOfShiftUC";
            this.dgvOfShiftUC.RowHeadersWidth = 51;
            this.dgvOfShiftUC.RowTemplate.Height = 24;
            this.dgvOfShiftUC.Size = new System.Drawing.Size(742, 544);
            this.dgvOfShiftUC.TabIndex = 4;
            this.dgvOfShiftUC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfShiftUC_CellContentClick);
            // 
            // btnAddAndUpdate
            // 
            this.btnAddAndUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAndUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAddAndUpdate.Image = global::QuanLyCuaHang.Properties.Resources.Maintenance1;
            this.btnAddAndUpdate.Location = new System.Drawing.Point(13, 178);
            this.btnAddAndUpdate.Name = "btnAddAndUpdate";
            this.btnAddAndUpdate.Size = new System.Drawing.Size(104, 61);
            this.btnAddAndUpdate.TabIndex = 4;
            this.btnAddAndUpdate.UseVisualStyleBackColor = false;
            this.btnAddAndUpdate.Click += new System.EventHandler(this.btnAddAndUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::QuanLyCuaHang.Properties.Resources.Update_Left_Rotation3;
            this.btnRefresh.Location = new System.Drawing.Point(243, 178);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 61);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::QuanLyCuaHang.Properties.Resources.Search3;
            this.btnSearch.Location = new System.Drawing.Point(127, 178);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 61);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ShiftUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOfShiftUC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShiftUC";
            this.Size = new System.Drawing.Size(1126, 643);
            this.Load += new System.EventHandler(this.ShiftUC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfShiftUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLam;
        private System.Windows.Forms.Button btnAddAndUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvOfShiftUC;
    }
}
