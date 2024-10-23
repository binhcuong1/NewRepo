using System;
using System.Collections.Generic;
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
        public string MaNV { get; set; }
        public string MaPH { get; set; }
    }
}
