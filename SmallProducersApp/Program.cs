using SmallProducersApp.Data;
using Microsoft.EntityFrameworkCore;
using SmallProducersApp.Models;

namespace SmallProducersApp
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
            Application.Run(new IndexForm());
        }
    }
}