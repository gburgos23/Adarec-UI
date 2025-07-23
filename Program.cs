using System.IO;

namespace Adarec_ui
{
    internal static class Program
    {
        /// <summary>
        ///  Verifica si la carpeta existe, si no la crea.
        /// </summary>
        private static void CheckImagesDir()
        {
            string folderPath = @"C:\Adarec\files\images";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckImagesDir();

            ApplicationConfiguration.Initialize();
            Application.Run(new AppContext());
        }
    }
}