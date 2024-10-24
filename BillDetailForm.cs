using QuanLyCuaHang.UserControls;
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
        private string selectedSoHD;
        private string selevtedMaKH;

        public BillDetailForm()
        {
            InitializeComponent();
        }

        // Constructor nhận soHD và customerName từ event click
        public BillDetailForm(string soHD, string customerName, string maKH)
        {
            InitializeComponent();

            // Gán tên khách hàng vào label
            lblCustomerName.Text = customerName;

            // Load dữ liệu chi tiết hóa đơn dựa trên soHD

            selectedSoHD = soHD;
            selevtedMaKH = maKH;

            LoadChiTietHoaDon();
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }

        // Phương thức xử lý logic LoadChiTietHoaDon nằm trực tiếp trong Form
        public void LoadChiTietHoaDon()
        {
            // Sử dụng selectedSoHD đã được gán
            var chiTietHoaDon = dbContext.CHITIETHOADONs
                .Where(ct => ct.SoHD == selectedSoHD)  // Sử dụng selectedSoHD
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
        private void btnRefund_Click(object sender, EventArgs e)
        {
            // Lấy nội dung phản hồi từ textbox
            var phanHoi = txtCustomerFeedback.Text;

            if (string.IsNullOrWhiteSpace(phanHoi))
            {
                MessageBox.Show("Vui lòng nhập nội dung phản hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo mã phản hồi mới (MaPH) với định dạng PH001, PH002,...
            var lastPhanHoi = dbContext.PHANHOIKHACHHANGs.OrderByDescending(ph => ph.MaPH).FirstOrDefault();
            string newMaPH;

            if (lastPhanHoi != null)
            {
                // Lấy số từ MaPH cuối cùng và tăng lên 1
                int lastMaNumber = int.Parse(lastPhanHoi.MaPH.Substring(2));
                newMaPH = "PH" + (lastMaNumber + 1).ToString("D3");
            }
            else
            {
                // Nếu không có phản hồi nào trước đó, bắt đầu từ PH001
                newMaPH = "PH001";
            }

            // Tạo đối tượng phản hồi mới
            var phanHoiKhachHang = new PHANHOIKHACHHANG
            {
                MaPH = newMaPH,
                MaKH = selevtedMaKH,
                NoiDung = phanHoi,
                NgayPhanHoi = DateTime.Now // Gán ngày phản hồi hiện tại
            };

            // Thêm phản hồi vào database
            dbContext.PHANHOIKHACHHANGs.Add(phanHoiKhachHang);
            dbContext.SaveChanges();

            // Tìm hóa đơn hiện tại dựa trên số hóa đơn (soHD), cập nhật GhiChu
            var hoaDon = dbContext.HOADONs.FirstOrDefault(hd => hd.SoHD == selectedSoHD); // Giả sử bạn có biến selectedSoHD chứa số hóa đơn
            if (hoaDon != null)
            {
                hoaDon.MaPH = newMaPH;
                hoaDon.GhiChu = "Đã hoàn trả";
                dbContext.SaveChanges(); // Lưu thay đổi
            }

            MessageBox.Show("Đã gửi phản hồi và cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi thêm, có thể làm trống textbox nếu muốn
            txtCustomerFeedback.Clear();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            // Lấy nội dung phản hồi từ textbox
            var phanHoi = txtCustomerFeedback.Text;

            if (string.IsNullOrWhiteSpace(phanHoi))
            {
                MessageBox.Show("Vui lòng nhập nội dung phản hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo mã phản hồi mới (MaPH) với định dạng PH001, PH002,...
            var lastPhanHoi = dbContext.PHANHOIKHACHHANGs.OrderByDescending(ph => ph.MaPH).FirstOrDefault();
            string newMaPH;

            if (lastPhanHoi != null)
            {
                // Lấy số từ MaPH cuối cùng và tăng lên 1
                int lastMaNumber = int.Parse(lastPhanHoi.MaPH.Substring(2));
                newMaPH = "PH" + (lastMaNumber + 1).ToString("D3");
            }
            else
            {
                // Nếu không có phản hồi nào trước đó, bắt đầu từ PH001
                newMaPH = "PH001";
            }

            // Tạo đối tượng phản hồi mới
            var phanHoiKhachHang = new PHANHOIKHACHHANG
            {
                MaPH = newMaPH,
                MaKH = selevtedMaKH,
                NoiDung = phanHoi,
                NgayPhanHoi = DateTime.Now // Gán ngày phản hồi hiện tại
            };

            // Thêm phản hồi vào database
            dbContext.PHANHOIKHACHHANGs.Add(phanHoiKhachHang);
            dbContext.SaveChanges();

            // Tìm hóa đơn hiện tại dựa trên số hóa đơn (soHD), cập nhật GhiChu
            var hoaDon = dbContext.HOADONs.FirstOrDefault(hd => hd.SoHD == selectedSoHD); // Giả sử bạn có biến selectedSoHD chứa số hóa đơn
            if (hoaDon != null)
            {
                hoaDon.MaPH = newMaPH;
                hoaDon.GhiChu = "Đã điều chỉnh";
                dbContext.SaveChanges(); // Lưu thay đổi
            }

            MessageBox.Show("Đã điều chỉnh và cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi thêm, có thể làm trống textbox nếu muốn
            txtCustomerFeedback.Clear();
        }

        private void BillDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}
