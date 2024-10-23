using QuanLyCuaHang.Ultilities;
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
        ConveStoreDBContext db;

        List<StaffViewModel> staffList;

        // Sửa dòng này
        public StaffForm()
        {
            InitializeComponent();

            db = new ConveStoreDBContext();

            LoadStaffToGrid();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            BindToGrid();
        }

        void LoadStaffToGrid()
        {
            staffList = db.NHANVIENs.Select(nv => new StaffViewModel
            {
                MaNV = nv.MaNV,
                TenNV = nv.TenNV,
                Sdt = nv.Sdt,
                DiaChi = nv.DiaChi,
                NgayVaoLam = nv.NgayVaoLam
            }).ToList();
        }

        void BindToGrid()
        {
            dgvStaff.DataSource = staffList;
        }
    }
}
