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
    public partial class PurchaseHistoryForm : Form
    {
        public ConveStoreDBContext dbContext;
        private List<PurchaseHistoryViewModel> purchaseHistoryList;

        public PurchaseHistoryForm()
        {
            InitializeComponent();

            dbContext = new ConveStoreDBContext();
            LoadData();
            //dataGridView1.RowHeadersVisible = false;
            //dgvBillInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgvBillInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PurchaseHistoryForm_Load(object sender, EventArgs e)
        {
            BindToGrid();
        }

        private void LoadData()
        {
            var rawData = dbContext.HOADONs
        .Select(hd => new
        {
            SoHD = hd.SoHD,
            NgayLap = hd.NgayLap,
            GhiChu = hd.GhiChu,
            TongTien = hd.CHITIETHOADONs.Sum(ct => (double?)ct.ThanhTien) ?? 0
        })
        .ToList();


            purchaseHistoryList = rawData
                .Select(hd => new PurchaseHistoryViewModel
                {
                    SoHD = hd.SoHD,
                    NgayLap = hd.NgayLap.HasValue ? hd.NgayLap.Value.ToString("dd/MM/yyyy") : string.Empty,
                    GhiChu = hd.GhiChu,
                    TongTien = hd.TongTien
                })
                .ToList();
        }

        private void BindToGrid()
        {
            dgvBillInfo.DataSource = purchaseHistoryList;

        }


        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchSoHD = txtTimKiem.Text.Trim();

            // Kiểm tra nếu người dùng đã nhập SoHD
            if (!string.IsNullOrEmpty(searchSoHD))
            {
                // Tìm kiếm hóa đơn theo SoHD
                var searchResult = purchaseHistoryList
                    .Where(hd => hd.SoHD.Contains(searchSoHD)) // Tìm các hóa đơn khớp với SoHD nhập
                    .ToList();

                // Kiểm tra nếu tìm thấy kết quả
                if (searchResult.Count > 0)
                {
                    dgvBillInfo.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào với số hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hóa đơn để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadInvoiceDetails(string soHD)
        {
            var invoiceDetails = dbContext.CHITIETHOADONs
                .Where(ct => ct.SoHD == soHD)
                .Select(ct => new InvoiceDetailViewModel
                {
                    MaSP = ct.MaSP,
                    TenSP = ct.SANPHAM.TenSP, // Get product name
                    SoLuong = ct.SoLuong ?? 0, // Default to 0 if null
                    DonGia = ct.SANPHAM.DonGiA ?? 0, // Get product unit price
                    ThanhTien = ct.ThanhTien ?? 0 // Get total price
                })
                .ToList();

            // Bind the result to dgvInvoiceDetails
            dgvInvoiceDetails.DataSource = invoiceDetails;
        }

        private void btnViewDetails_Click_1(object sender, EventArgs e)
        {
            if (dgvBillInfo.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                var selectedRow = dgvBillInfo.SelectedRows[0];

                // Lấy giá trị SoHD từ dòng đã chọn
                string selectedSoHD = selectedRow.Cells["SoHD"].Value.ToString();

                // Gọi phương thức để tải chi tiết hóa đơn dựa trên SoHD đã chọn
                LoadInvoiceDetails(selectedSoHD);
            }
            else if (txtFindDetails.Text.Trim() != null)
            {
                var maHDtoDetails = txtFindDetails.Text;
                LoadInvoiceDetails(maHDtoDetails);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết.", "Không có lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

            // Làm mới giao diện hiển thị dữ liệu
            BindToGrid();

            // Xóa dữ liệu hiển thị hiện tại của dgvInvoiceDetails (nếu có)
            dgvInvoiceDetails.DataSource = null;

            MessageBox.Show("Dữ liệu đã được làm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                HomePageForm homePageForm = new HomePageForm();
                this.Hide();
                homePageForm.Show();
            }
        }
    }
}
