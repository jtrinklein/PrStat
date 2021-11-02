using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Windows.Forms;
using PrStat.Core;
using Windows.Foundation.Collections;
using WinPrStatForm;

namespace WinPrStat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm();
            Application.Run(form);


        }
    }
}
