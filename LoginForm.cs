using QuanLyCuaHang.Model;
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
    public partial class LoginForm : Form
    {
        ConveStoreDBContext db = new ConveStoreDBContext();
        public event Action<string> OnLoginSuccess;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #region Method Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            
            // Trả về phân quyền của tài khoản hoặc null
            string roleCurrent = IsLogin(username, password);

            if (!string.IsNullOrEmpty(roleCurrent))
            {

                HomePageForm formHomePage = new HomePageForm(roleCurrent);
                formHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kiểm tra tài khoản đăng nhập và phân quyền
        public string IsLogin(string username, string password)
        {
            var accountCurrent = db.TAIKHOANs
                .FirstOrDefault(u => u.TenTK == username.Trim() && u.MatKhau == password.Trim());


            if (accountCurrent != null)
            {
                UserSession.MaNhanVienDangNhap = accountCurrent.MaNV; // Lưu mã nhân viên

                // Lấy tên nhân viên từ bảng NHANVIEN
                string tenNhanVien = accountCurrent.NHANVIEN.TenNV; // Lưu tên nhân viên

                // Lưu thông tin vào session
                UserSession.TenNhanVien = tenNhanVien; // Lưu tên nhân viên
                UserSession.ChucVu = accountCurrent.CHUCVUNHANVIEN.TenChucVu; // Lưu chức vụ

                OnLoginSuccess?.Invoke(accountCurrent.MaNV); // Gọi sự kiện đăng nhập thành công
                return accountCurrent.CHUCVUNHANVIEN.TenChucVu;
            }
            else
            {
                return null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion 
    }
}
