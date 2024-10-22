using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.ViewModel
{
    public class SupplierViewModel
    {
        ConveStoreDBContext db;

        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }

        public static List<SupplierViewModel> GetList(ConveStoreDBContext currDB)
        {
            return currDB.NHACUNGCAPs.Select(ncc => new SupplierViewModel
            {
                MaNCC = ncc.MaNCC,
                TenNCC = ncc.TenNCC,
                DiaChi = ncc.TenNCC + "-" + ncc.MaNCC
            }).ToList();
        }

        public static void BindToComboBox<T>(ComboBox comboBox, List<T> dataSource)
        {
            comboBox.DataSource = dataSource;

            // Chỉ định thuộc tính sẽ hiển thị trong ComboBox
            comboBox.DisplayMember = "TenNCC";

            // Chỉ định thuộc tính chứa giá trị thực tế mà ComboBox lưu trữ
            comboBox.ValueMember = "MaNCC";

            // Đặt ComboBox không chọn giá trị mặc định
            comboBox.SelectedIndex = -1;
        }
    }
}
