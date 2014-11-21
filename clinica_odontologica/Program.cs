using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_odontologica
{
    static class Program
    {
        public static string usuario;
        public static string usuario_id = "1";
        public static string img_path = @"C:\wamp\www\Fatec\ILP580\clinica_odontologica\pacientes-imagens\";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            
            
        }
    }
}
