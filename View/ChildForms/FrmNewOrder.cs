using Adarec_ui.Controller;
using Adarec_ui.Model;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmNewOrder : MaterialForm
    {
        private readonly UserDto _userData;
        private List<DeviceDetailDto> devices = [];
        private List<DeviceModelDto> models = [];
        private int? editingIndex = null;
        private string? selectedImagePath = null;

        public FrmNewOrder(UserDto userData)
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

            dtEquipos.BackgroundColor = ColorTranslator.FromHtml("#E0F2F1");
            dtEquipos.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B2DFDB");
            dtEquipos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dtEquipos.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#004D40");
            dtEquipos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#80CBC4");
            dtEquipos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dtEquipos.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            dtEquipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#26A69A");
            dtEquipos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtEquipos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);

            dtEquipos.GridColor = ColorTranslator.FromHtml("#B2DFDB");
            dtEquipos.BorderStyle = BorderStyle.None;
            dtEquipos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtEquipos.EnableHeadersVisualStyles = false;

            _userData = userData;
            LoadCombosAsync();

            dpDate.Format = DateTimePickerFormat.Custom;
            dpDate.CustomFormat = "yyyy/MM/dd"; 
            dpDate.MinDate = DateTime.Today;
            dpDate.Value = DateTime.Today;
            dpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dpDate.ForeColor = ColorTranslator.FromHtml("#004D40");
            dpDate.CalendarForeColor = ColorTranslator.FromHtml("#004D40");
            dpDate.CalendarMonthBackground = ColorTranslator.FromHtml("#E0F2F1");
            dpDate.CalendarTitleBackColor = ColorTranslator.FromHtml("#26A69A");
            dpDate.CalendarTitleForeColor = Color.White;
            dpDate.CalendarTrailingForeColor = ColorTranslator.FromHtml("#004D40");
        }

        private async void LoadCombosAsync()
        {
            var modelController = new DeviceController();
            var modelResponse = await modelController.GetActiveModelsAsync();
            if (modelResponse.StatusCode == 200)
            {
                var modelsList = JsonConvert.DeserializeObject<List<DeviceModelDto>>(modelResponse.Message);
                models = modelsList ?? [];
                cmbModels.DataSource = models;
                cmbModels.DisplayMember = "Description";
                cmbModels.ValueMember = "ModelId";
                cmbModels.SelectedIndex = -1;
            }

            var userController = new UserController();
            var userResponse = await userController.GetUsersAsync();
            if (userResponse.StatusCode == 200)
            {
                var users = JsonConvert.DeserializeObject<List<TechnicianDto>>(userResponse.Message);
                var techs = users?
                    .Where(u => u.IdRol != null && u.IdRol.Contains((int)Roles.technician))
                    .ToList();

                cmbTechnician.DataSource = techs;
                cmbTechnician.DisplayMember = "Name";
                cmbTechnician.ValueMember = "TechnicianId";
                cmbTechnician.SelectedIndex = -1;
            }
        }

        private void ImgClick(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Title = "Selecciona una imagen";
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(ofd.FileName);
                selectedImagePath = ofd.FileName;
            }
        }

        private void ImgDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void ImgDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                pbImage.Image = Image.FromFile(files[0]);
                selectedImagePath = files[0];
            }
        }

        private static bool IsImageFile(string file)
        {
            string ext = Path.GetExtension(file).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        private static string CopyImg(string originalPath, int orderNumber, int detailId)
        {
            if (string.IsNullOrEmpty(originalPath) || !File.Exists(originalPath))
                return null;

            string basePath = ConfigurationManager.AppSettings["imagesPath"]!;
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            string ext = Path.GetExtension(originalPath).ToLower();
            string fileName = $"{DateTime.Now:yyyyMMdd}-{orderNumber}-{detailId}{ext}";
            string destPath = Path.Combine(basePath, fileName);

            File.Copy(originalPath, destPath, true);
            return destPath;
        }

        private void TxtSanitizeChanged(object sender, System.EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;
            string texto = SanitizeText(txt.Text);
            if (txt.Text != texto)
            {
                int pos = txt.SelectionStart - (txt.Text.Length - texto.Length);
                txt.Text = texto;
                txt.SelectionStart = pos > 0 ? pos : 0;
            }
        }

        private static string SanitizeText(string input)
        {
            string pattern = @"[;'\-""\\/*%]";
            return Regex.Replace(input, pattern, string.Empty);
        }

        private void TxtClientKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtClientChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtClient.Text, @"[^\d]", "");
            if (texto.Length > 10)
                texto = texto[..10];
            if (txtClient.Text != texto)
                txtClient.Text = texto;
            txtClient.SelectionStart = txtClient.Text.Length;
        }

        private void TxtQtyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtQtyChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtQuantity.Text, @"[^\d]", "");
            if (txtQuantity.Text != texto)
                txtQuantity.Text = texto;
            txtQuantity.SelectionStart = txtQuantity.Text.Length;
        }

        private async void BtnSaveClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClient.Text) ||
                string.IsNullOrWhiteSpace(txtFailDesc.Text) ||
                devices.Count == 0 ||
                cmbTechnician.SelectedIndex == -1 ||
                dpDate.Value.Date < DateTime.Today)
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

            var order = new OrderDto
            {
                Description = txtFailDesc.Text.Trim(),
                ScheduledFor = dpDate.Value,
                OrderStatusId = 1,
                Customer = cliente!,
                Devices = [],
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
                var respObj = JsonConvert.DeserializeObject<dynamic>(response.Message);
                int orderNumber = (int)respObj?.orderId;

                for (int i = 0; i < devices.Count; i++)
                {
                    var device = devices[i];
                    if (!string.IsNullOrEmpty(device.IntakePhoto) && File.Exists(device.IntakePhoto))
                    {
                        string newFileName = CopyImg(device.IntakePhoto, orderNumber, i + 1);
                        device.IntakePhoto = newFileName;
                    }
                    device.OrderId = orderNumber;
                    await orderController.AddDeviceDetailsAsync(device);
                }

                MessageBox.Show("Orden agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error al agregar la orden: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtClient.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            txtFailDesc.Text = string.Empty;
            cmbModels.SelectedIndex = -1;
            cmbTechnician.SelectedIndex = -1;
            pbImage.Image = null;
            selectedImagePath = null;
            devices.Clear();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            string basePath = ConfigurationManager.AppSettings["imagesPath"]!;
            var data = devices.Select(e => new
            {
                Modelo = models.FirstOrDefault(m => m.ModelId == e.ModelId)?.Description ?? "Desconocido",
                Cantidad = e.Quantity,
                Especificaciones = e.DeviceSpecs,
                Imagen = !string.IsNullOrEmpty(e.IntakePhoto) && File.Exists(Path.Combine(basePath, e.IntakePhoto))
                    ? Image.FromFile(Path.Combine(basePath, e.IntakePhoto))
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

        private void BtnAddClick(object sender, EventArgs e)
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

            if (selectedImagePath == null)
            {
                var result = MessageBox.Show("No se ha seleccionado una imagen. ¿Desea continuar sin imagen?", "Imagen opcional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }

            var device = new DeviceDetailDto
            {
                ModelId = (int)cmbModels.SelectedValue!,
                Quantity = cantidad,
                DeviceSpecs = txtDevSpec.Text.Trim(),
                ItemStatusId = (int)ItemStatus.Received,
                IntakePhoto = selectedImagePath
            };

            devices.Add(device);
            RefreshGrid();

            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            pbImage.Image = null;
            selectedImagePath = null;
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            if (dtEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dtEquipos.CurrentRow.Index;
            if (rowIndex < 0 || rowIndex >= devices.Count)
            {
                MessageBox.Show("Ítem no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var device = devices[rowIndex];
            editingIndex = rowIndex;

            cmbModels.SelectedValue = device.ModelId;
            txtQuantity.Text = device.Quantity.ToString();
            txtDevSpec.Text = device.DeviceSpecs;

            string basePath = ConfigurationManager.AppSettings["imagesPath"]!;
            pbImage.Image = !string.IsNullOrEmpty(device.IntakePhoto) && File.Exists(Path.Combine(basePath, device.IntakePhoto))
                ? Image.FromFile(Path.Combine(basePath, device.IntakePhoto))
                : null;
            selectedImagePath = !string.IsNullOrEmpty(device.IntakePhoto) ? Path.Combine(basePath, device.IntakePhoto) : null;

            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnUpdateCancel.Visible = true;
        }

        private void BtnEditConfirmClick(object sender, EventArgs e)
        {
            if (editingIndex == null || editingIndex < 0 || editingIndex >= devices.Count)
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

            var device = devices[(int)editingIndex];
            device.ModelId = (int)cmbModels.SelectedValue!;
            device.Quantity = cantidad;
            device.DeviceSpecs = txtDevSpec.Text.Trim();

            if (selectedImagePath == null)
            {
                var result = MessageBox.Show("No se ha seleccionado una imagen. ¿Desea continuar sin imagen?", "Imagen opcional", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }

            device.IntakePhoto = selectedImagePath;

            RefreshGrid();

            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            pbImage.Image = null;
            selectedImagePath = null;
            btnDelete.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
            editingIndex = null;
        }

        private void BtnEditCancelClick(object sender, EventArgs e)
        {
            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            pbImage.Image = null;
            selectedImagePath = null;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
            editingIndex = null;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (dtEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dtEquipos.CurrentRow.Index;
            if (rowIndex < 0 || rowIndex >= devices.Count)
            {
                MessageBox.Show("Ítem no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro que desea eliminar este equipo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            devices.RemoveAt(rowIndex);
            RefreshGrid();
        }
    }
}
