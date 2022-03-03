using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Program_v4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //Creating a variable of frmMainWindow to be used when referencing controls.
        public static frmMainWindow mainWindow;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainWindow = new frmMainWindow();
            Application.Run(mainWindow);
        }
    }
}
