using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.ViewModel
{
    public class ProductViewModel
    {
        public string MaSP {get; set;}
        
        public string TenSP {get; set;}
        
        public string DonGia {get; set;}
        
        public string TenNCC {get; set;}
        
        public string TenTheLoai { get; set; }

        public static List<ProductViewModel> GetListProduct(ConveStoreDBContext currDB)
        {
            return currDB.SANPHAMs.Select(sp => new ProductViewModel
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                DonGia = sp.DonGiA.ToString(),
                TenNCC = sp.NHACUNGCAP.TenNCC,
                TenTheLoai = sp.LOAISANPHAM.TenTheLoai,
            }).ToList();
        }
    }
}
