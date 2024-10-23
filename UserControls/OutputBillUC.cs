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

namespace QuanLyCuaHang.UserControls
{
    public partial class OutputBillUC : UserControl
    {
        private BillViewModel viewModel;
        private ConveStoreDBContext dbContext;
        private List<BillViewModel> billList = new List<BillViewModel>();

        public OutputBillUC()
        {
            InitializeComponent();
            viewModel = new BillViewModel();
            dbContext = new ConveStoreDBContext();

            cmbProductType.SelectedItem = null;
            cmbProduct.SelectedItem = null;

            dvgXuatHoaDon.RowHeadersVisible = false;
            dvgXuatHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgXuatHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OutputBillUC_Load(object sender, EventArgs e)
        {
            LoadProductGatetoryToComboBox();
            LoadProductToComboBox();
            LoadPaymentMethodToCombobox();
        }

        private void LoadProductToComboBox()
        {
            var loaiSanPhamList = dbContext.LOAISANPHAMs.ToList();

            cmbProductType.DataSource = loaiSanPhamList;
            cmbProductType.DisplayMember = "TenTheLoai";
            cmbProductType.ValueMember = "MaTheLoai";
        }

        private void LoadProductGatetoryToComboBox()
        {
            var loaiSanPhamList = dbContext.LOAISANPHAMs.ToList();

            cmbProductType.DataSource = loaiSanPhamList;
            cmbProductType.DisplayMember = "TenTheLoai";
            cmbProductType.ValueMember = "MaTheLoai";
        }

        public void LoadPaymentMethodToCombobox()
        {
            var hinhThucThanhToanList = dbContext.PHUONGTHUCTHANHTOANs.ToList();

            cmbPaymentMethod.DataSource = hinhThucThanhToanList;
            cmbPaymentMethod.DisplayMember = "PhuongThuc";
            cmbPaymentMethod.ValueMember = "MaLTT";
        }
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedItem == null || cmbProductType.SelectedValue == null)
            {
                return;
            }

            var selectedMaTheLoai = cmbProductType.SelectedValue.ToString();

            var sanPhamList = dbContext.SANPHAMs
                .Where(sp => sp.MaTheLoai == selectedMaTheLoai)
                .ToList();

            cmbProduct.DataSource = sanPhamList;
            cmbProduct.DisplayMember = "TenSP";
            cmbProduct.ValueMember = "MaSP";

