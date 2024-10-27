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

// source that

namespace QuanLyCuaHang
{
    public partial class SaleForm : Form
    {
        string currNameSale = string.Empty;

        public ConveStoreDBContext dbContext;
        private List<SaleViewModel> sales;
        private List<ProductViewModel> Products;

        public SaleForm()
        {
            dbContext = new ConveStoreDBContext();
            InitializeComponent();
            loadcmbProductID();
            LoadSaleName();

            dgvSale.CellClick += dgvSaleForm_CellContentClick;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            BindToGrid(sales);
            BindTocmbProductID(Products);
        }

        private void loadcmbProductID()
        {
            Products = dbContext.SANPHAMs.Select(x => new ProductViewModel
            {
                MaSP = x.MaSP,
                TenSP = x.TenSP

            }).ToList();
        }

        private void LoadSaleName()
        {
            sales = dbContext.CHITITETKHUYENMAIs
                .Where(c => c.KHUYENMAI.TenKM != "đã xóa")
                .Select(c => new SaleViewModel
            {
                MaKM = c.MaKM,
                TenKM = c.KHUYENMAI.TenKM,
                TenSP = c.SANPHAM.TenSP,
                MucGiaKhuyenMai = c.MucGiaKhuyenMai,
                NgayBatDau = c.NgayBatDau,
                NgayKetThuc = c.NgayKetThuc
            }).ToList();

        }

        private void KhuyenMaiForm_Load(object sender, EventArgs e)
        {
            BindToGrid(sales);
            BindTocmbProductID(Products);
        }

        private void BindTocmbProductID(List<ProductViewModel> products)
        {
            cmbProductID.DataSource = products;
            cmbProductID.DisplayMember = "TenSP";
            cmbProductID.ValueMember = "MaSP";
        }

        private void BindToGrid(List<SaleViewModel> sales)
        {
            // Thiết lập tên của cột sẽ hiển thị thuộc tính trong dgv
            dgvSale.Columns["column1"].DataPropertyName = "TenKM";
            dgvSale.Columns["column2"].DataPropertyName = "TenSP";
            dgvSale.Columns["column3"].DataPropertyName = "MucGiaKhuyenMai";
            dgvSale.Columns["column4"].DataPropertyName = "NgayBatDau";
            dgvSale.Columns["column5"].DataPropertyName = "NgayKetThuc";

            dgvSale.DataSource = sales;

            if (dgvSale.Columns.Contains("MaKM"))
            {
                dgvSale.Columns["MaKM"].Visible = false;
            }
        }

        private void btnAddSale_Click_2(object sender, EventArgs e)
        {
            try
            {
                bool isEmptyInput = cmbProductID.SelectedIndex == -1
                    || string.IsNullOrEmpty(txtSalePrice.Text)
                    || string.IsNullOrEmpty(txtSaleName.Text);

                if (isEmptyInput)
                    throw new Exception("Hãy điền đầy đủ các thông tin");

                KHUYENMAI newKhuyenMai = new KHUYENMAI();
                newKhuyenMai.MaKM = CreateNewSaleID();
                newKhuyenMai.TenKM = txtSaleName.Text;

                dbContext.KHUYENMAIs.Add(newKhuyenMai);
                dbContext.SaveChanges();

                CHITITETKHUYENMAI newCTKM = new CHITITETKHUYENMAI();
                newCTKM.MaKM = newKhuyenMai.MaKM;
                newCTKM.MaSP = cmbProductID.SelectedValue.ToString();
                newCTKM.NgayBatDau = dtNgayBatDau.Value;
                newCTKM.NgayKetThuc = dtNgayKetThuc.Value;
                newCTKM.MucGiaKhuyenMai = double.Parse(txtSalePrice.Text);

                dbContext.CHITITETKHUYENMAIs.Add(newCTKM);
                dbContext.SaveChanges();
                throw new Exception("Thêm khuyến mãi thành công");
            }
            catch (Exception ex)
            {
                LoadSaleName();

                BindToGrid(sales);

                ResetInputSaleFrm();

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteSale_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currNameSale))
                    throw new Exception("Hãy click vào 1 khuyến mãi mãi để xóa");

                KHUYENMAI saleToDelete = dbContext.KHUYENMAIs
                    .FirstOrDefault(km => km.TenKM.ToLower().Contains(currNameSale.ToLower()));

                saleToDelete.TenKM = "đã xóa";

                dbContext.SaveChanges();
                throw new Exception("Xóa khuyến mãi thành công");
            }
            catch (Exception ex)
            {
                currNameSale = string.Empty;

                LoadSaleName();

                BindToGrid(sales);

                ResetInputSaleFrm();

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductID.SelectedIndex == -1)
                    throw new Exception("Chưa chọn sản phẩm để lọc");

                string valueToSearch = cmbProductID.SelectedValue.ToString();

                var currList = dbContext.CHITITETKHUYENMAIs
                    .Where(km => km.MaSP == valueToSearch)
                    .Select(km => new SaleViewModel
                    {
                        MaKM = km.MaKM,
                        TenKM = km.KHUYENMAI.TenKM,
                        TenSP = km.SANPHAM.TenSP,
                        MucGiaKhuyenMai = km.MucGiaKhuyenMai,
                        NgayBatDau = km.NgayBatDau,
                        NgayKetThuc = km.NgayKetThuc
                    })
                    .ToList();

                BindToGrid(currList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnResetGrid_Click(object sender, EventArgs e)
        {
            LoadSaleName();

            BindToGrid(sales);

            ResetInputSaleFrm();
        }

        private string CreateNewSaleID()
        {
            var numOfSaleList = dbContext.KHUYENMAIs.Count();

            string result = string.Empty;
            bool isTwoDigitNumber = numOfSaleList <= 98 && numOfSaleList >= 9;
            bool isThreeDigitNumber = numOfSaleList <= 998 && numOfSaleList >= 99;

            numOfSaleList += 2;

            if (isTwoDigitNumber)
                result = "KM0" + numOfSaleList.ToString().Trim();
            else if (isThreeDigitNumber)
                result = "KM" + numOfSaleList.ToString().Trim();

            return result;
        }

        private void ResetInputSaleFrm()
        {
            txtSaleName.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            cmbProductID.SelectedIndex = -1;
        }

        private void dgvSaleForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string saleID = dgvSale.Rows[e.RowIndex].Cells["column1"].Value.ToString();

                currNameSale = saleID;
            }
        }
    }
}  
