using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new HomePageForm());
            //Application.Run(new ProductGatetoryForm());
            //Application.Run(new TestForm());
            //Application.Run(new SaleForm());
        }
    }
}
