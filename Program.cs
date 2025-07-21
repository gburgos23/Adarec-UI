
namespace Adarec_ui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var fakeUser = new Model.DTOs.UserDto
            {
                UserId = 123,
                Name = "Juan Pérez",
                Email = "juan.perez@ejemplo.com",
                Password = "Password123!",
                IdRol = [1, 2, 3],
                Status = true
            };

            ApplicationConfiguration.Initialize();
            //Application.Run(new AppContext());
            Application.Run(new View.MdiMaster(fakeUser, 3));
        }
    }
}