            cmbProduct.SelectedItem = null;
        }
        private void bttAddProduct_Click(object sender, EventArgs e)
        {
            var selectedSanPham = cmbProduct.SelectedItem as SANPHAM;
            int soLuong = (int)numericUpDownSoLuong.Value;

            if (selectedSanPham != null)
            {
                var khuyenMai = dbContext.CHITITETKHUYENMAIs.FirstOrDefault(km => km.MaSP == selectedSanPham.MaSP);

                double donGia = selectedSanPham.DonGiA ?? 0;

                double giaSauKhuyenMai = (khuyenMai != null) ? khuyenMai.MucGiaKhuyenMai ?? donGia : donGia;

                var existingItem = billList.FirstOrDefault(item => item.MaSP == selectedSanPham.MaSP);

                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    existingItem.ThanhTien = giaSauKhuyenMai * existingItem.SoLuong;
                }
                else
                {
                    var hoaDonItem = new BillViewModel
                    {
                        MaSP = selectedSanPham.MaSP,
                        TenSP = selectedSanPham.TenSP,
                        SoLuong = soLuong,
                        DonGiA = donGia,
                        MucGiaKhuyenMai = khuyenMai?.MucGiaKhuyenMai.HasValue == true ? khuyenMai.MucGiaKhuyenMai.Value.ToString() : "0",
                        ThanhTien = giaSauKhuyenMai * soLuong
                    };

                    billList.Add(hoaDonItem);
                }
                dvgXuatHoaDon.DataSource = null;
                dvgXuatHoaDon.DataSource = billList;
                dvgXuatHoaDon.Columns["SoHD"].Visible = false;
                dvgXuatHoaDon.Columns["MaKH"].Visible = false;
                dvgXuatHoaDon.Columns["NgayLap"].Visible = false;
                dvgXuatHoaDon.Columns["PhuongThuc"].Visible = false;
                dvgXuatHoaDon.Columns["NgayThanhToan"].Visible = false;
                dvgXuatHoaDon.Columns["GhiChu"].Visible = false;
                dvgXuatHoaDon.Columns["MaNV"].Visible = false;
                dvgXuatHoaDon.Columns["MaPH"].Visible = false;
                dvgXuatHoaDon.Columns["TenKH"].Visible = false;
                dvgXuatHoaDon.Columns["Sdt"].Visible = false;
                numericUpDownSoLuong.Value = 0;
                TinhTongTien();
            }
        }
        private void ThemHoaDonMoi()
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    // Kiểm tra số điện thoại có hợp lệ không
                    if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                    {
                        MessageBox.Show("Số điện thoại không được để trống. Đang thêm hóa đơn mới...");
                        return;
                    }

                    // Tìm kiếm khách hàng trong cơ sở dữ liệu
                    var khachHang = dbContext.KHACHHANGs
                        .FirstOrDefault(kh => kh.Sdt == txtPhoneNumber.Text);

                    // Nếu không tìm thấy khách hàng, hỏi người dùng có muốn thêm không
                    if (khachHang == null)
                    {
                        var result = MessageBox.Show("Khách hàng không tồn tại. Bạn có muốn thêm khách hàng mới không?", "Thông báo", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // Mở form thêm khách hàng mới
                            using (CustomerIntoForm customerInfoForm = new CustomerIntoForm())
                            {
                                customerInfoForm.ShowDialog();  // Mở form thêm khách hàng

                                // Sau khi form đóng lại, kiểm tra xem khách hàng đã được thêm chưa
                                khachHang = dbContext.KHACHHANGs
                                    .FirstOrDefault(kh => kh.Sdt == txtPhoneNumber.Text);

                                // Nếu không thêm khách hàng thành công, dừng việc thêm hóa đơn
                                if (khachHang == null)
                                {
                                    MessageBox.Show("Không thể thêm khách hàng mới. Vui lòng thử lại.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            // Nếu chọn "No", tạo hóa đơn mà không có khách hàng
                            MessageBox.Show("Đang lưu hóa đơn mà không có khách hàng.");
                        }
                    }

                    // Tiếp tục quá trình tạo hóa đơn
                    var hoaDonMoi = new HOADON
                    {
                        SoHD = CreateNewSoHD(),
                        NgayLap = DateTime.Now,
                        TongTien = billList.Sum(hd => hd.ThanhTien),
                        MaKH = khachHang?.MaKH,  // Lưu mã khách hàng nếu có
                        MaNV = UserSession.MaNhanVienDangNhap
                    };

                    dbContext.HOADONs.Add(hoaDonMoi);
                    dbContext.SaveChanges();

                    // Lưu chi tiết hóa đơn
                    foreach (var chiTiet in billList)
                    {
                        var sanPham = dbContext.SANPHAMs.FirstOrDefault(sp => sp.MaSP == chiTiet.MaSP);

                        if (sanPham != null)
                        {
                            var chiTietMoi = new CHITIETHOADON
                            {
                                SoHD = hoaDonMoi.SoHD,
                                MaSP = chiTiet.MaSP,
                                SoLuong = chiTiet.SoLuong,
                                ThanhTien = (sanPham.DonGiA ?? 0) * chiTiet.SoLuong
                            };

                            dbContext.CHITIETHOADONs.Add(chiTietMoi);
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy sản phẩm với mã {chiTiet.MaSP}");
                        }
                    }
                    // Lưu phương thức thanh toán vào bảng CHI_THANHTOAN
                    if (cmbPaymentMethod.SelectedValue != null)
                    {
                        var maPTTT = cmbPaymentMethod.SelectedValue.ToString();
                        var chiThanhToan = new CHITIETTHANHTOAN
                        {
                            SoHD = hoaDonMoi.SoHD,
                            MaLTT = maPTTT,
                            NgayThanhToan = DateTime.Now,
                        };

                        dbContext.CHITIETTHANHTOANs.Add(chiThanhToan);
                        dbContext.SaveChanges();  // Thêm dòng này nếu chưa có
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn phương thức thanh toán.");
                        return; // Ngừng nếu không có phương thức thanh toán nào được chọn
                    }

                    // Lưu tất cả thay đổi vào cơ sở dữ liệu và commit giao dịch
                    dbContext.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Thêm hóa đơn mới thành công!");

                    BillDetailForm billDetailForm = new BillDetailForm(hoaDonMoi.SoHD, khachHang?.TenKH ?? "Khách hàng không xác định");
                    billDetailForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi khi thêm hóa đơn: {ex.Message}");
                }
            }
        }
        private void TinhTongTien()
        {
            double tongTien = billList.Sum(item => item.ThanhTien);
            lblTongTien.Text = tongTien.ToString("N0") + " VND";
        }
        private void bttPay_Click(object sender, EventArgs e)
        {
            if (billList.Any())
            {
                ThemHoaDonMoi();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào trong hóa đơn để thêm.");
            }
        }
        private string CreateNewSoHD()
        {
            var maxSoHD = dbContext.HOADONs
                .OrderByDescending(hd => hd.SoHD)
                .FirstOrDefault()?.SoHD;

            if (string.IsNullOrEmpty(maxSoHD))
            {
                return "HD001";
            }

            int numberPart = int.Parse(maxSoHD.Substring(2));
            numberPart++;

            return "HD" + numberPart.ToString("D3");
        }
    }
}
