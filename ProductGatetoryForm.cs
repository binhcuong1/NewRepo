using QuanLyCuaHang.Ultilities;
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

namespace QuanLyCuaHang
{
    public partial class ProductGatetoryForm : Form
    {
        // Dùng để lưu giữ giá trị MaSP hiện tại khi click vào dgv
        string currProductID = string.Empty;

        ConveStoreDBContext db;

        List<ProductViewModel> productList;

        List<SupplierViewModel> supplierList;

        public ProductGatetoryForm()
        {
            InitializeComponent();

            db = new ConveStoreDBContext();

            LoadProducts();

            LoadSuppliers();

            dgvProductGatetoryOfForm.CellClick += dgvProductGatetoryOfForm_CellContentClick;
        }

        private void ProductGatetoryForm_Load(object sender, EventArgs e)
        {
            // Đưa panel về sau
            pnlAddProduct.Visible = false;

            BindToComboBox();

            BindToGrid(productList);
        }

        #region Load Data Methods
        private void LoadSuppliers()
        {
            supplierList = db.NHACUNGCAPs.Select(ncc => new SupplierViewModel
            {
                MaNCC = ncc.MaNCC,
                TenNCC = ncc.TenNCC,
                DiaChi = ncc.TenNCC + "-" + ncc.MaNCC
            }).ToList();
        }

        private void LoadProducts()
        {
            productList = db.SANPHAMs.Select(sp => new ProductViewModel
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                DonGia = sp.DonGiA.ToString(),
                TenNCC = sp.NHACUNGCAP.TenNCC,
                TenTheLoai = sp.LOAISANPHAM.TenTheLoai,
            }).ToList();
        }
        #endregion

        #region Bind Methods
        private void BindToComboBox()
        {
            cmbSupplier.DataSource = supplierList;

            // Chỉ định thuộc tính sẽ hiển thị trong cmb
            cmbSupplier.DisplayMember = "TenNCC";

            // Chỉ định thuộc tính chứa giá trị thực tế mà ComboBox lưu trữ
            cmbSupplier.ValueMember = "MaNCC";

            cmbSupplier.SelectedIndex = -1;
        }

        private void BindToGrid(List<ProductViewModel> currList)
        {
            // Thiết lập tên của cột sẽ hiển thị thuộc tính trong dgv
            dgvProductGatetoryOfForm.Columns["column1"].DataPropertyName = "MaSP";
            dgvProductGatetoryOfForm.Columns["column2"].DataPropertyName = "TenSP";
            dgvProductGatetoryOfForm.Columns["column3"].DataPropertyName = "DonGia";
            dgvProductGatetoryOfForm.Columns["column4"].DataPropertyName = "TenNCC";
            dgvProductGatetoryOfForm.Columns["column5"].DataPropertyName = "TenTheLoai";

            dgvProductGatetoryOfForm.DataSource = currList;
        }
        #endregion

