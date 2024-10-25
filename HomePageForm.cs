using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using QuanLyCuaHang.UserControls;
using QuanLyCuaHang.Ultilities;

namespace QuanLyCuaHang
{
    public partial class HomePageForm : Form
    {
        private string originalText;
        public HomePageForm()
        {
            InitializeComponent();
            pnlOfDat.SendToBack();
            pnlOfHai.SendToBack();
            originalText = "Cương khùngggg nha ae !          ";
            lblNote.Text = originalText;
            timerNote.Start();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            OpenUserControl(new OutputBillUC(), pnlOfHai);

            lblHelloUser.BringToFront();
        }

        // Hàm mở form
        void OpenForm(Form f)
        {
            f.Show();
            this.Hide();
        }

        // Hàm mở usercontrol
        void OpenUserControl(UserControl uc, Panel pnl)
        {
            Ultilities.Services.SetCenterPanel(this, pnl);
            pnlOfHai.Visible = true;
            pnlOfHai.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnl.Controls.Add(uc);
        }

        public HomePageForm(string roleCurrent)
        {
            InitializeComponent();

            DisplayRoleCurrent(roleCurrent);

            DisplayHelloUser();

            AssignPermissionsByRole();
        }

        #region Phân quyền & Hiển thị quyền 

        private void DisplayRoleCurrent(string roleCurrrent)
        {
            string text = "Bạn đang truy cập với quyền " + roleCurrrent;
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayHelloUser()
        {
            string tenNhanVien = UserSession.TenNhanVien;
            string chucVu = UserSession.ChucVu;

            lblHelloUser.Text = $"Xin chào, {tenNhanVien}\nChức vụ: {chucVu}";
            lblHelloUser.SendToBack();
        }

        // Phương thức phân quyền
        private void AssignPermissionsByRole()
        {
            string chucVu = UserSession.ChucVu;

            if (chucVu != "Admin" && chucVu != "Quản lý")
            {
                //ẩn gì thì cài đạt
            }
        }

        #endregion

        // Nút mở ra danh mục sản phẩm
        private void ToolStripMenu_ProductCategory_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductGatetoryForm());
        }

        // Nút mở ra ca làm việc
        private void ToolStripMenu_Shift_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ShiftUC(), pnlOfHai);
        }

        // Nút mở ra danh sách nhân viên
        private void ToolStripMenuItem_StaffList_Click(object sender, EventArgs e)
        {
            OpenForm(new StaffForm());
        }

        // Nút mở ra xuất hóa đơn
        private void ToolStripMenu_OutputBill_Click(object sender, EventArgs e)
        {
            lblHelloUser.Visible = false;
            OpenUserControl(new OutputBillUC(), pnlOfHai);
        }

        // Nút mở ra xem hóa đơn
        private void ToolStripMenuItem_BillView_Click(object sender, EventArgs e)
        {
            lblHelloUser.Visible = false;
            OpenUserControl(new BillListUC(), pnlOfHai);
            lblOutPutBill.SendToBack();
        }

        // Nút mở ra thông tin khách hàng
        private void ToolStripMenuItem_CustomerInfo_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerIntoForm());
        }

        // Nút mở ra khuyến mãi
        private void ToolStripMenuItem_Sale_Click(object sender, EventArgs e)
        {
            OpenForm(new SaleForm());
        }


        #region Không đụng vào cái này
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private ToolStripMenuItem khuyếnMãiToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem tsmProductCategory;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem lươngToolStripMenuItem;
        private ToolStripMenuItem caLàmViệcToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ContextMenuStrip contextMenuStrip2;
        private Panel pnlOfHai;
        private Label lblHelloUser;
        private Label lblOutPutBill;
        private Button button2;
        private Label lblNote;
        private Timer timerNote;
        private Panel pnlOfDat;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.khuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlOfHai = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlOfDat = new System.Windows.Forms.Panel();
            this.lblHelloUser = new System.Windows.Forms.Label();
            this.lblOutPutBill = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.timerNote = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.pnlOfHai.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến Mãi";
            this.khuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Sale_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_CustomerInfo_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // xemHóaĐơnToolStripMenuItem
            // 
            this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
            this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.xemHóaĐơnToolStripMenuItem.Text = "Xem Hóa Đơn";
            this.xemHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_BillView_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHóaĐơnToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // tsmProductCategory
            // 
            this.tsmProductCategory.Name = "tsmProductCategory";
            this.tsmProductCategory.Size = new System.Drawing.Size(228, 26);
            this.tsmProductCategory.Text = "Danh Mục Sản Phẩm";
            this.tsmProductCategory.Click += new System.EventHandler(this.ToolStripMenu_ProductCategory_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProductCategory});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.lươngToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            this.lươngToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_StaffList_Click);
            // 
            // caLàmViệcToolStripMenuItem
            // 
            this.caLàmViệcToolStripMenuItem.Name = "caLàmViệcToolStripMenuItem";
            this.caLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.caLàmViệcToolStripMenuItem.Text = "Ca Làm Việc";
            this.caLàmViệcToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_Shift_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caLàmViệcToolStripMenuItem,
            this.lươngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.toolStripMenuItem1.Text = "Nhân Viên";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
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
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(46, 36);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1924, 40);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlOfHai
            // 
            this.pnlOfHai.Controls.Add(this.button2);
            this.pnlOfHai.Location = new System.Drawing.Point(1803, 946);
            this.pnlOfHai.Name = "pnlOfHai";
            this.pnlOfHai.Size = new System.Drawing.Size(908, 592);
            this.pnlOfHai.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, -162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 262);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlOfDat
            // 
            this.pnlOfDat.Location = new System.Drawing.Point(157, 946);
            this.pnlOfDat.Name = "pnlOfDat";
            this.pnlOfDat.Size = new System.Drawing.Size(1341, 68);
            this.pnlOfDat.TabIndex = 8;
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloUser.AutoSize = true;
            this.lblHelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloUser.Location = new System.Drawing.Point(297, 114);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(333, 38);
            this.lblHelloUser.TabIndex = 9;
            this.lblHelloUser.Text = "Hiển thị thông tin user";
            // 
            // lblOutPutBill
            // 
            this.lblOutPutBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutPutBill.AutoSize = true;
            this.lblOutPutBill.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPutBill.Location = new System.Drawing.Point(854, 172);
            this.lblOutPutBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutPutBill.Name = "lblOutPutBill";
            this.lblOutPutBill.Size = new System.Drawing.Size(266, 45);
            this.lblOutPutBill.TabIndex = 11;
            this.lblOutPutBill.Text = "Xuất Hóa Đơn";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Black;
            this.lblNote.Location = new System.Drawing.Point(28, 505);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(275, 32);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "Note";
            this.lblNote.Click += new System.EventHandler(this.timerNote_Click);
            // 
            // timerNote
            // 
            this.timerNote.Tick += new System.EventHandler(this.timerNote_Click);
            // 
            // HomePageForm
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 1009);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblOutPutBill);
            this.Controls.Add(this.lblHelloUser);
            this.Controls.Add(this.pnlOfHai);
            this.Controls.Add(this.menuStrip2);
            this.Name = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlOfHai.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private void timerNote_Click(object sender, EventArgs e)
        {
            originalText = originalText.Substring(1) + originalText[0];

            // Cập nhật lại văn bản cho Label
            lblNote.Text = originalText;
        }
    }
}
