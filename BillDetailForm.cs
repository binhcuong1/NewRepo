using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class BillDetailForm : Form
    {
        private ConveStoreDBContext dbContext = new ConveStoreDBContext(); // Khởi tạo DbContext ở đây

        public BillDetailForm()
        {
            InitializeComponent();
        }

        // Constructor nhận soHD và customerName từ event click
        public BillDetailForm(string soHD, string customerName)
        {
            InitializeComponent();

            // Gán tên khách hàng vào label
            lblCustomerName.Text = customerName;

            // Load dữ liệu chi tiết hóa đơn dựa trên soHD
            LoadChiTietHoaDon(soHD);
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }

        // Phương thức xử lý logic LoadChiTietHoaDon nằm trực tiếp trong Form
        public void LoadChiTietHoaDon(string soHD)
        {
            // Lấy danh sách chi tiết hóa đơn dựa trên số hóa đơn
            var chiTietHoaDon = dbContext.CHITIETHOADONs
                .Where(ct => ct.SoHD == soHD)
                .Select(ct => new BillDetailViewModel
                {
                    SoHD = ct.SoHD,
                    MaSP = ct.MaSP,
                    TenSP = ct.SANPHAM != null ? ct.SANPHAM.TenSP : "Không có tên sản phẩm", // Kiểm tra null
                    SoLuong = ct.SoLuong ?? 0,
                    DonGiA = ct.SANPHAM != null ? ct.SANPHAM.DonGiA ?? 0 : 0, // Kiểm tra null
                }).ToList();

            // Xử lý các phần không thể đưa vào truy vấn SQL (khuyến mãi và thành tiền)
            foreach (var item in chiTietHoaDon)
            {
                var khuyenMai = dbContext.CHITITETKHUYENMAIs
                    .FirstOrDefault(km => km.MaSP == item.MaSP);

                // Kiểm tra khuyến mãi và gán giá trị khuyến mãi
                item.MucGiaKhuyenMai = khuyenMai != null ? (khuyenMai.MucGiaKhuyenMai.HasValue ? khuyenMai.MucGiaKhuyenMai.Value.ToString() : "0") : "0";

                // Tính lại thành tiền sau khi áp dụng khuyến mãi (nếu có)
                var giaSanPham = khuyenMai != null ? (khuyenMai.MucGiaKhuyenMai ?? item.DonGiA) : item.DonGiA;
                item.ThanhTien = giaSanPham * item.SoLuong;
            }

            // Gán dữ liệu vào DataGridView
            dvgChiTietHoaDon.DataSource = chiTietHoaDon;
            dvgChiTietHoaDon.RowHeadersVisible = false;
            dvgChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tính tổng tiền
            double tongTien = chiTietHoaDon.Sum(ct => ct.ThanhTien);

            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VND";
        }
    }
}
