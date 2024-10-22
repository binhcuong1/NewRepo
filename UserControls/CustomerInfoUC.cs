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
    public partial class CustomerInfoUC : UserControl
    {
        public ConveStoreDBContext dbContext;
        private List<CustomerViewModel> customerList;

        public CustomerInfoUC()
        {
            InitializeComponent();

            dbContext = new ConveStoreDBContext();
            LoadData();
            //dataGridView1.RowHeadersVisible = false;
            dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomerInfoUC_Load(object sender, EventArgs e)
        {
            BindToGrid();
        }

        private void LoadData()
        {
            customerList = dbContext.KHACHHANGs.Select(p => new CustomerViewModel
            {
                MaKH = p.MaKH,
                TenKH = p.TenKH,
                DiaChi = p.DiaChi,
                Sdt = p.Sdt,
            }).ToList();
        }

        private void BindToGrid()
        {
            dgvCustomerInfo.DataSource = customerList;
        }

        private void btnAddCustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG newKhachHang = new KHACHHANG();
                newKhachHang.MaKH = txtMaKH.Text;
                newKhachHang.TenKH = txtTenKH.Text;
                newKhachHang.DiaChi = txtDiaChi.Text;
                newKhachHang.Sdt = txtSDT.Text;

                dbContext.KHACHHANGs.Add(newKhachHang);
                dbContext.SaveChanges();

                LoadData();
                BindToGrid();
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                MessageBox.Show("Khách hàng đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không có khách hàng nào được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEditCustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text;
                KHACHHANG newkhachHang = dbContext.KHACHHANGs.FirstOrDefault(kh => kh.MaKH == maKH);

                if (newkhachHang != null)
                {
                    newkhachHang.MaKH = txtMaKH.Text;
                    newkhachHang.TenKH = txtTenKH.Text;
                    newkhachHang.DiaChi = txtDiaChi.Text;
                    newkhachHang.Sdt = txtSDT.Text;

                    dbContext.SaveChanges();

                    LoadData();
                    BindToGrid();

                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                }
                else
                {
                    // Thông báo nếu không tìm thấy khách hàng
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelectCustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text;

                KHACHHANG newkhachHang = dbContext.KHACHHANGs.FirstOrDefault(kh => kh.MaKH == maKH);

                if (newkhachHang != null)
                {
                    dbContext.KHACHHANGs.Remove(newkhachHang);
                    dbContext.SaveChanges();
                    LoadData();
                    BindToGrid();

                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                    MessageBox.Show("Khách hàng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    // Thông báo nếu không tìm thấy khách hàng
                    MessageBox.Show("Có lỗi xảy ra trong quá trình xóa khách hàng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchCustomerInfo_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                var result = dbContext.KHACHHANGs
                    .Where(kh => kh.TenKH.Contains(keyword) ||
                                 kh.DiaChi.Contains(keyword) ||
                                 kh.Sdt.Contains(keyword))
                    .Select(kh => new CustomerViewModel()
                    {
                        MaKH = kh.MaKH,
                        TenKH = kh.TenKH,
                        DiaChi = kh.DiaChi,
                        Sdt = kh.Sdt,
                    })
                    .ToList();
                dgvCustomerInfo.Refresh();
                dgvCustomerInfo.DataSource = result;

                txtTimKiem.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
            }
        }

        private void btnResertCustomerInfo_Click(object sender, EventArgs e)
        {
            LoadData();

            // Làm mới giao diện hiển thị dữ liệu cho dgvBillInfo
            BindToGrid();


            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            // Không xóa dữ liệu hiện tại của dgvCustomerInfo

            MessageBox.Show("Dữ liệu khách hàng đã được làm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
