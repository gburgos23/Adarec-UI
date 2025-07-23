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

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,
                Primary.Teal700,
                Primary.Teal100,
                Accent.Orange200,
                TextShade.BLACK);

            lblSelectRol.Text = "Seleccione el Rol";
            lblSelectRol.Font = new Font("Segoe UI", 17F, FontStyle.Regular);
            lblSelectRol.ForeColor = Color.FromArgb(0, 150, 136); 
            lblSelectRol.BackColor = Color.Transparent;
            lblSelectRol.TextAlign = ContentAlignment.MiddleCenter;
            lblSelectRol.AutoSize = false;
            lblSelectRol.Size = new Size(300, 38);
            lblSelectRol.Location = new Point((this.Width - lblSelectRol.Width) / 2, 40);
            
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
                cmbRoles.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los roles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cmbRoles.SelectedValue is int selectedRol)
            {
                SelectedRol = selectedRol;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
