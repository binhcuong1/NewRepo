﻿using QuanLyCuaHang.ViewModel;
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
    public partial class BillListUC : UserControl
    {
        private BillViewModel viewModel;
        private DateTime? selectedDate = null;

        public BillListUC()
        {
            InitializeComponent();
            viewModel = new BillViewModel();
            BindBillToGrid();

            dateTimePickerNgayLap.CustomFormat = " ";
            dateTimePickerNgayLap.Format = DateTimePickerFormat.Custom;

            dvgListHoaDon.RowHeadersVisible = false;
            dvgListHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgListHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgListHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BillListUC_Load(object sender, EventArgs e)
        {

        }
        public void BindBillToGrid()
        {
            var hoaDonList = viewModel.LoadHoaDon();
            dvgListHoaDon.DataSource = hoaDonList;

            dvgListHoaDon.Columns["MaSP"].Visible = false;
            dvgListHoaDon.Columns["TenSP"].Visible = false;
            dvgListHoaDon.Columns["SoLuong"].Visible = false;
            dvgListHoaDon.Columns["DonGiA"].Visible = false;
            dvgListHoaDon.Columns["MucGiaKhuyenMai"].Visible = false;
            dvgListHoaDon.Columns["ThanhTien"].Visible = false;
            dvgListHoaDon.Columns["TenKH"].Visible = false;
            dvgListHoaDon.Columns["Sdt"].Visible = false;
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
                    // Nếu có mã hóa đơn, vẫn tiếp tục mở BillDetailForm
                    string customerName = string.IsNullOrEmpty(maKH) ? "Khách hàng không xác định" : GetCustomerNameByMaKH(maKH);

                    BillDetailForm chiTietForm = new BillDetailForm(soHD, customerName);
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

            List<BillViewModel> hoaDonList = viewModel.LoadHoaDon();
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
   
    }
}
