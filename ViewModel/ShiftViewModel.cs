using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.ViewModel
{
    public class ShiftViewModel
    {
        private ConveStoreDBContext dbContext;
        public ShiftViewModel()
        {
            dbContext = new ConveStoreDBContext();
        }

        public DateTime? NgayLam { get; set; }
        public string MaLoaiCa { get; set; }
        public string MaCa { get; set; }
        public string TenCa { get; set; }
        public DateTime? GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TrangThai { get; set; }

        public List<ShiftViewModel> LoadData()
        {
            var list = dbContext.CHITIETCALAMVIECs.Select(ct => new ShiftViewModel
            {
                MaNV = ct.MaNV ?? "",
                TenNV = (ct.NHANVIEN.TenNV),
                MaCa = ct.MaCa,
                MaLoaiCa = ct.CALAMVIEC.MaLoaiCa,
                TenCa = ct.CALAMVIEC.LOAICALAMVIEC.TenCa,
                GioBatDau = ct.CALAMVIEC.LOAICALAMVIEC.GioBatDau,
                GioKetThuc = ct.CALAMVIEC.LOAICALAMVIEC.GioKetThuc,
                NgayLam = ct.CALAMVIEC.NgayLam,
                TrangThai = ct.TrangThai == true ? "Đã làm" : "Chưa làm"
            }).ToList();
            return list;
        }

        public List<ShiftViewModel> TimKiemTheoTieuChi(string ngayLam, string maNhanVien, string tenCa)
        {
            var ketQua = dbContext.CHITIETCALAMVIECs.AsQueryable();

            if (!string.IsNullOrEmpty(maNhanVien))
            {
                ketQua = ketQua.Where(ct => ct.NHANVIEN.MaNV == maNhanVien);
            }

            if (!string.IsNullOrEmpty(tenCa))
            {
                ketQua = ketQua.Where(ct => ct.CALAMVIEC.LOAICALAMVIEC.TenCa.Contains(tenCa));
            }

            if (!string.IsNullOrEmpty(ngayLam))
            {
                DateTime ngayLamDate;
                if (DateTime.TryParse(ngayLam, out ngayLamDate))
                {
                    ketQua = ketQua.Where(ct =>
                        ct.CALAMVIEC.NgayLam.HasValue &&
                        DbFunctions.TruncateTime(ct.CALAMVIEC.NgayLam.Value) == DbFunctions.TruncateTime(ngayLamDate));
                }
            }

            return ketQua.Select(ct => new ShiftViewModel
            {
                TenCa = ct.CALAMVIEC.LOAICALAMVIEC.TenCa,
                MaCa = ct.CALAMVIEC.MaCa,
                GioBatDau = ct.CALAMVIEC.LOAICALAMVIEC.GioBatDau,
                GioKetThuc = ct.CALAMVIEC.LOAICALAMVIEC.GioKetThuc,
                NgayLam = ct.CALAMVIEC.NgayLam,
                TrangThai = (ct.TrangThai ?? false) ? "Đã làm" : "Chưa làm",
                MaNV = ct.MaNV,
                TenNV = ct.NHANVIEN.TenNV
            }).ToList();
        }
    }
}
