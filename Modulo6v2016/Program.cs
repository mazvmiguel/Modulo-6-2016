using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Modulo6
{
    static class Program
    {

        public static String Usuario = ""; // Modifiable in Code
        public static String  PeriodoTrabajoId= ""; // Modifiable in Code
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]

      
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
              // Application.Run(new Modulo6._forms.Welcome());
           // Application.Run(new Modulo6._forms.frmImportacion());
            //Application.Run(new Modulo6._forms.frmEjercicio());
            //Application.Run(new Modulo6._forms.frmClave());
        }
    }
}