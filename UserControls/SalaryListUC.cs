using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.UserControls
{
    public partial class SalaryListUC : UserControl
    {
        ConveStoreDBContext db;

        SalaryStaffViewModel currStaff;

        private Panel currPanel;
        private string currStaffID;

        public SalaryListUC(ref Panel currPanel, ref DataGridView currDgv, string str)
        {
            InitializeComponent();

            db = new ConveStoreDBContext();

            this.currPanel = currPanel;

            currStaffID = str;
        }

        private void SalaryListUC_Load(object sender, EventArgs e)
        {
            txtSumSalary.Text = currStaffID;

            var currStaff = db.NHANVIENs.FirstOrDefault(nv => nv.MaNV == currStaffID);
            lblShowNameStaff.Text = currStaff.TenNV;
            lblShowIDStaff.Text = currStaffID;
        }

        #region Button Methods
        private void btnBackToProductGateFrm_Click(object sender, EventArgs e)
        {
            // Ẩn UserControl
            this.Visible = false;

            // Ẩn panel chứa UserControl
            if (currPanel != null)
            {
                currPanel.Visible = false; // Ẩn panel
            }
        }

        private void BtnCheckSalary_Click(object sender, EventArgs e)
        {
            double totalHours = TotalWorkingHours();
            double totalSalarys = totalHours * 30000;
            txtTotalWorkingHours.Text = totalHours.ToString();
            txtSumSalary.Text = totalSalarys.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }

        public double TotalWorkingHours()
        {

            using (var context = new ConveStoreDBContext())
            {
                string maNV = currStaffID;
                // Lấy tất cả các bản ghi trong ChiTietCaLamViec có MaNV bằng với maNV và TrangThai = 1
                var chiTietCaLamViecs = context.CHITIETCALAMVIECs
                    .Where(ct => ct.TrangThai == true && ct.MaNV == maNV)
                    .ToList();

                double totalHours = 0;

                // Lặp qua các ca làm việc đã lọc được
                foreach (var chiTiet in chiTietCaLamViecs)
                {
                    // Tìm thông tin ca làm việc tương ứng
                    var caLamViec = context.CALAMVIECs
                        .FirstOrDefault(cl => cl.MaCa == chiTiet.MaCa);

                    // Tìm thông tin loại ca làm việc tương ứng
                    var loaiCaLamViec = context.LOAICALAMVIECs
                        .FirstOrDefault(lc => lc.MaLoaiCa == caLamViec.MaLoaiCa);

                    // Tính toán thời gian làm việc cho mỗi ca (giờ kết thúc - giờ bắt đầu)
                    if (loaiCaLamViec != null && loaiCaLamViec.GioBatDau.HasValue && loaiCaLamViec.GioKetThuc.HasValue)
                    {
                        // Tính toán thời gian làm việc cho mỗi ca (giờ kết thúc - giờ bắt đầu)
                        TimeSpan duration = loaiCaLamViec.GioKetThuc.Value - loaiCaLamViec.GioBatDau.Value;
                        totalHours += duration.TotalHours;
                    }
                }

                return totalHours;  // Trả về tổng số giờ làm việc
            }
        }
        #endregion
    }
}
