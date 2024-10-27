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

namespace QuanLyCuaHang.UserControls
{
    public partial class BillListUC : UserControl
    {
        private DateTime? selectedDate = null;
        private ConveStoreDBContext dbContext;

        Panel currPanel;

        public BillListUC(Panel currPanel)
        {
            InitializeComponent();
            dbContext = new ConveStoreDBContext();
            BindBillToGrid();

            dateTimePickerNgayLap.CustomFormat = " ";
            dateTimePickerNgayLap.Format = DateTimePickerFormat.Custom;

            dvgListHoaDon.Columns["MaKH"].Visible = false;
            //dvgListHoaDon.RowHeadersVisible = false;
            //dvgListHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dvgListHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgListHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.currPanel = currPanel;
        }

        private void BillListUC_Load(object sender, EventArgs e)
        {

        }
        public void BindBillToGrid()
        {
            var hoaDonList = LoadHoaDon(); 
            dvgListHoaDon.DataSource = hoaDonList;

        }
        public List<BillListViewModel> LoadHoaDon()
        {
            var list = dbContext.HOADONs.Select(ct => new BillListViewModel
            {
                SoHD = ct.SoHD,
                NgayLap = ct.NgayLap,
                GhiChu = ct.GhiChu,            
                TenNV = ct.NHANVIEN.TenNV,
                TenKH = ct.KHACHHANG.TenKH,
                Sdt = ct.KHACHHANG.Sdt,
                NoiDung = ct.PHANHOIKHACHHANG.NoiDung,
                NgayPhanHoi = ct.PHANHOIKHACHHANG.NgayPhanHoi,
            }).ToList();

            // Xử lý các phương thức riêng như trước
            foreach (var item in list)
            {
                item.PhuongThuc = GetPTTT(item.SoHD); // Gọi phương thức riêng để lấy Phương thức thanh toán
                item.NgayThanhToan = GetNgayThanhToan(item.SoHD); // Gọi phương thức riêng để lấy Ngày thanh toán
            }

            return list;
        }

        // Phương thức để lấy Phương thức thanh toán
        private string GetPTTT(string currBillID)
        {
            var h = dbContext.HOADONs.FirstOrDefault(hd => hd.SoHD == currBillID);
            if (h == null)
            {
                return "Không tìm thấy hóa đơn";
            }

            var ct = dbContext.CHITIETTHANHTOANs.FirstOrDefault(cc => cc.SoHD == h.SoHD);
            if (ct == null)
            {
                return "Không tìm thấy chi tiết thanh toán";
            }

            var pt = dbContext.PHUONGTHUCTHANHTOANs.FirstOrDefault(pp => pp.MaLTT == ct.MaLTT);
            if (pt == null)
            {
                return "Không tìm thấy phương thức thanh toán";
            }

            return pt.PhuongThuc;
        }

        // Phương thức để lấy Ngày thanh toán
        private DateTime? GetNgayThanhToan(string currBillID)
        {
            var h = dbContext.HOADONs.FirstOrDefault(hd => hd.SoHD == currBillID);
            if (h == null)
            {
                return null;
            }

            var ct = dbContext.CHITIETTHANHTOANs.FirstOrDefault(cc => cc.SoHD == h.SoHD);
            if (ct == null)
            {
                return null;
            }

            return ct.NgayThanhToan;
        }
        private void dateTimePickerNgayLap_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNgayLap.CustomFormat = "dd/MM/yyyy";
            selectedDate = dateTimePickerNgayLap.Value;
        }
        private void dvgListHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgListHoaDon.Rows[e.RowIndex];
                string soHD = row.Cells["SoHD"].Value?.ToString();
                string maKH = row.Cells["MaKH"].Value?.ToString();

                if (!string.IsNullOrEmpty(soHD))
                {
                    string customerName = string.IsNullOrEmpty(maKH) ? "Khách hàng không xác định" : GetCustomerNameByMaKH(maKH);

                    BillDetailForm chiTietForm = new BillDetailForm(soHD, customerName, maKH);
                    chiTietForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn không hợp lệ.");
                }
            }
        }
        private string GetCustomerNameByMaKH(string maKH)
        {
            using (var dbContext = new ConveStoreDBContext())
            {
                var customerName = (from khachHang in dbContext.KHACHHANGs
                                    where khachHang.MaKH == maKH
                                    select khachHang.TenKH).FirstOrDefault();
                return customerName;
            }
        }
        private void ResetSearchFields()
        {
            txtBillID.Clear();
            txtCustomerPhoneNumer.Clear();
            dateTimePickerNgayLap.CustomFormat = " ";
            dateTimePickerNgayLap.Format = DateTimePickerFormat.Custom;
        }
        private void bttSearch_Click(object sender, EventArgs e)
        {
            string maHD = txtBillID.Text.Trim();
            string customerPhoneNumber = txtCustomerPhoneNumer.Text.Trim();
            DateTime? ngayLap = dateTimePickerNgayLap.Value != null && dateTimePickerNgayLap.CustomFormat != " "
                                ? dateTimePickerNgayLap.Value.Date
                                : (DateTime?)null;

            List<BillListViewModel> hoaDonList = LoadHoaDon();
            ResetSearchFields();

            if (!string.IsNullOrEmpty(maHD))
            {
                hoaDonList = hoaDonList.Where(hd => hd.SoHD.Contains(maHD)).ToList();
            }

            if (!string.IsNullOrEmpty(customerPhoneNumber))
            {
                using (var dbContext = new ConveStoreDBContext())
                {
                    var maKH = (from khachHang in dbContext.KHACHHANGs
                                where khachHang.Sdt == customerPhoneNumber
                                select khachHang.MaKH).FirstOrDefault();

                    if (!string.IsNullOrEmpty(maKH))
                    {
                        hoaDonList = hoaDonList.Where(hd => hd.MaKH == maKH).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Khách hàng với số điện thoại này.");
                        return;
                    }
                }
            }

            if (ngayLap.HasValue)
            {
                hoaDonList = hoaDonList.Where(hd => hd.NgayLap.HasValue && hd.NgayLap.Value.Date == ngayLap.Value).ToList();
            }

            if (hoaDonList.Any())
            {
                dvgListHoaDon.DataSource = hoaDonList;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào.");
            }
        }
        private void bttRefresh_Click(object sender, EventArgs e)
        {
            ResetSearchFields();
            BindBillToGrid();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            currPanel.Controls.Clear();
            OutputBillUC uc = new OutputBillUC();
            uc.Dock = DockStyle.Fill;
            currPanel.Controls.Add(uc);
        }
    }
}
