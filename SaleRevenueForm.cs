using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHang
{
    public partial class SaleRevenueForm : Form
    {
        private ConveStoreDBContext dbContext;
        public SaleRevenueForm()
        {
            InitializeComponent();
            dbContext = new ConveStoreDBContext();
        }
        private void SaleRevenueForm_Load(object sender, EventArgs e)
        {
            LoadDailyRevenueIntoChart();
            LoadDailyTargetChart();
            LoadDataIntoChart();

            var topSellingProducts = GetTopSellingProducts();
            dgvTopSellingProducts.DataSource = topSellingProducts;
            dgvTopSellingProducts.Columns["Thang"].Visible = false;
            dgvTopSellingProducts.Columns["Ngay"].Visible = false;
            dgvTopSellingProducts.Columns["DoanhThuTong"].Visible = false;
            dgvTopSellingProducts.Columns["MucTieuDoanhThu"].Visible = false;
            dgvTopSellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Lấy dữ liệu cho sản phẩm không bán được
            var unsoldProducts = GetUnsoldProducts();
            UnsoldProducts.DataSource = unsoldProducts;
            UnsoldProducts.Columns["Thang"].Visible = false;
            UnsoldProducts.Columns["Ngay"].Visible = false;
            UnsoldProducts.Columns["DoanhThuTong"].Visible = false;
            UnsoldProducts.Columns["MucTieuDoanhThu"].Visible = false;
            UnsoldProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public List<SaleRevenueViewModel> GetDailyRevenueData()
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            var dailyRevenue = dbContext.HOADONs
                .Where(hd => hd.NgayLap.HasValue && hd.NgayLap.Value.Month == currentMonth && hd.NgayLap.Value.Year == currentYear)
                .GroupBy(hd => hd.NgayLap.Value.Day) // Group theo ngày
                .Select(g => new SaleRevenueViewModel 
                {
                    Thang = currentMonth,
                    DoanhThuTong = g.Join(dbContext.CHITIETHOADONs,
                                          hd => hd.SoHD,
                                          cthd => cthd.SoHD,
                                          (hd, cthd) => cthd.ThanhTien)
                                      .Sum(thanhTien => thanhTien ?? 0),
                    Ngay = g.Key // Lưu lại ngày trong tháng
                })
                .ToList();

            return dailyRevenue;
        }
        public void LoadDailyRevenueIntoChart()
        {
            // Lấy dữ liệu doanh thu theo ngày
            var dailyRevenueData = GetDailyRevenueData();

            // Thiết lập Chart Control
            chart1.Series.Clear(); // Xóa dữ liệu cũ nếu có
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";

            // Thêm Series
            var series = new Series
            {
                Name = "DoanhThu",
                Color = Color.Blue,
                ChartType = SeriesChartType.Column
            };

            chart1.Series.Add(series);

            // Thêm dữ liệu vào Series
            foreach (var data in dailyRevenueData)
            {
                series.Points.AddXY("Ngày " + data.Ngay, data.DoanhThuTong);
            };
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";          
            chart1.Invalidate();
        }
        public SaleRevenueViewModel GetRevenueForToday()
        {
            var today = DateTime.Today;
            double mucTieuDoanhThuTrongNgay = 1000000; // Ví dụ: mục tiêu doanh thu mỗi ngày là 1 triệu VND

            // Tính doanh thu của ngày hôm nay
            double doanhThuTong = dbContext.HOADONs
                .Where(hd => hd.NgayLap.HasValue &&
                     hd.NgayLap.Value.Day == today.Day &&
                     hd.NgayLap.Value.Month == today.Month &&
                     hd.NgayLap.Value.Year == today.Year)
                .Join(dbContext.CHITIETHOADONs,
                     hd => hd.SoHD,
                     cthd => cthd.SoHD,
                     (hd, cthd) => cthd.ThanhTien)
                .Sum(thanhTien => thanhTien) ?? 0;

            return new SaleRevenueViewModel
            {
                DoanhThuTong = doanhThuTong,
                MucTieuDoanhThu = mucTieuDoanhThuTrongNgay,
                Ngay = today.Day,
                Thang = today.Month
            };
        }
        public void LoadDailyTargetChart()
        {
            // Lấy dữ liệu doanh thu của ngày hôm nay
            var data = GetRevenueForToday();

            // Thiết lập Chart Control
            chartDailyTarget.Series.Clear(); // Xóa dữ liệu cũ nếu có
            chartDailyTarget.Titles.Clear(); // Xóa tiêu đề cũ nếu có
            chartDailyTarget.Titles.Add($"Mục Tiêu Doanh Thu Ngày {data.Ngay}/{data.Thang}"); // Thêm tiêu đề mới cho biểu đồ

            // Tạo Series cho biểu đồ tròn
            var series = new Series
            {
                Name = "DoanhThuNgay",
                ChartType = SeriesChartType.Pie // Đặt kiểu biểu đồ là biểu đồ tròn
            };
            chartDailyTarget.Series.Add(series); // Thêm Series vào biểu đồ

            // Tính toán phần doanh thu đã đạt được và phần còn lại của mục tiêu
            series.Points.AddXY("Đã đạt", data.DoanhThuTong); // Thêm điểm biểu diễn doanh thu đã đạt
            double remaining = data.MucTieuDoanhThu - data.DoanhThuTong; // Tính phần doanh thu còn lại của mục tiêu
            if (remaining > 0)
            {
                series.Points.AddXY("Còn lại", remaining); // Thêm điểm biểu diễn phần chưa đạt được của mục tiêu
            }

            // Thiết lập hiển thị phần trăm
            series.Label = "#PERCENT{P0}"; // Hiển thị phần trăm cho mỗi phần của biểu đồ
            series["PieLabelStyle"] = "Outside"; // Hiển thị nhãn bên ngoài biểu đồ

            // Định dạng màu sắc để dễ nhận biết
            series.Points[0].Color = Color.Blue; // Màu xanh biểu diễn doanh thu đã đạt
            series.Points[0].LegendText = "Đã đạt";

            if (remaining > 0)
            {
                series.Points[1].Color = Color.Gray; // Màu xám biểu diễn phần mục tiêu chưa đạt được
                series.Points[1].LegendText = "Còn lại";
            }
            // Cập nhật Chart Control để hiển thị
            chartDailyTarget.Invalidate();
        }
        public List<SaleRevenueViewModel> GetTopSellingProducts(int top = 10)
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            var topSellingProducts = dbContext.CHITIETHOADONs
                .Where(cthd => cthd.HOADON.NgayLap.HasValue &&
                               cthd.HOADON.NgayLap.Value.Month == currentMonth &&
                               cthd.HOADON.NgayLap.Value.Year == currentYear)
                .GroupBy(cthd => cthd.MaSP)
                .Select(g => new SaleRevenueViewModel
                {
                    MaSP = g.Key,
                    TenSP = g.Select(cthd => cthd.SANPHAM.TenSP).FirstOrDefault(),
                    SoLuong = g.Sum(cthd => cthd.SoLuong) // Tổng số lượng bán ra
                })
                .OrderByDescending(p => p.SoLuong) // Sắp xếp từ cao xuống thấp
                .Take(top) // Lấy top N sản phẩm
                .ToList();
            
            return topSellingProducts;

        }
        public List<SaleRevenueViewModel> GetUnsoldProducts()
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            var unsoldProducts = dbContext.SANPHAMs
                .Where(sp => !dbContext.CHITIETHOADONs
                    .Where(cthd => cthd.HOADON.NgayLap.HasValue &&
                                   cthd.HOADON.NgayLap.Value.Month == currentMonth &&
                                   cthd.HOADON.NgayLap.Value.Year == currentYear)
                    .Any(cthd => cthd.MaSP == sp.MaSP))
                .Select(sp => new SaleRevenueViewModel
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    SoLuong = 0 
                })
                .ToList();
      

            return unsoldProducts;
        }
        public List<SaleRevenueViewModel> GetMonthlyRevenueData()
        {
            var currentYear = DateTime.Now.Year;

            var monthlyRevenue = dbContext.HOADONs
                .Where(hd => hd.NgayLap.HasValue && hd.NgayLap.Value.Year == currentYear)
                .GroupBy(hd => hd.NgayLap.Value.Month)
                .Select(g => new SaleRevenueViewModel
                {
                    Thang = g.Key,
                    DoanhThuTong = g.Join(dbContext.CHITIETHOADONs,
                                          hd => hd.SoHD,
                                          cthd => cthd.SoHD,
                                          (hd, cthd) => cthd.ThanhTien)
                                      .Sum(thanhTien => thanhTien ?? 0)
                })
                .ToList();

            return monthlyRevenue;
        }
        public void LoadDataIntoChart()
        {
            // Lấy dữ liệu doanh thu từng tháng
            var monthlyRevenueData = GetMonthlyRevenueData();

            // Thiết lập Chart Control
            chartMonthlyRevenue.Series.Clear(); // Xóa dữ liệu cũ nếu có
            chartMonthlyRevenue.ChartAreas[0].AxisX.Title = "Tháng";
            chartMonthlyRevenue.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";

            // Thêm Series
            var series = new Series
            {
                Name = "DoanhThu",
                Color = Color.Blue,
                ChartType = SeriesChartType.Column
            };

            chartMonthlyRevenue.Series.Add(series);

            // Thêm dữ liệu vào Series
            foreach (var data in monthlyRevenueData)
            {
                series.Points.AddXY("Tháng " + data.Thang, data.DoanhThuTong);
            }
            chartMonthlyRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

            // Cập nhật Chart Control để hiển thị
            chartMonthlyRevenue.Invalidate();
        }
    }
}
