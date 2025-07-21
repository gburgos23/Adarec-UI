using Adarec_ui.Controller;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace Adarec_ui.View
{
    public partial class Login : MaterialForm
    {
        public UserDto? UserData { get; private set; }

        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Orange700,
                TextShade.WHITE
            );
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            var usuario = txtUserName.Text;
            var contrasena = txtPassword.Text;

            var loginDto = new LoginDto(usuario, contrasena);
            var controller = new LoginController();

            var apiResponse = await controller.LoginAsync(loginDto);

            if (apiResponse.StatusCode == 200)
            {
                MessageBox.Show("Ingreso Éxitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserData = JsonConvert.DeserializeObject<UserDto>(apiResponse.Message);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(apiResponse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "¿Seguro que quieres salir?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
