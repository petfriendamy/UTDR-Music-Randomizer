using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try //attempt to run the GTK form
            {
                Gtk.Application.Init();
                var win = new MainWindowUnix();
                win.Show();
                Gtk.Application.Run();
            }
            catch (TypeInitializationException)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFormWindows());
            }
        }
    }
}
