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
        public ConveStoreDBContext dbContext;
        private List<SaleViewModel> sales;
        private List<ProductViewModel> Products;

        public SaleForm()
        {
            dbContext = new ConveStoreDBContext();
            InitializeComponent();
            loadcmbProductID();
            LoadSaleName();
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
            sales = dbContext.CHITITETKHUYENMAIs.Select(c => new SaleViewModel
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
            dgvSale.DataSource = sales;
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {


        }

        private void btnAddSale_Click_1(object sender, EventArgs e)
        {
            try
            {
                CHITITETKHUYENMAI km = new CHITITETKHUYENMAI()
                {
                    MaKM = txtSaleName.Text,
                    MaSP = cmbProductID.SelectedValue.ToString(),
                    NgayBatDau = dateTimePicker1.Value,
                    NgayKetThuc = dateTimePicker2.Value,
                    MucGiaKhuyenMai = Double.Parse(txtSalePrice.Text)

                };
                dbContext.CHITITETKHUYENMAIs.Add(km);
                dbContext.SaveChanges();
                MessageBox.Show("Thanh Cong");
                LoadSaleName();
                BindToGrid(sales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "That Bai");
            }

        }

        private void btnAddSale_Click_2(object sender, EventArgs e)
        {
            try
            {
                CHITITETKHUYENMAI km = new CHITITETKHUYENMAI()
                {
                    MaKM = txtSaleName.Text,
                    MaSP = cmbProductID.SelectedValue.ToString(),
                    NgayBatDau = dateTimePicker1.Value,
                    NgayKetThuc = dateTimePicker2.Value,
                    MucGiaKhuyenMai = Double.Parse(txtSalePrice.Text)

                };
                dbContext.CHITITETKHUYENMAIs.Add(km);
                dbContext.SaveChanges();
                MessageBox.Show("Thanh Cong");
                LoadSaleName();
                BindToGrid(sales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "That Bai");
            }
        }

        private void btnDeleteSale_Click_1(object sender, EventArgs e)
        {
            try
            {
                var salesToDelete = dbContext.CHITITETKHUYENMAIs.Where(x => x.MaKM == txtSaleName.Text).ToList();


                if (salesToDelete.Any())
                {
                    dbContext.CHITITETKHUYENMAIs.RemoveRange(salesToDelete);
                    dbContext.SaveChanges();
                    MessageBox.Show("Xóa thành công!");

                    LoadSaleName();
                    BindToGrid(sales);
                }
                else
                {
                    MessageBox.Show("Không Có");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
        }

        private void btnSearchSale_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maKM = txtSaleName.Text.Trim();
                if (string.IsNullOrEmpty(maKM))
                {
                    MessageBox.Show("Vui lòng nhập mã khuyến mãi để tìm kiếm.");
                    return;
                }

                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    row.Selected = false;
                }

                bool found = false;
                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    var saleViewModel = row.DataBoundItem as SaleViewModel;
                    if (saleViewModel != null && saleViewModel.MaKM.Equals(maKM, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Không tìm thấy khuyến mãi với mã đã nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }

}
