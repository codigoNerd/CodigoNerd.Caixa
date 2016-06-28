using CodigoNerd.Caixa.WinUI.Formularios;
using System;
using System.Windows.Forms;

namespace CodigoNerd.Caixa.WinUI
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
            Application.Run(new Login());
        }
    }
}
