﻿using QuanLyCuaHang.Ultilities;
using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private string currMaSP;
        public OutputBillUC()
        {
            InitializeComponent();
            viewModel = new BillViewModel();
            dbContext = new ConveStoreDBContext();

            dvgXuatHoaDon.RowHeadersVisible = false;
            dvgXuatHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgXuatHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgXuatHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void OutputBillUC_Load(object sender, EventArgs e)
        {
            LoadProductGatetoryToComboBox();
            LoadProductToComboBox();
            LoadPaymentMethodToCombobox();
            cmbProduct.SelectedItem = null;
            cmbProductType.SelectedItem = null;
            cmbPaymentMethod.SelectedItem = null;
        }
        private void LoadProductToComboBox()
        {
            var sanPhamList = dbContext.SANPHAMs.ToList();

            cmbProduct.DataSource = sanPhamList;
            cmbProduct.DisplayMember = "TenSP";
            cmbProduct.ValueMember = "MaSP";
        }
        private void LoadProductGatetoryToComboBox()
        {
            var loaiSanPhamList = dbContext.LOAISANPHAMs.ToList();

            cmbProductType.DataSource = loaiSanPhamList;
            cmbProductType.DisplayMember = "TenTheLoai";
            cmbProductType.ValueMember = "MaTheLoai";
        }
        private void LoadPaymentMethodToCombobox()
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

                double donGia = selectedSanPham.DonGia ?? 0;

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
                dvgXuatHoaDon.Columns["PhuongThuc"].Visible = false;
                dvgXuatHoaDon.Columns["MaSP"].Visible = false;

                numericUpDownSoLuong.Value = 0;
                TinhTongTien();  
            }
        }
        private void ThemHoaDonMoi()
        {
            // Kiểm tra số điện thoại có hợp lệ không
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống. Vui lòng nhập số điện thoại.");
                return; // Dừng quá trình nếu không có số điện thoại
            }

            // Kiểm tra phương thức thanh toán
            if (cmbPaymentMethod.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán.");
                return; // Dừng quá trình nếu không có phương thức thanh toán
            }

            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
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
                            using (CustomerIntoForm customerInfoForm = new CustomerIntoForm(txtPhoneNumber.Text))
                            {
                                customerInfoForm.ShowDialog();

                                // Sau khi form đóng lại, kiểm tra xem khách hàng đã được thêm chưa
                                khachHang = dbContext.KHACHHANGs
                                    .FirstOrDefault(kh => kh.Sdt == txtPhoneNumber.Text);

                                // Nếu không thêm khách hàng thành công, dừng việc thêm hóa đơn
                                if (khachHang == null)
                                {
                                    MessageBox.Show("Không thể thêm khách hàng mới. Vui lòng thử lại.");
                                    billList.Clear();
                                    dvgXuatHoaDon.DataSource = null;
                                    dvgXuatHoaDon.DataSource = billList;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lưu hóa đơn mới không có khách hàng.");

                            // Tạo hóa đơn mới không có mã khách hàng
                            var hoaDonMoi = new HOADON
                            {
                                SoHD = CreateNewSoHD(),
                                NgayLap = DateTime.Now,
                                TongTien = billList.Sum(hd => hd.ThanhTien),
                                GhiChu = "Đã thanh toán",
                                MaNV = UserSession.MaNhanVienDangNhap
                            };

                            dbContext.HOADONs.Add(hoaDonMoi);

                            // Lưu các chi tiết hóa đơn và thanh toán như thông thường
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
                                        ThanhTien = (sanPham.DonGia ?? 0) * chiTiet.SoLuong
                                    };
                                    dbContext.CHITIETHOADONs.Add(chiTietMoi);

                                    TONKHO currSanPham = dbContext.TONKHOes
                                .FirstOrDefault(sp => sp.MaSP.ToLower().Trim().Contains(chiTietMoi.MaSP.ToLower().Trim()));

                                    currSanPham.SoLuongTonKho = currSanPham.SoLuongTonKho - chiTietMoi.SoLuong;
                                }
                            }

                            var maPTTT = cmbPaymentMethod.SelectedValue.ToString();
                            var chiThanhToan = new CHITIETTHANHTOAN
                            {
                                SoHD = hoaDonMoi.SoHD,
                                MaLTT = maPTTT,
                                NgayThanhToan = DateTime.Now,
                            };

                            dbContext.CHITIETTHANHTOANs.Add(chiThanhToan);

                            // SaveChanges và Commit transaction
                            dbContext.SaveChanges();
                            transaction.Commit();

                            MessageBox.Show("Thêm hóa đơn mới không có khách hàng thành công!");

                            // Hiển thị hóa đơn
                            BillDetailForm billDetailForm = new BillDetailForm(
                                hoaDonMoi.SoHD,
                                "Khách hàng không xác định",
                                string.Empty
                            );
                            billDetailForm.ShowDialog();
                            return;
                        }
                    }

                    // Tạo hóa đơn mới có mã khách hàng
                    var hoaDon = new HOADON
                    {
                        SoHD = CreateNewSoHD(),
                        NgayLap = DateTime.Now,
                        TongTien = billList.Sum(hd => hd.ThanhTien),
                        MaKH = khachHang?.MaKH,
                        GhiChu = "Đã thanh toán",
                        MaNV = UserSession.MaNhanVienDangNhap
                    };

                    dbContext.HOADONs.Add(hoaDon);

                    // Lưu chi tiết hóa đơn
                    foreach (var chiTiet in billList)
                    {
                        var sanPham = dbContext.SANPHAMs.FirstOrDefault(sp => sp.MaSP == chiTiet.MaSP);

                        if (sanPham != null)
                        {
                            var chiTietMoi = new CHITIETHOADON
                            {
                                SoHD = hoaDon.SoHD,
                                MaSP = chiTiet.MaSP,
                                SoLuong = chiTiet.SoLuong,
                                ThanhTien = (sanPham.DonGia ?? 0) * chiTiet.SoLuong
                            };

                            dbContext.CHITIETHOADONs.Add(chiTietMoi);
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy sản phẩm với mã {chiTiet.MaSP}");
                        }
                    }

                    // Lưu chi tiết thanh toán
                    var paymentMethodId = cmbPaymentMethod.SelectedValue.ToString();
                    var paymentDetail = new CHITIETTHANHTOAN
                    {
                        SoHD = hoaDon.SoHD,
                        MaLTT = paymentMethodId,
                        NgayThanhToan = DateTime.Now,
                    };

                    dbContext.CHITIETTHANHTOANs.Add(paymentDetail);

                    // Lưu tất cả thay đổi
                    dbContext.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Thêm hóa đơn mới thành công!");

                    BillDetailForm billDetailFormWithCustomer = new BillDetailForm(
                        hoaDon.SoHD,
                        khachHang?.TenKH ?? "Khách hàng không xác định",
                        khachHang?.MaKH ?? string.Empty
                    );
                    billDetailFormWithCustomer.ShowDialog();
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
                billList.Clear();
                dvgXuatHoaDon.DataSource = null;
                dvgXuatHoaDon.DataSource = billList; 
                txtPhoneNumber.Clear();
                cmbPaymentMethod.SelectedItem = null;
                cmbProductType.SelectedItem = null;
                cmbProduct.SelectedItem = null;
                lblTongTien.Text = null;
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
        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currMaSP))
            {
                // Tìm và xóa sản phẩm khỏi billList
                var itemToRemove = billList.FirstOrDefault(item => item.MaSP == currMaSP);
                if (itemToRemove != null)
                {
                    billList.Remove(itemToRemove);

                    // Cập nhật lại DataGridView
                    dvgXuatHoaDon.DataSource = null;
                    dvgXuatHoaDon.DataSource = billList;

                    // Reset currMaSP để tránh lỗi xóa nhầm
                    currMaSP = null;
                }
                dvgXuatHoaDon.Columns["SoHD"].Visible = false;
                dvgXuatHoaDon.Columns["PhuongThuc"].Visible = false;
                dvgXuatHoaDon.Columns["MaSP"].Visible = false;

                cmbProductType.SelectedItem = null;
                cmbProduct.SelectedItem = null;

                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm để xóa.");
            }
        }
        private void dvgXuatHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dvgXuatHoaDon.Rows[e.RowIndex];
                if (selectedRow.Cells["MaSP"].Value != null)
                {
                    currMaSP = selectedRow.Cells["MaSP"].Value.ToString();
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var num = numericUpDownSoLuong.Value;

            MessageBox.Show(num.ToString());
        }
    }
}
