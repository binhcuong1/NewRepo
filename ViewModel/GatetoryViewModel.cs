using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.ViewModel
{
    internal class GatetoryViewModel
    {
        public string MaTheLoai { get; set; }

        public string TenTheLoai { get; set; }

        public static List<GatetoryViewModel> GetListGatetory(ConveStoreDBContext currDB)
        {
            return currDB.LOAISANPHAMs.Select(tl => new GatetoryViewModel
            {
                MaTheLoai = tl.MaTheLoai,
                TenTheLoai = tl.TenTheLoai
            }).ToList();
        }

        public static void BindToComboBox<T>(ComboBox comboBox, List<T> dataSource)
        {
            comboBox.DataSource = dataSource;

            // Chỉ định thuộc tính sẽ hiển thị trong ComboBox
            comboBox.DisplayMember = "TenTheLoai";

            // Chỉ định thuộc tính chứa giá trị thực tế mà ComboBox lưu trữ
            comboBox.ValueMember = "MaTheLoai";

            // Đặt ComboBox không chọn giá trị mặc định
            comboBox.SelectedIndex = -1;
        }
    }
}
