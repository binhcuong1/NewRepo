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
    public partial class AddStaffUC : UserControl
    {
        private int numOfStaff = 0;

        ConveStoreDBContext db;

        private Panel currPanel;
        private DataGridView currDgv;

        public AddStaffUC(ref Panel currPanel, ref DataGridView currDgv)
        {
            InitializeComponent();

            db = new ConveStoreDBContext();

            numOfStaff = db.NHANVIENs.Count();
            
            this.currPanel = currPanel;
            this.currDgv = currDgv;
        }



        private void AddStaffUC_Load(object sender, EventArgs e)
        {

        }

        #region Button Methods
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            bool isEmptyInput = string.IsNullOrEmpty(txtStaffName.Text)
                    || string.IsNullOrEmpty(txtNumberPhone.Text);

            try
            {
                if (isEmptyInput)
                    throw new Exception("Bạn phải chọn đầy đủ các lựa chọn");


                NHANVIEN newSfaff = FillInputToEntityProduct();
                db.NHANVIENs.Add(newSfaff);
                db.SaveChanges();

                throw new Exception("Thêm nhân viên thành công");
            }
            catch (Exception ex)
            {
                ResetInput();
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Ẩn UserControl
            this.Visible = false;

            // Ẩn panel chứa UserControl
            if (currPanel != null)
            {
                currPanel.Visible = false; // Ẩn panel
            }


            currDgv.DataSource = db.NHANVIENs.ToList();
        }
        #endregion


        #region Other Methods
        // Phương thức đổ input vào thực thể nhân viên mới
        private NHANVIEN FillInputToEntityProduct()
        {
            NHANVIEN result = new NHANVIEN();

            result.MaNV = CreateNewStaffID();
            result.TenNV = txtStaffName.Text;
            result.DiaChi = txtNumberPhone.Text;
            result.NgayVaoLam = DateTime.Today;

            return result;
        }

        // Phương thức tạo mới 1 mã nhân viên
        private string CreateNewStaffID()
        {
            string result = string.Empty;
            bool isTwoDigitNumber = numOfStaff <= 98 && numOfStaff >= 9;
            bool isThreeDigitNumber = numOfStaff <= 998 && numOfStaff >= 99;

            numOfStaff += 1;

            if (isTwoDigitNumber)
                result = "NV0" + numOfStaff.ToString().Trim();
            else if (isThreeDigitNumber)
                result = "NV" + numOfStaff.ToString().Trim();
            else
                result = "NV00" + numOfStaff.ToString().Trim();

            return result;
        }

        // Phương thức reset lại các giá trị input
        private void ResetInput()
        {
            txtAddress.Text = string.Empty;
            txtNumberPhone.Text = string.Empty;
            txtStaffName.Text = string.Empty;
        }
        #endregion

    }
}
