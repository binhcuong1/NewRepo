using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.ViewModel
{
    public class BillListViewModel
    {
        public string SoHD { get; set; }
            public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string Sdt { get; set; }
        public DateTime? NgayLap { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string PhuongThuc { get; set; }
        public string GhiChu { get; set; }
        public string TenNV { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayPhanHoi { get; set; }
    }
}
