namespace QuanLyCuaHang
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOfProductCategory = new System.Windows.Forms.Panel();
            this.pnlOfHai = new System.Windows.Forms.Panel();
            this.pnlOfDat = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainBill = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlOfDat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContainBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1894, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.sảnPhẩmToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.khuyếnMãiToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhMụcToolStripMenuItem.Image")));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(52, 36);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caLàmViệcToolStripMenuItem,
            this.lươngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(276, 44);
            this.toolStripMenuItem1.Text = "Nhân Viên";
            // 
            // caLàmViệcToolStripMenuItem
            // 
            this.caLàmViệcToolStripMenuItem.Name = "caLàmViệcToolStripMenuItem";
            this.caLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(381, 44);
            this.caLàmViệcToolStripMenuItem.Text = "Ca Làm Việc";
            this.caLàmViệcToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_Shift_Click);
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(381, 44);
            this.lươngToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProductCategory});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // tsmProductCategory
            // 
            this.tsmProductCategory.Name = "tsmProductCategory";
            this.tsmProductCategory.Size = new System.Drawing.Size(371, 44);
            this.tsmProductCategory.Text = "Danh Mục Sản Phẩm";
            this.tsmProductCategory.Click += new System.EventHandler(this.ToolStripMenu_ProductCategory_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtHóaĐơnToolStripMenuItem,
            this.xemHóaĐơnToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // xuấtHóaĐơnToolStripMenuItem
            // 
            this.xuấtHóaĐơnToolStripMenuItem.Name = "xuấtHóaĐơnToolStripMenuItem";
            this.xuấtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(297, 44);
            this.xuấtHóaĐơnToolStripMenuItem.Text = "Xuất Hóa Đơn";
            this.xuấtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_OutputBill_Click);
            // 
            // xemHóaĐơnToolStripMenuItem
            // 
            this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
            this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(297, 44);
            this.xemHóaĐơnToolStripMenuItem.Text = "Xem Hóa Đơn";
            this.xemHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_BillView_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.lịchSửToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(256, 44);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_CustomerInfo_Click);
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(256, 44);
            this.lịchSửToolStripMenuItem.Text = "Lịch Sử";
            this.lịchSửToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_PurchaseHistory_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến Mãi";
            this.khuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Sale_Click);
            // 
            // pnlOfProductCategory
            // 
            this.pnlOfProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOfProductCategory.Location = new System.Drawing.Point(1738, 78);
            this.pnlOfProductCategory.Name = "pnlOfProductCategory";
            this.pnlOfProductCategory.Size = new System.Drawing.Size(640, 292);
            this.pnlOfProductCategory.TabIndex = 1;
            // 
            // pnlOfHai
            // 
            this.pnlOfHai.Location = new System.Drawing.Point(38, 1448);
            this.pnlOfHai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOfHai.Name = "pnlOfHai";
            this.pnlOfHai.Size = new System.Drawing.Size(1810, 908);
            this.pnlOfHai.TabIndex = 2;
            // 
            // pnlOfDat
            // 
            this.pnlOfDat.Controls.Add(this.pnlOfProductCategory);
            this.pnlOfDat.Location = new System.Drawing.Point(1695, 938);
            this.pnlOfDat.Name = "pnlOfDat";
            this.pnlOfDat.Size = new System.Drawing.Size(1750, 898);
            this.pnlOfDat.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(573, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 220);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(178, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quyền: Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(267, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào: Nguyễn Văn A";
            // 
            // pnlContainBill
            // 
            this.pnlContainBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContainBill.BackColor = System.Drawing.Color.Red;
            this.pnlContainBill.Controls.Add(this.label3);
            this.pnlContainBill.Location = new System.Drawing.Point(386, 466);
            this.pnlContainBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainBill.Name = "pnlContainBill";
            this.pnlContainBill.Size = new System.Drawing.Size(2134, 716);
            this.pnlContainBill.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hóa đơn trong panel này";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.pnlContainBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOfDat);
            this.Controls.Add(this.pnlOfHai);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng tiện lợi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlOfDat.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContainBill.ResumeLayout(false);
            this.pnlContainBill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caLàmViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProductCategory;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOfProductCategory;
        private System.Windows.Forms.Panel pnlOfHai;
        private System.Windows.Forms.ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOfDat;
        private System.Windows.Forms.ToolStripMenuItem khuyếnMãiToolStripMenuItem;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContainBill;
        private System.Windows.Forms.Label label3;
    }
}