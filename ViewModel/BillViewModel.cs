using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.ViewModel
{
    public class BillViewModel
    {
        public string SoHD { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string Sdt { get; set; }
        public DateTime? NgayLap { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string PhuongThuc { get; set; }
        public string GhiChu { get; set; }
        public string MaNV { get; set; }
        public string MaPH { get; set; }


        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGiA { get; set; }
        public string MucGiaKhuyenMai { get; set; }
        public double ThanhTien { get; set; }


        private ConveStoreDBContext dbContext;
        public BillViewModel()
        {
            dbContext = new ConveStoreDBContext();
        }
        public List<BillViewModel> LoadChiTietHoaDon(string soHD)
        {
            var list = (from ctHoaDon in dbContext.CHITIETHOADONs.AsNoTracking()
                        join ctKhuyenMai in dbContext.CHITITETKHUYENMAIs.AsNoTracking()
                        on ctHoaDon.MaSP equals ctKhuyenMai.MaSP into khuyenMaiJoin
                        from km in khuyenMaiJoin.DefaultIfEmpty()
                        where ctHoaDon.SoHD == soHD  // So sánh với SoHD là chuỗi
                        select new BillViewModel
                        {
                            MaSP = ctHoaDon.SANPHAM.MaSP,
                            TenSP = ctHoaDon.SANPHAM.TenSP,
                            SoLuong = ctHoaDon.SoLuong ?? 0,
                            DonGiA = ctHoaDon.SANPHAM.DonGiA ?? 0,
                            MucGiaKhuyenMai = km != null ? (km.MucGiaKhuyenMai.HasValue ? km.MucGiaKhuyenMai.Value.ToString() : "0") : "0",
                            ThanhTien = (km != null ? (km.MucGiaKhuyenMai ?? 0) : (ctHoaDon.SANPHAM.DonGiA ?? 0)) * (ctHoaDon.SoLuong ?? 0)
                        }).ToList();
            return list;
        }
        public List<BillViewModel> LoadHoaDon()
        {
            //var list = (from hoaDon in dbContext.HOADONs.AsNoTracking()
            //            join chiTietThanhToan in dbContext.CHITIETTHANHTOANs.AsNoTracking()
            //            on hoaDon.SoHD equals chiTietThanhToan.SoHD
            //            join phuongThucThanhToan in dbContext.PHUONGTHUCTHANHTOANs.AsNoTracking()
            //            on chiTietThanhToan.MaLTT equals phuongThucThanhToan.MaLTT
            //            select new BillViewModel
            //            {
            //                SoHD = hoaDon.SoHD,
            //                NgayLap = hoaDon.NgayLap,
            //                GhiChu = hoaDon.GhiChu,
            //                MaKH = hoaDon.MaKH,
            //                MaNV = hoaDon.MaNV,
            //                MaPH = hoaDon.MaPH,
            //                PhuongThuc = phuongThucThanhToan.PhuongThuc,
            //                NgayThanhToan = chiTietThanhToan.NgayThanhToan,
            ////            }).ToList();

            //return list;

            // Lấy dữ liệu cơ bản trước (không bao gồm GetPTTT và GetNgayThanhToan)
            var list = dbContext.CHITIETHOADONs.Select(ct => new BillViewModel
            {
                SoHD = ct.SoHD,
                NgayLap = ct.HOADON.NgayLap,
                GhiChu = ct.HOADON.GhiChu,
                MaKH = ct.HOADON.MaKH,
                MaNV = ct.HOADON.MaNV,
                MaPH = ct.HOADON.MaPH,
                // PhuongThuc và NgayThanhToan sẽ được xử lý sau
            }).ToList();

            // Xử lý các phương thức không thể dịch ra SQL
            foreach (var item in list)
            {
                item.PhuongThuc = GetPTTT(item.SoHD); // Gọi phương thức riêng sau khi đã lấy dữ liệu
                item.NgayThanhToan = GetNgayThanhToan(item.SoHD);
            }

            return list;
        }
        string GetPTTT(string currBillID)
        {
            // Lấy hóa đơn
            var h = dbContext.HOADONs.FirstOrDefault(hd => hd.SoHD == currBillID);
            if (h == null)
            {
                return "Không tìm thấy hóa đơn";
            }

            // Lấy chi tiết thanh toán dựa trên hóa đơn
            var ct = dbContext.CHITIETTHANHTOANs.FirstOrDefault(cc => cc.SoHD == h.SoHD);
            if (ct == null)
            {
                return "Không tìm thấy chi tiết thanh toán";
            }

            // Lấy phương thức thanh toán dựa trên chi tiết thanh toán
            var pt = dbContext.PHUONGTHUCTHANHTOANs.FirstOrDefault(pp => pp.MaLTT == ct.MaLTT);
            if (pt == null)
            {
                return "Không tìm thấy phương thức thanh toán";
            }

            // Trả về phương thức thanh toán
            return pt.PhuongThuc;
        }


        DateTime? GetNgayThanhToan(string currBillID)
        {
            HOADON h = dbContext.HOADONs.FirstOrDefault(hd => hd.SoHD == currBillID);

            CHITIETTHANHTOAN ct = dbContext.CHITIETTHANHTOANs.FirstOrDefault(cc => cc.SoHD == h.SoHD);

            return ct.NgayThanhToan;
        }
    }
}
