using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.ViewModel
{
    internal class BillDetailViewModel
    {
        public string SoHD {  get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGiA { get; set; }
        public string MucGiaKhuyenMai { get; set; }
        public double ThanhTien { get; set; }
    }
}
