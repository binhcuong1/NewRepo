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
    public partial class SalaryListUC : UserControl
    {
        ConveStoreDBContext db;

        SalaryStaffViewModel currStaff;

        private Panel currPanel;
        private string currStaffID;

        public SalaryListUC(ref Panel currPanel, ref DataGridView currDgv, string str)
        {
            InitializeComponent();

            db = new ConveStoreDBContext();

            this.currPanel = currPanel;

            currStaffID = str;
        }

        private void SalaryListUC_Load(object sender, EventArgs e)
        {
            txtSumSalary.Text = currStaffID;

            var currStaff = db.NHANVIENs.FirstOrDefault(nv => nv.MaNV == currStaffID);
            lblShowNameStaff.Text = currStaff.TenNV;
            lblShowIDStaff.Text = currStaffID;
        }

        #region Button Methods
        private void btnBackToProductGateFrm_Click(object sender, EventArgs e)
        {
            // Ẩn UserControl
            this.Visible = false;

            // Ẩn panel chứa UserControl
            if (currPanel != null)
            {
                currPanel.Visible = false; // Ẩn panel
            }
        }

        private void BtnCheckSalary_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
