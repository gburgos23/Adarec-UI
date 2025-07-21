using Adarec_ui.Controller;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace Adarec_ui.View
{
    public partial class Rol : MaterialForm
    {
        public int? SelectedRol { get; private set; }
        private readonly UserDto _userData;

        public Rol(UserDto userData)
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
            _userData = userData;
        }

        private async void Rol_Load(object sender, EventArgs e)
        {
            var controller = new RolController();
            var response = await controller.GetRoles();

            if (response.StatusCode == 200)
            {
                var allRoles = JsonConvert.DeserializeObject<List<RolDto>>(response.Message);

                // Filtrar roles según los IDs del usuario
                var userRoles = allRoles!
                    .Where(r => _userData.IdRol.Contains(r.Id))
                    .ToList();

                cmbRoles.DataSource = userRoles;
                cmbRoles.DisplayMember = "Name";
                cmbRoles.ValueMember = "RolId";
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los roles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(
                    "¿Seguro que quieres salir?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
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

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            //Aqui pasar datos al mdi que tendra todas las ventanas
        }
    }
}
