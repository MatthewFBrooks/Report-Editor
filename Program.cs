using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //static SplashScreen Splash;
        //static MainWindow MainWindow;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new MainWindow());
            } catch(ObjectDisposedException e)
            {
                //If the form closed itself, don't crash.
            }
        }
    }
}
