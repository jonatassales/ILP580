using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_odontologica
{
    static class Program
    {
        public static bool logou = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (logou) {
                Application.Run(new Home());
            } else {
                Application.Run(new Login());
            }
            
        }
    }
}
