using System;
using System.Windows.Forms;

namespace WeatherApp
{
    static class Program
    {
        /// <summary>
        /// Основная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}