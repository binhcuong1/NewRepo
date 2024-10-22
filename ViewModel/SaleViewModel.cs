using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.ViewModel
{
    public class SaleViewModel
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public string TenSP { get; set; }
        public double? MucGiaKhuyenMai { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
