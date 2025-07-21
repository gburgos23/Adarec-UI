using Adarec_ui.Model.DTOs;
using Adarec_ui.View;
using System;

namespace Adarec_ui
{
    internal class AppContext : ApplicationContext
    {
        public UserDto UserData { get; private set; }
        public int SelectedRol { get; private set; }

        public AppContext()
        {
            // 1) Mostrar Login
            using (var login = new Login())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    ExitThread(); 
                    return;
                }
                UserData = login.UserData!;
            }

            // 2) Mostrar selección de rol
            using (var rolForm = new Rol(UserData))
            {
                if (rolForm.ShowDialog() != DialogResult.OK)
                {
                    ExitThread();
                    return;
                }
                SelectedRol = rolForm.SelectedRol!.Value;
            }

            // 3) Arrancar el MDI principal
            var mainForm = new MdiMaster(UserData, SelectedRol);
            mainForm.FormClosed += (_, __) => ExitThread();
            mainForm.Show();
        }
    }
}
