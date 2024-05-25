using DB;
using farmacia.Clases.Entidades;
using farmacia.Formularios;
using farmacia.Formularios.multimedia;
using PharmaSync.formularios;

namespace farmacia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm: new Login());
        }
    }
}