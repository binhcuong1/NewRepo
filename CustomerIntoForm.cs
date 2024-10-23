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
    public partial class CustomerIntoForm : Form
    {
        public ConveStoreDBContext dbContext;
        private List<CustomerViewModel> customerList;

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
            

        }

        private void btnEditCustomerInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelectCustomerInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchCustomerInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResertCustomerInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                HomePageForm homePageForm = new HomePageForm();
                this.Hide();
                homePageForm.Show();
            }
        }

    }
}
