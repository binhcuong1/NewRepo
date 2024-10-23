﻿using QuanLyCuaHang.ViewModel;
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

namespace QuanLyCuaHang
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        // Hàm mở form
        void OpenForm(Form f)
        {
            //ProductGatetoryForm productGatetoryForm = new ProductGatetoryForm();
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
        }

        private void DisplayRoleCurrent(string roleCurrrent)
        {
            string text = "Bạn đang truy cập với quyền " + roleCurrrent;
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
             
        }

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

        // Nút mở ra xuất hóa đơn
        private void ToolStripMenu_OutputBill_Click(object sender, EventArgs e)
        {
            OpenUserControl(new OutputBillUC(), pnlOfHai);
        }

        private void ToolStripMenuItem_BillView_Click(object sender, EventArgs e)
        {
            OpenUserControl(new BillListUC(), pnlOfHai);
        }

        private void ToolStripMenuItem_CustomerInfo_Click(object sender, EventArgs e)
        {
            OpenUserControl(new CustomerInfoUC(), pnlOfDat);
        }

        private void ToolStripMenuItem_PurchaseHistory_Click(object sender, EventArgs e)
        {
            OpenUserControl(new PurchaseHistoryUC(), pnlOfDat);
        }

        private void ToolStripMenuItem_Sale_Click(object sender, EventArgs e)
        {
            OpenForm(new SaleForm());
        }
    }
}
