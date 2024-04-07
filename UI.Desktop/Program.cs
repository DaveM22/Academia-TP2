using Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UI.Desktop.ApplicationForm;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //formLogin loginForm = new formLogin();

            //// Mostrar el formulario de login
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    // Una vez que se haya iniciado sesión correctamente, abre el formulario principal

            //}
            Adapter.SetContext(new AcademiaContext());
            Application.Run(new MasterForm());
        }
    }
}
