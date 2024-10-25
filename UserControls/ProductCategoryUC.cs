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
using QuanLyCuaHang.Model;

namespace QuanLyCuaHang
{
    public partial class ProductCategoryUC : UserControl
    {
        ConveStoreDBContext db;
        List<ProductViewModel> products;

        public ProductCategoryUC()
        {
            InitializeComponent();

            db = new ConveStoreDBContext();
            products = new List<ProductViewModel>(); 

            LoadProducts();
        }

        private void UCProductCategory_Load(object sender, EventArgs e)
        {

            SetWidthAndHeightForDGV(dgvProductCategory);

            SetCenterAndBelowDGV();

            BindToGrid(products);
        }

        #region Methods bind data from list to Data grid view
        public void BindToGrid(List<ProductViewModel> listCurr)
        {
            dgvProductCategory.DataSource = listCurr;
        }
        #endregion

        #region Methods Load Data
        public void LoadProducts()
        {
            products = db.SANPHAMs.Select(sp => new ProductViewModel
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                DonGia = sp.DonGia.ToString(),
                TenNCC = sp.NHACUNGCAP.TenNCC,
                TenTheLoai = sp.LOAISANPHAM.TenTheLoai,
            }).ToList();

        }
        #endregion

        // Thiết lập chiều dài và chiều rộng cho dgv
        private void SetWidthAndHeightForDGV(DataGridView dgvCurr)
        {
            dgvCurr.Width = (int)(this.Width * 0.8);  // Chiều rộng chiếm 80% của UserControl
            dgvCurr.Height = (int)(this.Height * 0.6);
        }

        // Thiết lập dgv ở giữa và phần dưới UC
        private void SetCenterAndBelowDGV()
        {
            // Lấy kích thước của UC
            int UCWidth = this.Width;
            int UCHeight = this.Height;

            // Lấy kích thước của Dgv
            int dgvWidth = dgvProductCategory.Width;
            int dgvHeight = dgvProductCategory.Height;

            // Tính toán vị trí để đặt dgv ở giữa UC
            int dgvX = (UCWidth - dgvWidth) / 2;
            int dgvY = (UCHeight - dgvHeight) / 2;

            // Đặt lại vị trí mới cho dgv
            dgvProductCategory.Location = new Point(dgvX, dgvY);
        }

        private void dgvProductCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
