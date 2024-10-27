﻿using QuanLyCuaHang.ViewModel;
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
    public partial class ShiftUC : UserControl
    {
        private ShiftViewModel viewModel;

        private ConveStoreDBContext dbContext;

        List<ShiftViewModel> shiftLists;

        private DateTime? selectedDate = null;

        Panel currPanel;

        public ShiftUC(Panel currPanel)
        {
            InitializeComponent();
            dbContext = new ConveStoreDBContext();
            viewModel = new ShiftViewModel();
            LoadShiftToGrid();
            LoadShiftToComboBox();
            LoadStaffToComboBox();

            dateTimePickerNgayLam.CustomFormat = " ";
            dateTimePickerNgayLam.Format = DateTimePickerFormat.Custom;

            cmbShift.SelectedItem = null;
            cmbStaff.SelectedItem = null;

            dgvOfShiftUC.CellFormatting += dgvCaLamViec_CellFormatting;
            //dgvOfShiftUC.RowHeadersVisible = false;
            //dgvOfShiftUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgvOfShiftUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOfShiftUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.currPanel = currPanel;
        }

        private void ShiftUC_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgayLam_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNgayLam.CustomFormat = "dd/MM/yyyy";
            selectedDate = dateTimePickerNgayLam.Value;
        }

        public void LoadShiftToGrid()
        {
            var caLamViecList = LoadData();  
            dgvOfShiftUC.DataSource = caLamViecList;

            dgvOfShiftUC.Columns["MaLoaiCa"].Visible = false;
            dgvOfShiftUC.Columns["MaCa"].Visible = false;
        }

        public List<ShiftViewModel> LoadData()
        {
            var list = dbContext.CHITIETCALAMVIECs.Select(ct => new ShiftViewModel
            {
                MaNV = ct.MaNV ?? "",
                TenNV = ct.NHANVIEN.TenNV,
                MaCa = ct.MaCa,
                MaLoaiCa = ct.CALAMVIEC.MaLoaiCa,
                TenCa = ct.CALAMVIEC.LOAICALAMVIEC.TenCa,
                GioBatDau = ct.CALAMVIEC.LOAICALAMVIEC.GioBatDau,
                GioKetThuc = ct.CALAMVIEC.LOAICALAMVIEC.GioKetThuc,
                NgayLam = ct.CALAMVIEC.NgayLam,
                TrangThai = ct.TrangThai == true ? "Đã làm" : "Chưa làm"
            }).ToList();
            return list;
        }

        private void LoadShiftToComboBox()
        {
            shiftLists = dbContext.LOAICALAMVIECs.Select(k => new ShiftViewModel
            {
                MaLoaiCa = k.MaLoaiCa,
                TenCa = k.TenCa,
            }).ToList();
            BindCaLamToComboBox(shiftLists);
        }

        private void LoadStaffToComboBox()
        {
            var nhanViens = dbContext.NHANVIENs
                .Select(nv => new
                {
                    MaNV = nv.MaNV,
                    TenNV = nv.TenNV,
                    HienThiNV = nv.TenNV + " - " + nv.MaNV
                })
                .ToList();


            cmbStaff.DataSource = nhanViens;
            cmbStaff.DisplayMember = "HienThiNV";
            cmbStaff.ValueMember = "MaNV";
        }

        private void BindCaLamToComboBox(List<ShiftViewModel> caLamViecViewModels)
        {
            cmbShift.DataSource = caLamViecViewModels;
            cmbShift.DisplayMember = "TenCa";
            cmbShift.ValueMember = "MaLoaiCa";
        }

        
        private void dgvOfShiftUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOfShiftUC.Rows[e.RowIndex];

                string maNV = row.Cells["MaNV"].Value.ToString();
                string tenNV = row.Cells["TenNV"].Value.ToString();

                foreach (var item in cmbStaff.Items)
                {
                    dynamic nv = item;
                    if (nv.MaNV == maNV)
                    {
                        cmbStaff.SelectedItem = item;
                        break;
                    }
                }

                txtMaCa.Text = row.Cells["MaCa"].Value.ToString();
                cmbShift.Text = row.Cells["TenCa"].Value.ToString();
                dateTimePickerNgayLam.Value = DateTime.Parse(row.Cells["NgayLam"].Value.ToString());
            }
        }

        private void dgvCaLamViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOfShiftUC.Columns[e.ColumnIndex].Name == "GioBatDau" ||
                dgvOfShiftUC.Columns[e.ColumnIndex].Name == "GioKetThuc")
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNhanVien = cmbStaff.SelectedValue?.ToString() ?? string.Empty;
            string tenCa = cmbShift.Text.Trim();
            string ngayLam = dateTimePickerNgayLam.CustomFormat == " " ? string.Empty : dateTimePickerNgayLam.Value.ToString("yyyy-MM-dd");

            // Gọi phương thức tìm kiếm và cập nhật DataGridView
            List<ShiftViewModel> ketQuaTimKiem = TimKiemTheoTieuChi(ngayLam, maNhanVien, tenCa);
            dgvOfShiftUC.DataSource = ketQuaTimKiem;

            ResetSearchFields();
        }

        public List<ShiftViewModel> TimKiemTheoTieuChi(string ngayLam, string maNhanVien, string tenCa)
        {
            var ketQua = dbContext.CHITIETCALAMVIECs.AsQueryable();

            if (!string.IsNullOrEmpty(maNhanVien))
            {
                ketQua = ketQua.Where(ct => ct.NHANVIEN.MaNV == maNhanVien);
            }

            if (!string.IsNullOrEmpty(tenCa))
            {
                ketQua = ketQua.Where(ct => ct.CALAMVIEC.LOAICALAMVIEC.TenCa.Contains(tenCa));
            }

            if (!string.IsNullOrEmpty(ngayLam))
            {
                DateTime ngayLamDate;
                if (DateTime.TryParse(ngayLam, out ngayLamDate))
                {
                    ketQua = ketQua.Where(ct =>
                        ct.CALAMVIEC.NgayLam.HasValue &&
                        DbFunctions.TruncateTime(ct.CALAMVIEC.NgayLam.Value) == DbFunctions.TruncateTime(ngayLamDate));
                }
            }

            return ketQua.Select(ct => new ShiftViewModel
            {
                TenCa = ct.CALAMVIEC.LOAICALAMVIEC.TenCa,
                MaCa = ct.CALAMVIEC.MaCa,
                GioBatDau = ct.CALAMVIEC.LOAICALAMVIEC.GioBatDau,
                GioKetThuc = ct.CALAMVIEC.LOAICALAMVIEC.GioKetThuc,
                NgayLam = ct.CALAMVIEC.NgayLam,
                TrangThai = (ct.TrangThai ?? false) ? "Đã làm" : "Chưa làm",
                MaNV = ct.MaNV,
                TenNV = ct.NHANVIEN.TenNV
            }).ToList();
        }

        private void btnAddAndUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var CaLamViecHienTai = dbContext.CHITIETCALAMVIECs.FirstOrDefault(c => c.MaCa.Trim() == cmbStaff.Text.Trim());

                if (CaLamViecHienTai != null)
                {
                    string maNhanVien = cmbStaff.SelectedValue?.ToString() ?? "NV000"; 

                    if (CaLamViecHienTai.MaNV == "NV000")
                    {
                        CaLamViecHienTai.MaNV = maNhanVien;
                        dbContext.SaveChanges();

                        MessageBox.Show("Thêm ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CaLamViecHienTai.MaNV = maNhanVien;
                        dbContext.SaveChanges();

                        MessageBox.Show("Sửa ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadShiftToGrid();
                    ResetSearchFields();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ca làm việc với mã ca này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetSearchFields();
            LoadShiftToGrid() ;
        }

        private void ResetSearchFields()
        {
            cmbStaff.SelectedIndex = -1;
            cmbShift.SelectedIndex = -1;
            dateTimePickerNgayLam.CustomFormat = " ";
            dateTimePickerNgayLam.Format = DateTimePickerFormat.Custom;
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
