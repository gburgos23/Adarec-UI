using Adarec_ui.Controller;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmUserManagement : MaterialForm
    {
        private readonly UserController _userController = new();
        private List<TechnicianDto> usuariosOriginal = [];
        private bool cancelValidation = false;
        private int? selectedUserId = null;

        public FrmUserManagement()
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

            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#E0F2F1");
            dataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B2DFDB");
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#004D40");
            dataGridView1.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#80CBC4");
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#26A69A");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);

            dataGridView1.GridColor = ColorTranslator.FromHtml("#B2DFDB");
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private async void FrmUserManagement_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            var response = await _userController.GetUsersAsync();
            if (response.StatusCode == 200)
            {
                usuariosOriginal = JsonConvert.DeserializeObject<List<TechnicianDto>>(response.Message) ?? [];
                dataGridView1.DataSource = usuariosOriginal;

                try
                {
                    if (dataGridView1.Columns["Password"] != null)
                        dataGridView1.Columns["Password"].Visible = false;
                    if (dataGridView1.Columns["TechnicianId"] != null)
                        dataGridView1.Columns["TechnicianId"].HeaderText = "ID";
                    if (dataGridView1.Columns["Name"] != null)
                        dataGridView1.Columns["Name"].HeaderText = "Nombre";
                    if (dataGridView1.Columns["Email"] != null)
                        dataGridView1.Columns["Email"].HeaderText = "Correo";
                    if (dataGridView1.Columns["Status"] != null)
                        dataGridView1.Columns["Status"].HeaderText = "Activo";

                    if (dataGridView1.Columns["Roles"] == null)
                    {
                        var col = new DataGridViewTextBoxColumn
                        {
                            Name = "Roles",
                            HeaderText = "Roles",
                            DataPropertyName = "IdRol"
                        };
                        dataGridView1.Columns.Add(col);
                    }

                    dataGridView1.CellFormatting += (s, e) =>
                    {
                        if (dataGridView1.Columns[e.ColumnIndex].Name == "Roles" && e.Value is List<int?> roles)
                        {
                            var nombres = new List<string>();
                            if (roles.Contains(1)) nombres.Add("Admin");
                            if (roles.Contains(2)) nombres.Add("Tech");
                            if (roles.Contains(3)) nombres.Add("Front");
                            e.Value = string.Join(", ", nombres);
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al configurar las columnas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No se pudieron cargar los usuarios.\n {response.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = null;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (cancelValidation)
            {
                cancelValidation = false;
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Correo electrónico no válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            SanitizeField(txtName);
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            SanitizeField(txtPassword);
        }

        private static void SanitizeField(MaterialTextBox txt)
        {
            string texto = Regex.Replace(txt.Text, @"[;'\-""\\/*%]", string.Empty);
            if (txt.Text != texto)
            {
                int pos = txt.SelectionStart - (txt.Text.Length - texto.Length);
                txt.Text = texto;
                txt.SelectionStart = pos > 0 ? pos : 0;
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Correo electrónico no válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            var selectedRoles = GetSelectedRoles();
            if (selectedRoles.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoUsuario = new TechnicianDto
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                IdRol = GetSelectedRoles(),
                Status = chkActivo.Checked
            };

            var response = await _userController.AddUserAsync(nuevoUsuario);
            if (response.StatusCode == 201)
            {
                MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                await LoadUsersAsync();
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnUpdate.Visible = false;
            btnAdd.Visible = false;

            btnUpdateConfirm.Visible = true;
            btnUpdateCancel.Visible = true;

            if (dataGridView1.CurrentRow.DataBoundItem is TechnicianDto usuario)
            {
                selectedUserId = usuario.TechnicianId;
                txtName.Text = usuario.Name;
                txtEmail.Text = usuario.Email;
                txtPassword.Text = usuario.Password ?? "";
                chkActivo.Checked = usuario.Status;
                selectedUserId = usuario.TechnicianId;
                ckAdmin.Checked = usuario.IdRol.Contains(1);
                ckTech.Checked = usuario.IdRol.Contains(2);
                ckFront.Checked = usuario.IdRol.Contains(3);
            }
        }

        private async void BtnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Correo electrónico no válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            var usuario = new TechnicianDto
            {
                TechnicianId = selectedUserId,
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                IdRol = GetSelectedRoles(),
                Status = chkActivo.Checked
            };

            var response = await _userController.UpdateUserAsync(usuario);
            if (response.StatusCode == 204)
            {
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                await LoadUsersAsync();
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            btnUpdate.Visible = true;
            btnAdd.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;

            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            ckAdmin.Checked = false;
            ckTech.Checked = false;
            ckFront.Checked = false;
            chkActivo.Checked = true;
            selectedUserId = null;
        }

        private List<int?> GetSelectedRoles()
        {
            var roles = new List<int?>();
            if (ckAdmin.Checked) roles.Add(1);
            if (ckTech.Checked) roles.Add(2);
            if (ckFront.Checked) roles.Add(3);
            return roles;
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cancelValidation = true;
                this.ActiveControl = null;
            }
        }
    }
}
