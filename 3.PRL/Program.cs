using _3.PRL.Views;
using _3.PRL.Views.BaoHanh;
using _3.PRL.Views.DangNhap;
using _3.PRL.Views.GiamGia;
using _3.PRL.Views.SanPham;
using _3.PRL.Views.ThanhToan;
using _3.PRL.Views.ThongKe;

namespace _3.PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_DangNhap2());
            // Scaffold-DbContext "Server=DESKTOP-B52SRBN\SQLEXPRESS;Database= OnlyFans;Trusted_Connection=True;"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model1s
        }
    }
}