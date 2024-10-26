namespace QuanLyCuaHang
{
    partial class SaleRevenueForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDailyTarget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthlyRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTopSellingProducts = new System.Windows.Forms.DataGridView();
            this.UnsoldProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellingProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnsoldProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(19, 21);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(1120, 284);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartDailyRevenue";
            // 
            // chartDailyTarget
            // 
            chartArea14.Name = "ChartArea1";
            this.chartDailyTarget.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartDailyTarget.Legends.Add(legend14);
            this.chartDailyTarget.Location = new System.Drawing.Point(1450, 21);
            this.chartDailyTarget.Name = "chartDailyTarget";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartDailyTarget.Series.Add(series14);
            this.chartDailyTarget.Size = new System.Drawing.Size(526, 284);
            this.chartDailyTarget.TabIndex = 1;
            this.chartDailyTarget.Text = "chartDailyTarget";
            // 
            // chartMonthlyRevenue
            // 
            chartArea15.Name = "ChartArea1";
            this.chartMonthlyRevenue.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chartMonthlyRevenue.Legends.Add(legend15);
            this.chartMonthlyRevenue.Location = new System.Drawing.Point(19, 351);
            this.chartMonthlyRevenue.Name = "chartMonthlyRevenue";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chartMonthlyRevenue.Series.Add(series15);
            this.chartMonthlyRevenue.Size = new System.Drawing.Size(1670, 268);
            this.chartMonthlyRevenue.TabIndex = 1;
            this.chartMonthlyRevenue.Text = "chart";
            // 
            // dgvTopSellingProducts
            // 
            this.dgvTopSellingProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSellingProducts.Location = new System.Drawing.Point(1, 641);
            this.dgvTopSellingProducts.Name = "dgvTopSellingProducts";
            this.dgvTopSellingProducts.RowHeadersWidth = 51;
            this.dgvTopSellingProducts.RowTemplate.Height = 24;
            this.dgvTopSellingProducts.Size = new System.Drawing.Size(886, 222);
            this.dgvTopSellingProducts.TabIndex = 2;
            // 
            // UnsoldProducts
            // 
            this.UnsoldProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnsoldProducts.Location = new System.Drawing.Point(1180, 641);
            this.UnsoldProducts.Name = "UnsoldProducts";
            this.UnsoldProducts.RowHeadersWidth = 51;
            this.UnsoldProducts.RowTemplate.Height = 24;
            this.UnsoldProducts.Size = new System.Drawing.Size(886, 222);
            this.UnsoldProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1176, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảng Doanh Thu Theo Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(893, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bán Chạy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1060, 752);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tồn Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1176, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bảng Doanh Thu Theo Tháng";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.Right_Arrow;
            this.pictureBox4.Location = new System.Drawing.Point(1087, 699);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.Left_Arrow;
            this.pictureBox3.Location = new System.Drawing.Point(911, 699);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.Down_Arrow;
            this.pictureBox2.Location = new System.Drawing.Point(1280, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.Sorting_Arrows_Horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(1269, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SaleRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 817);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnsoldProducts);
            this.Controls.Add(this.dgvTopSellingProducts);
            this.Controls.Add(this.chartMonthlyRevenue);
            this.Controls.Add(this.chartDailyTarget);
            this.Controls.Add(this.chart1);
            this.Name = "SaleRevenueForm";
            this.Text = "SaleRevenueForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleRevenueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellingProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnsoldProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyTarget;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyRevenue;
        private System.Windows.Forms.DataGridView dgvTopSellingProducts;
        private System.Windows.Forms.DataGridView UnsoldProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}