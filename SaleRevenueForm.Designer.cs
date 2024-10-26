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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDailyTarget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthlyRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTopSellingProducts = new System.Windows.Forms.DataGridView();
            this.UnsoldProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellingProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnsoldProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(19, 21);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1120, 284);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartDailyRevenue";
            // 
            // chartDailyTarget
            // 
            chartArea5.Name = "ChartArea1";
            this.chartDailyTarget.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartDailyTarget.Legends.Add(legend5);
            this.chartDailyTarget.Location = new System.Drawing.Point(1450, 21);
            this.chartDailyTarget.Name = "chartDailyTarget";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartDailyTarget.Series.Add(series5);
            this.chartDailyTarget.Size = new System.Drawing.Size(526, 284);
            this.chartDailyTarget.TabIndex = 1;
            this.chartDailyTarget.Text = "chartDailyTarget";
            // 
            // chartMonthlyRevenue
            // 
            chartArea6.Name = "ChartArea1";
            this.chartMonthlyRevenue.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartMonthlyRevenue.Legends.Add(legend6);
            this.chartMonthlyRevenue.Location = new System.Drawing.Point(19, 351);
            this.chartMonthlyRevenue.Name = "chartMonthlyRevenue";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartMonthlyRevenue.Series.Add(series6);
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
            // SaleRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 817);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyTarget;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyRevenue;
        private System.Windows.Forms.DataGridView dgvTopSellingProducts;
        private System.Windows.Forms.DataGridView UnsoldProducts;
    }
}