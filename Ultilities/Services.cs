using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Ultilities
{
    public class Services
    {

        // Hàm dùng để set panel ở vị trí giữa form
        public static void SetCenterPanel(Form form, Panel panel)
        {
            // Tính toán vị trí để đặt panel ở giữa form
            int x = (form.ClientSize.Width - panel.Width) / 2;
            int y = (form.ClientSize.Height - panel.Height) / 2;

            // Gán vị trí cho panel
            panel.Location = new Point(x, y);
        }

        // Hàm dùng để set label ở vị trí giữa form
        public static void SetCenterLabel(Form form, Label label)
        {
            // Tính toán vị trí X để đặt Label ở giữa trục X của form
            int x = (form.ClientSize.Width - label.Width) / 2;

            // Giữ nguyên vị trí Y của Label, chỉ căn giữa theo trục X
            label.Location = new Point(x, label.Location.Y);
        }
    }
}
