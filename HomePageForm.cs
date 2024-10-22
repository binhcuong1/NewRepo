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

namespace QuanLyCuaHang
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
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

        #region Clicks Of Product
        private void ToolStripMenu_ProductCategory_Click(object sender, EventArgs e)
        {
            //// Kiểm tra UC đã có trong panel chưa
            //bool isHaveControlUC = pnlOfProductCategory.Controls.Count > 0 && 
            //    pnlOfProductCategory.Controls[0] is UCProductCategory;

            //if (isHaveControlUC) return;

            //SetUpLayoutForPnl(pnlOfProductCategory, 650, 400);

            //// Thiết lập panel ở giữa form
            //SetUpCenterPanel(pnlOfProductCategory);

            //// Xóa các control cũ trước khi thêm control mới
            //pnlOfProductCategory.Controls.Clear();

            //// Khởi tạo User Control và add vào panel
            //UCProductCategory uCProductCategory = new UCProductCategory();
            //pnlOfProductCategory.Controls.Add(uCProductCategory);

            ProductGatetoryForm productGatetoryForm = new ProductGatetoryForm();
            productGatetoryForm.Show();
            this.Hide();
        }
        #endregion

        private void SetUpCenterPanel(Panel panelCurr)
        {
            // Lấy kích thước của Form
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Lấy kích thước của Panel
            int panelWidth = pnlOfProductCategory.Width;
            int panelHeight = pnlOfProductCategory.Height;

            // Tính toán vị trí để đặt Panel ở giữa màn hình
            int panelX = (formWidth - panelWidth) / 2;
            int panelY = (formHeight - panelHeight) / 2;

            // Thiết lập vị trí mới cho Panel
            pnlOfProductCategory.Location = new Point(panelX, panelY);
        }

        private void SetUpLayoutForPnl(Panel pnlCurr, int width, int height)
        {
            pnlCurr.Width = width;
            pnlCurr.Height = height;
        }

        private void ToolStripMenu_CaLamViec_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlOfHai);
            ShiftUC userControl = new ShiftUC();
            pnlOfHai.Visible = true;
            pnlOfHai.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlOfHai.Controls.Add(userControl);
        }

        private void OutPutBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlOfHai);
            OutputBillUC userControl2 = new OutputBillUC();
            pnlOfHai.Visible = true;
            pnlOfHai.Controls.Clear();
            userControl2.Dock = DockStyle.Fill;
            pnlOfHai.Controls.Add(userControl2);
        }

        private void BillViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlOfHai);
            BillListUC userControl3 = new BillListUC();
            pnlOfHai.Visible = true;
            pnlOfHai.Controls.Clear();
            userControl3.Dock = DockStyle.Fill;
            pnlOfHai.Controls.Add(userControl3);
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlOfDat);
            pnlOfDat.Visible = true;
            CustomerInfoUC userControl = new CustomerInfoUC();
            pnlOfDat.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlOfDat.Controls.Add(userControl);
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlOfDat);
            pnlOfDat.Visible = true;
            pnlOfDat.Controls.Clear();
            PurchaseHistoryUC lichSuMuaHangUC = new PurchaseHistoryUC();
            lichSuMuaHangUC.Dock = DockStyle.Fill;
            pnlOfDat.Controls.Add(lichSuMuaHangUC);
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.ShowDialog();
        }
    }
}
