using Business.Data;
using Business.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        /// 

        public static Usuario Usuario { get; set; }

        public static bool IsLoggin { get; set; }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Adapter.SetContext(new AcademiaContext());
            formLogin loginForm = new formLogin();
            Application.Run(new formLogin());
            if (Program.IsLoggin)
            {
                Application.Run(new MasterForm(Program.Usuario));
            }
        }
    }
}
