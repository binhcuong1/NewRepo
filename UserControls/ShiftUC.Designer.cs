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
            this.btnAddAndUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvOfShiftUC = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(514, 400);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(170, 38);
            this.cmbStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(324, 33);
            this.cmbStaff.TabIndex = 7;
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(442, 234);
            this.txtMaCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(60, 31);
            this.txtMaCa.TabIndex = 6;
            this.txtMaCa.Visible = false;
            // 
            // dateTimePickerNgayLam
            // 
            this.dateTimePickerNgayLam.Location = new System.Drawing.Point(174, 191);
            this.dateTimePickerNgayLam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerNgayLam.Name = "dateTimePickerNgayLam";
            this.dateTimePickerNgayLam.Size = new System.Drawing.Size(328, 31);
            this.dateTimePickerNgayLam.TabIndex = 5;
            this.dateTimePickerNgayLam.ValueChanged += new System.EventHandler(this.dateTimePickerNgayLam_ValueChanged);
            // 
            // btnAddAndUpdate
            // 
            this.btnAddAndUpdate.Location = new System.Drawing.Point(8, 322);
            this.btnAddAndUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAndUpdate.Name = "btnAddAndUpdate";
            this.btnAddAndUpdate.Size = new System.Drawing.Size(174, 52);
            this.btnAddAndUpdate.TabIndex = 4;
            this.btnAddAndUpdate.Text = "Thêm/Sửa";
            this.btnAddAndUpdate.UseVisualStyleBackColor = true;
            this.btnAddAndUpdate.Click += new System.EventHandler(this.btnAddAndUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(364, 322);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 52);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(190, 322);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbShift
            // 
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(174, 116);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(328, 33);
            this.cmbShift.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ca làm việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
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
            this.dgvOfShiftUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfShiftUC.Location = new System.Drawing.Point(561, 77);
            this.dgvOfShiftUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOfShiftUC.Name = "dgvOfShiftUC";
            this.dgvOfShiftUC.RowHeadersWidth = 51;
            this.dgvOfShiftUC.RowTemplate.Height = 24;
            this.dgvOfShiftUC.Size = new System.Drawing.Size(1113, 850);
            this.dgvOfShiftUC.TabIndex = 4;
            this.dgvOfShiftUC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfShiftUC_CellContentClick);
            // 
            // ShiftUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOfShiftUC);
            this.Name = "ShiftUC";
            this.Size = new System.Drawing.Size(1689, 1005);
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
