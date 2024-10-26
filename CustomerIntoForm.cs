using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class CustomerIntoForm : Form
    {
        public ConveStoreDBContext dbContext;
        private List<CustomerViewModel> customerList;

        public CustomerIntoForm(string phoneNumber = null)
        {
            InitializeComponent();

            dbContext = new ConveStoreDBContext();

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                txtSDT.Text = phoneNumber;
            }

            LoadData();
            dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public CustomerIntoForm()
        {
            InitializeComponent();

            dbContext = new ConveStoreDBContext();
            LoadData();
            //dataGridView1.RowHeadersVisible = false;
            dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomerIntoForm_Load(object sender, EventArgs e)
        {
            BindToGrid();
        }

        private void LoadData()
        {
            customerList = dbContext.KHACHHANGs
                .Where(kh => kh.TenKH != "đã xóa")
                .Select(p => new CustomerViewModel
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
            // Kiểm tra nếu các trường thông tin bị trống
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newCustomer = new KHACHHANG
            {
                MaKH = GenerateCustomerId(), // Tự động tạo MaKH
                TenKH = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                Sdt = txtSDT.Text,
            };

            // Thêm khách hàng vào cơ sở dữ liệu
            dbContext.KHACHHANGs.Add(newCustomer);
            dbContext.SaveChanges();

            // Cập nhật danh sách khách hàng và DataGridView
            LoadData();
            BindToGrid();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            MessageBox.Show("Khách hàng đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GenerateCustomerId()
        {
            int nextId = dbContext.KHACHHANGs.Count() + 1;
            return "KH" + nextId.ToString("D3"); // Tạo MaKH với định dạng KH0001, KH0002, ...
        }

        private void btnEditCustomerInfo_Click(object sender, EventArgs e)
        {
            if (dgvCustomerInfo.CurrentRow != null)
            {
                // Kiểm tra nếu các trường thông tin bị trống
                if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedMaKH = dgvCustomerInfo.CurrentRow.Cells["MaKH"].Value.ToString();
                var customerToEdit = dbContext.KHACHHANGs.FirstOrDefault(c => c.MaKH == selectedMaKH);
                if (customerToEdit != null)
                {
                    customerToEdit.TenKH = txtTenKH.Text;
                    customerToEdit.DiaChi = txtDiaChi.Text;
                    customerToEdit.Sdt = txtSDT.Text;

                    dbContext.SaveChanges();

                    // Cập nhật danh sách khách hàng và DataGridView
                    LoadData();
                    BindToGrid();
                    txtTenKH.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();

                    MessageBox.Show("Thông tin khách hàng đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelectCustomerInfo_Click(object sender, EventArgs e)
        {
            if (dgvCustomerInfo.CurrentRow != null)
            {
                string selectedMaKH = dgvCustomerInfo.CurrentRow.Cells["MaKH"].Value.ToString();
                var customerToDelete = dbContext.KHACHHANGs.FirstOrDefault(c => c.MaKH == selectedMaKH);
                if (customerToDelete != null)
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        customerToDelete.TenKH = "đã xóa";

                        dbContext.SaveChanges();

                        // Cập nhật danh sách khách hàng và DataGridView
                        LoadData();
                        BindToGrid();

                        MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

        private void btnSearchCustomerInfo_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.ToLower();
            var searchResult = customerList.Where(c => c.TenKH.ToLower().Contains(searchValue) ||
                                                       c.DiaChi.ToLower().Contains(searchValue) ||
                                                       c.Sdt.Contains(searchValue)).ToList();
            dgvCustomerInfo.DataSource = searchResult;

            if (searchResult.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimKiem.Clear();
        }

        private void btnResertCustomerInfo_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các trường nhập liệu
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTimKiem.Text = string.Empty;

            // Cập nhật lại DataGridView với danh sách khách hàng đầy đủ
            LoadData();
            BindToGrid();

            MessageBox.Show("Dữ liệu đã được làm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            this.Hide();
            homePageForm.Show();
        }

    }
}
