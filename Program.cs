using System;

/*
Prueba tecnica

APIs:
-Facts Random: https://catfact.ninja/fact
-Imagen random: https://cataas.com/cat/says/hello

Recupera un hecho aleatorio de gatos y muestra una imagen de un gato con la primera palabra del hecho.

*/

namespace APIs
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
            Application.Run(new Form1());
        }
    }
}