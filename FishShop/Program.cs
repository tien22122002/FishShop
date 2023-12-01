using FishShop.Utils;
using FishShop.view;
using FishShop.View;

namespace FishShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.serverName = "(local)";
            DatabaseHelper.databaseName = "ShopCaCanh";
            DatabaseHelper.userId = "sa";
            DatabaseHelper.password = "tien2212";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}