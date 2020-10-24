using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace AgeOfVillagers
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
            Application.Run(new VillageWindow());
         
        }

    }
}
