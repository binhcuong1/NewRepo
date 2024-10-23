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
        public DateTime? NgayLam { get; set; }
        public string MaLoaiCa { get; set; }
        public string MaCa { get; set; }
        public string TenCa { get; set; }
        public DateTime? GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TrangThai { get; set; }     
    }
}
