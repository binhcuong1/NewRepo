using QuanLyCuaHang.Ultilities;
using QuanLyCuaHang.UserControls;
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

namespace QuanLyCuaHang
{
    public partial class StaffForm : Form
    {
        string currStaffID = string.Empty;

        ConveStoreDBContext db;

        List<StaffViewModel> staffList;

        // Sửa dòng này
        public StaffForm()
        {
            InitializeComponent();

            db = new ConveStoreDBContext();

            LoadStaffToGrid();

            dgvStaff.CellClick += dgvStaff_CellContentClick;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // Ẩn panel
            pnlEditStaff.Visible = false;

            BindToGrid();
        }

        void LoadStaffToGrid()
        {
            // Lọc những nhân viên có tên khác "Đã Xóa"
            var staffListFake = db.NHANVIENs
                .Where(nv => nv.TenNV.Trim().ToLower() != "đã xóa")
                .Select(nv => new StaffViewModel
                {
                    MaNV = nv.MaNV,
                    TenNV = nv.TenNV,
                    Sdt = nv.Sdt,
                    DiaChi = nv.DiaChi,
                    NgayVaoLam = nv.NgayVaoLam
                }).ToList();

            staffList = null;
            staffList = staffListFake;
        }

        void BindToGrid()
        {
            // Thiết lập tên của cột sẽ hiển thị thuộc tính trong dgv
            dgvStaff.Columns["column1"].DataPropertyName = "MaNV";
            dgvStaff.Columns["column2"].DataPropertyName = "TenNV";
            dgvStaff.Columns["column3"].DataPropertyName = "Sdt";
            dgvStaff.Columns["column4"].DataPropertyName = "DiaChi";
            dgvStaff.Columns["column5"].DataPropertyName = "NgayVaoLam";

            dgvStaff.DataSource = staffList;
        }

        #region Button Methods
        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            Ultilities.Services.SetCenterPanel(this, pnlEditStaff);

            pnlEditStaff.Visible = true;
            pnlEditStaff.BringToFront();

            AddStaffUC addStaffUC = new AddStaffUC(ref pnlEditStaff, ref dgvStaff);
            pnlEditStaff.Controls.Add(addStaffUC);
            addStaffUC.Dock = DockStyle.Fill;
        }

        private void BtnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currStaffID))
                    throw new Exception("Hãy click vào nhân viên cần xóa");

                NHANVIEN staffToDelete = db.NHANVIENs.FirstOrDefault(nv => nv.MaNV == currStaffID);

                if (staffToDelete is null)
                    throw new Exception("Không tìm thấy nhân viên, hãy làm mới lại bảng");
                else
                {
                    DialogResult resultYesOrNo = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultYesOrNo == DialogResult.Yes)
                    {
                        staffToDelete.TenNV = "Đã Xóa";

                        db.SaveChanges();

                        LoadStaffToGrid();
                        BindToGrid();

                        throw new Exception("Xóa nhân viên thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                currStaffID = string.Empty;
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSalaryList_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currStaffID))
                    throw new Exception("Hãy click vào nhân viên cần xem lương");

                Ultilities.Services.SetCenterPanel(this, pnlEditStaff);

                pnlEditStaff.Visible = true;
                pnlEditStaff.BringToFront();

                SalaryListUC salaryList = new SalaryListUC(ref pnlEditStaff, ref dgvStaff, currStaffID);
                pnlEditStaff.Controls.Add(salaryList);
                salaryList.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                currStaffID = string.Empty;
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng hiện tại có hợp lệ không (dòng tiêu đề không được tính)
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của cột "MaNV" từ dòng được click
                string ProductID = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();

                currStaffID = ProductID;
            }
        }

        
    }
}