        #region Button Methods
        private void BtnFilterDataOfProductGate_Click(object sender, EventArgs e)
        {
            try
            {
                bool isEmptyTxtNameOrID = string.IsNullOrEmpty(txtSearchIDorNameOfProduct.Text);
                bool isEmptyComboBox = cmbSupplier.SelectedIndex == -1;

                if (!isEmptyTxtNameOrID
                    && !isEmptyComboBox)
                {
                    FilterDataByNameOrIDAndSupp();
                    ResetInputProGateFrm();
                }
                else if (!isEmptyTxtNameOrID)
                {
                    FilterDataByIDorName();
                    ResetInputProGateFrm();
                }
                else if (!isEmptyComboBox)
                {
                    FilterDataBySupplier();
                    ResetInputProGateFrm();
                }
                else
                    throw new Exception("Chưa chọn giá trị để lọc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút reset lại bảng dgv
        private void btnResetGrid_Click(object sender, EventArgs e)
        {
            ResetInputProGateFrm();

            LoadProducts();

            BindToGrid(productList);
        }

        private void btnOpenProductUC_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlAddProduct);

            pnlAddProduct.Visible = true;

            AddProductUC addProductUC = new AddProductUC(ref pnlAddProduct);
            pnlAddProduct.Controls.Add(addProductUC);
            addProductUC.Dock = DockStyle.Fill;
        }

        private void BtnBackToHomePage_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            this.Hide();
            homePageForm.Show();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currProductID))
                    throw new Exception("Hãy click vào sản phẩm cần xóa");

                SANPHAM productToDelete = db.SANPHAMs.FirstOrDefault(sp => sp.MaSP == currProductID);

                if (productToDelete is null)
                    throw new Exception("Không tìm thấy sản phẩm, hãy làm mới lại bảng");
                else
                {
                    DialogResult resultYesOrNo = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultYesOrNo == DialogResult.Yes)
                    {
                        db.SANPHAMs.Remove(productToDelete);
                        db.SaveChanges();

                        LoadProducts();
                        BindToGrid(productList);
                        
                        throw new Exception("Xóa sản phẩm thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                currProductID = string.Empty;
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Filter Data Methods
        // Phương thức lọc dữ liệu cho cả nhà cung cấp và tên
        private void FilterDataByNameOrIDAndSupp()
        {
            // Lấy mã Nhà cung cấp từ combo box
            string searchSupplierValue = cmbSupplier.SelectedValue.ToString().Trim().ToLower();

            // Lấy giá trị từ TextBox
            string searchNameOrIDValue = txtSearchIDorNameOfProduct.Text.Trim().ToLower();

            List<ProductViewModel> currList = db.SANPHAMs
                .Where(sp => sp.NHACUNGCAP.MaNCC.ToLower().Trim().Contains(searchSupplierValue)
                && sp.MaSP.ToLower().Contains(searchNameOrIDValue)
                || sp.TenSP.ToLower().Contains(searchNameOrIDValue))
                .Select(sp => new ProductViewModel
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.DonGiA.ToString(),
                    TenNCC = sp.NHACUNGCAP.TenNCC,
                    TenTheLoai = sp.LOAISANPHAM.TenTheLoai
                }).ToList();

            // Dùng list hiện tại để đồng bộ với grid
            BindToGrid(currList);
        }

        // Phương thức lọc dữ liệu theo tên
        private void FilterDataBySupplier()
        {
            // Lấy mã Nhà cung cấp từ combo box
            string searchValue = cmbSupplier.SelectedValue.ToString().Trim().ToLower();

            List<ProductViewModel> currList = db.SANPHAMs
                .Where(sp => sp.NHACUNGCAP.MaNCC.ToLower().Trim().Contains(searchValue))
                .Select(sp => new ProductViewModel
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.DonGiA.ToString(),
                    TenNCC = sp.NHACUNGCAP.TenNCC,
                    TenTheLoai = sp.LOAISANPHAM.TenTheLoai
                }).ToList();

            // Dùng list hiện tại để đồng bộ với grid
            BindToGrid(currList);
        }

        // Phương thức lọc dữ liệu theo ID hoặc Tên sp
        private void FilterDataByIDorName()
        {
            // Lấy giá trị từ TextBox
            string searchValue = txtSearchIDorNameOfProduct.Text.Trim().ToLower();

            // Lọc dữ liệu theo MaSP hoặc TenSP bằng LINQ
            List<ProductViewModel> currList = db.SANPHAMs
                .Where(sp => sp.MaSP.ToLower().Contains(searchValue) || sp.TenSP.ToLower().Contains(searchValue))
                .Select(sp => new ProductViewModel
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.DonGiA.ToString(),
                    TenNCC = sp.NHACUNGCAP.TenNCC,
                    TenTheLoai = sp.LOAISANPHAM.TenTheLoai
                })
                .ToList();

            BindToGrid(currList);
        }
        #endregion

        // Phương thức reset lại các giá trị input
        private void ResetInputProGateFrm()
        {
            txtSearchIDorNameOfProduct.Text = string.Empty;
            cmbSupplier.SelectedIndex = -1;
        }

        private void CenterPanel(Panel panel)
        {
            // Tính toán vị trí để đặt panel ở giữa form
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;

            // Gán vị trí cho panel
            panel.Location = new Point(x, y);
        }

        private void dgvProductGatetoryOfForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng hiện tại có hợp lệ không (dòng tiêu đề không được tính)
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của cột "MaSP" từ dòng được click
                string ProductID = dgvProductGatetoryOfForm.Rows[e.RowIndex].Cells["column1"].Value.ToString();

                currProductID = ProductID;
            }
        }
    }
}
