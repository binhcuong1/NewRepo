using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.ViewModel
{
    public class SaleRevenueViewModel
    {
        public int Thang { get; set; } 
        public int Ngay { get; set; }
        public double DoanhThuTong { get; set; }
        public double MucTieuDoanhThu { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int? SoLuong { get; set; }
    }
}
