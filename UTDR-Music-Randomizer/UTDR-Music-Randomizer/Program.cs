using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gtk;

namespace UTDRMusicRandomizer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Init();
            var win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
