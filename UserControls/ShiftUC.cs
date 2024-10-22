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
    public partial class ShiftUC : UserControl
    {
        private ShiftViewModel viewModel;

        private ConveStoreDBContext dbContext;

        List<ShiftViewModel> shiftLists;

        private DateTime? selectedDate = null;

        public ShiftUC()
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
            dgvOfShiftUC.RowHeadersVisible = false;
            dgvOfShiftUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOfShiftUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOfShiftUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            var caLamViecList = viewModel.LoadData();
            dgvOfShiftUC.DataSource = caLamViecList;

            dgvOfShiftUC.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            dgvOfShiftUC.Columns["TenCa"].HeaderText = "Ca Làm Việc";
            dgvOfShiftUC.Columns["MaLoaiCa"].Visible = false;
            dgvOfShiftUC.Columns["MaCa"].Visible = false;
            dgvOfShiftUC.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dgvOfShiftUC.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dgvOfShiftUC.Columns["NgayLam"].HeaderText = "Ngày Làm";
            dgvOfShiftUC.Columns["TrangThai"].HeaderText = "Trạng Thái";
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

            List<ShiftViewModel> ketQuaTimKiem = viewModel.TimKiemTheoTieuChi(ngayLam, maNhanVien, tenCa);

            dgvOfShiftUC.DataSource = ketQuaTimKiem;
            ResetSearchFields();
        }

        private void btnAddAndUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var CaLamViecHienTai = dbContext.CHITIETCALAMVIECs.FirstOrDefault(c => c.MaCa.Trim() == txtMaCa.Text.Trim());

                if (CaLamViecHienTai != null)
                {
                    string maNhanVien = cmbStaff.SelectedValue?.ToString() ?? "NV000"; // Lấy mã NV hoặc "NV000" nếu không có lựa chọn

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
    }
}
