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

            var fakeUser = new Model.DTOs.UserDto
            {
                UserId = 2,
                Name = "Juan Pérez",
                Email = "juan.perez@ejemplo.com",
                Password = "Password123!",
                IdRol = [1, 2, 3],
                Status = true
            };

            ApplicationConfiguration.Initialize();
            //Application.Run(new AppContext());
            Application.Run(new View.MdiMaster(fakeUser, 2));
        }
    }
}