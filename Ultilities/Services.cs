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

    }
}
