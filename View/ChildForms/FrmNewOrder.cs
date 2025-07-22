using Adarec_ui.Controller;
using Adarec_ui.Model;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmNewOrder : MaterialForm
    {
        private readonly UserDto _userData;
        private List<DeviceDetailDto> equipos = [];
        private List<DeviceModelDto> modelos = [];
        private int? equipoEditandoIndex = null;

        public FrmNewOrder(UserDto userData)
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
            PrecargarCombosAsync();

            dtEquipos.BackgroundColor = Color.FromArgb(55, 71, 79);
            dtEquipos.DefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dtEquipos.DefaultCellStyle.ForeColor = Color.White;
            dtEquipos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dtEquipos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtEquipos.EnableHeadersVisualStyles = false;

            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "yyyy/MM/dd";
            dtPicker.MinDate = DateTime.Today;
            dtPicker.Value = DateTime.Today;
        }

        private async void PrecargarCombosAsync()
        {
            // Precargar modelos
            var modelController = new DeviceController();
            var modelResponse = await modelController.GetActiveModelsAsync();
            if (modelResponse.StatusCode == 200)
            {
                var modelosList = JsonConvert.DeserializeObject<List<DeviceModelDto>>(modelResponse.Message);
                modelos = modelosList ?? [];
                cmbModels.DataSource = modelos;
                cmbModels.DisplayMember = "Description";
                cmbModels.ValueMember = "ModelId";
                cmbModels.SelectedIndex = -1;
            }

            // Precargar técnicos
            var userController = new UserController();
            var userResponse = await userController.GetUsersAsync();
            if (userResponse.StatusCode == 200)
            {
                var usuarios = JsonConvert.DeserializeObject<List<TechnicianDto>>(userResponse.Message);
                var tecnicos = usuarios?
                    .Where(u => u.IdRol != null && u.IdRol.Contains((int)Roles.technician))
                    .ToList();

                cmbTechnician.DataSource = tecnicos;
                cmbTechnician.DisplayMember = "Name";
                cmbTechnician.ValueMember = "TechnicianId";
                cmbTechnician.SelectedIndex = -1;
            }
        }

        private void PbImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Title = "Selecciona una imagen";
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void PbImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && EsArchivoImagen(files[0]))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void PbImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && EsArchivoImagen(files[0]))
            {
                pbImage.Image = Image.FromFile(files[0]);
            }
        }

        private static bool EsArchivoImagen(string file)
        {
            string ext = System.IO.Path.GetExtension(file).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        #region Validaciones de texto

        private void TxtSanitizar_TextChanged(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;
            string texto = SanitizarTexto(txt.Text);
            if (txt.Text != texto)
            {
                int pos = txt.SelectionStart - (txt.Text.Length - texto.Length);
                txt.Text = texto;
                txt.SelectionStart = pos > 0 ? pos : 0;
            }
        }

        private static string SanitizarTexto(string input)
        {
            string pattern = @"[;'\-""\\/*%]";
            return Regex.Replace(input, pattern, string.Empty);
        }

        private void TxtClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtClient_TextChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtClient.Text, @"[^\d]", "");
            if (texto.Length > 10)
                texto = texto[..10];
            if (txtClient.Text != texto)
                txtClient.Text = texto;
            txtClient.SelectionStart = txtClient.Text.Length;
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtQuantity.Text, @"[^\d]", "");
            if (txtQuantity.Text != texto)
                txtQuantity.Text = texto;
            txtQuantity.SelectionStart = txtQuantity.Text.Length;
        }

        private async void BtnFinish_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtClient.Text) ||
                string.IsNullOrWhiteSpace(txtFailDesc.Text) ||
                equipos.Count == 0 ||
                cmbTechnician.SelectedIndex == -1 ||
                dtPicker.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Todos los campos son obligatorios y la fecha debe ser igual o posterior a hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userController = new UserController();
            var clientResponse = await userController.GetCustomerByIdentificationAsync(txtClient.Text.Trim());
            CustomerDto? cliente = null;
            if (clientResponse.StatusCode == 200)
            {
                cliente = JsonConvert.DeserializeObject<CustomerDto>(clientResponse.Message);
            }
            else if (clientResponse.StatusCode == 404)
            {
                MessageBox.Show("No se encontró cliente. Debe agregar el cliente primero.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Error al consultar cliente: " + clientResponse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear DTO de la orden
            var order = new OrderDto
            {
                Description = txtFailDesc.Text.Trim(),
                ScheduledFor = dtPicker.Value,
                OrderStatusId = 1,
                Customer = cliente!,
                Devices = [.. equipos],
                TechnicianId = (int)cmbTechnician.SelectedValue!,
                LastComment = new CommentDetailDto
                {
                    Comment = txtFailDesc.Text.Trim(),
                    UserId = _userData.UserId,
                    CreatedAt = DateTime.Now
                }
            };

            var orderController = new OrderController();
            var response = await orderController.AddOrderAsync(order);
            if (response.StatusCode == 201)
            {
                MessageBox.Show("Orden agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar la orden: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtClient.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            txtFailDesc.Text = string.Empty;
            cmbModels.SelectedIndex = -1;
            cmbTechnician.SelectedIndex = -1;
            pbImage.Image = null;
            equipos.Clear();
            ActualizarGridEquipos();
        }

        private void ActualizarGridEquipos()
        {
            var data = equipos.Select(e => new
            {
                Modelo = modelos.FirstOrDefault(m => m.ModelId == e.ModelId)?.Description ?? "Desconocido",
                Cantidad = e.Quantity,
                Especificaciones = e.DeviceSpecs,
                Imagen = !string.IsNullOrEmpty(e.IntakePhoto)
                    ? ConvertirBase64AImagen(e.IntakePhoto)
                    : null
            }).ToList();

            dtEquipos.DataSource = null;
            dtEquipos.Columns.Clear();
            dtEquipos.DataSource = data;
            dtEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dtEquipos.Columns["Imagen"] != null)
            {
                var col = (DataGridViewImageColumn)dtEquipos.Columns["Imagen"];
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                col.HeaderText = "Imagen";
                col.Width = 60;
            }
        }

        private Image? ConvertirBase64AImagen(string base64)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64);
                using var ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbModels.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtDevSpec.Text))
            {
                MessageBox.Show("Debe seleccionar un modelo, ingresar cantidad y especificaciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pbImage.Image == null)
            {
                var result = MessageBox.Show("No se ha seleccionado una imagen. ¿Desea continuar sin imagen?", "Imagen opcional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }

            string? intakePhoto = null;
            if (pbImage.Image != null)
            {
                using var ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                intakePhoto = Convert.ToBase64String(ms.ToArray());
            }

            var equipo = new DeviceDetailDto
            {
                ModelId = (int)cmbModels.SelectedValue!,
                Quantity = cantidad,
                DeviceSpecs = txtDevSpec.Text.Trim(),
                ItemStatusId = (int)ItemStatus.Received,
                IntakePhoto = intakePhoto
            };

            equipos.Add(equipo);
            ActualizarGridEquipos();

            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            pbImage.Image = null;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dtEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dtEquipos.CurrentRow.Index;
            if (rowIndex < 0 || rowIndex >= equipos.Count)
            {
                MessageBox.Show("Ítem no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var equipo = equipos[rowIndex];
            equipoEditandoIndex = rowIndex;

            cmbModels.SelectedValue = equipo.ModelId;
            txtQuantity.Text = equipo.Quantity.ToString();
            txtDevSpec.Text = equipo.DeviceSpecs;
            pbImage.Image = !string.IsNullOrEmpty(equipo.IntakePhoto) ? ConvertirBase64AImagen(equipo.IntakePhoto) : null;

            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnUpdateCancel.Visible = true;
        }

        private void BtnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (equipoEditandoIndex == null || equipoEditandoIndex < 0 || equipoEditandoIndex >= equipos.Count)
            {
                MessageBox.Show("No hay equipo seleccionado para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbModels.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtDevSpec.Text))
            {
                MessageBox.Show("Debe seleccionar un modelo, ingresar cantidad y especificaciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var equipo = equipos[(int)equipoEditandoIndex];
            equipo.ModelId = (int)cmbModels.SelectedValue!;
            equipo.Quantity = cantidad;
            equipo.DeviceSpecs = txtDevSpec.Text.Trim();

            if (pbImage.Image == null)
            {
                var result = MessageBox.Show("No se ha seleccionado una imagen. ¿Desea continuar sin imagen?", "Imagen opcional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }

            string? intakePhoto = null;
            if (pbImage.Image != null)
            {
                using var ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                intakePhoto = Convert.ToBase64String(ms.ToArray());
            }

            equipo.IntakePhoto = intakePhoto;

            ActualizarGridEquipos();

            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            pbImage.Image = null;
            btnDelete.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
            equipoEditandoIndex = null;
        }

        private void BtnUpdateCancel_Click(object sender, EventArgs e)
        {
            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            pbImage.Image = null;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
            equipoEditandoIndex = null;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dtEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dtEquipos.CurrentRow.Index;
            if (rowIndex < 0 || rowIndex >= equipos.Count)
            {
                MessageBox.Show("Ítem no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro que desea eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            equipos.RemoveAt(rowIndex);
            ActualizarGridEquipos();
        }
    }
}
