using System;
using System.Windows.Forms;
using WindowsForm_ofass.BookManagemnt;

namespace WindowsForm_ofass
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LibraryReport());
        }
    }
}
