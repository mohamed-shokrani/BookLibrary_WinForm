using System;
using System.Windows.Forms;
using WindowsForm_ofass.BookManagemnt;
using WindowsForm_ofass.BookSubManagemnt;

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

            Application.Run(new SignInPage());
        }
    }
}
