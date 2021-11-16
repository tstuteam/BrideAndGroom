using System;
using System.Windows.Forms;
using BrideAndGroomLibrary;

namespace WinFormsAppBrideAndGroom
{
    internal class Program
    {
        public static readonly GoodLuck Agency = new();

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
