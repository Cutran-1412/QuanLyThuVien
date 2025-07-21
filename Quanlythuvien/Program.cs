using Quanlythuvien.Controllers;
using Quanlythuvien.Views;
namespace Quanlythuvien
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>~
        [STAThread]
        static void Main()
        {
            AdminController ad = new AdminController();
            ad.Get_Admin();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}