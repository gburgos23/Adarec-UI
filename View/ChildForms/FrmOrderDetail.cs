using Adarec_ui.Controller;
using Adarec_ui.Model;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmOrderDetail : MaterialForm
    {
        private readonly UserDto _userData;
        private readonly int _selectedRoleId;
        private readonly int _orderId;
        private readonly List<RolDto> _status = [];
        private List<DeviceDetailDto> items = [];
        private List<DeviceModelDto> modelos = [];
        private List<RolDto> estadosItem = [];
        private int? equipoEditandoIndex = null;
        private string? selectedImagePath = null;

        public FrmOrderDetail(UserDto userDto, int selectedRoleId, int orderId, List<RolDto> status)
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

            _selectedRoleId = selectedRoleId;
            _userData = userDto;
            _orderId = orderId;
            _status = status;

            txtOrderId.Text = _orderId.ToString();

            LoadCombosAsync();
            LoadOrderDetail();
        }

        private void SetControlsByRole(int orderStatus)
        {
            bool isEnable = _selectedRoleId == (int)Roles.admin && orderStatus != (int)OrderStatus.closed;

            txtComment.Enabled = isEnable;
            txtOrderId.Enabled = isEnable;
            txtDevSpec.Enabled = isEnable;
            txtQuantity.Enabled = isEnable;
            cmbStateOrder.Enabled = isEnable;
            cmbModels.Enabled = isEnable;
            cmbItemStatus.Enabled = isEnable;
            btnAdd.Enabled = isEnable;
            btnUpdateCancel.Enabled = isEnable;
            btnUpdateConfirm.Enabled = isEnable;
            btnUpdate.Enabled = isEnable;
            btnFinalice.Enabled = isEnable;

            btnUpdate.Visible = isEnable;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
        }

        private async void LoadCombosAsync()
        {
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

            var statusResponse = await modelController.GetAllItemStatusesAsync();
            if (statusResponse.StatusCode == 200)
            {
                var estadosList = JsonConvert.DeserializeObject<List<RolDto>>(statusResponse.Message);
                estadosItem = estadosList ?? [];
                cmbItemStatus.DataSource = estadosItem;
                cmbItemStatus.DisplayMember = "Name";
                cmbItemStatus.ValueMember = "Id";
                cmbItemStatus.SelectedIndex = -1;
            }
        }

        private void LoadOrderStatus(int selectedStatus)
        {
            cmbStateOrder.DataSource = new List<RolDto>(_status);
            cmbStateOrder.DisplayMember = "Name";
            cmbStateOrder.ValueMember = "Id";
            cmbStateOrder.SelectedValue = selectedStatus;
        }

        private async void LoadOrderDetail()
        {
            var orderController = new OrderController();
            var response = await orderController.GetOrderDetailByIdAsync(_orderId);
            if (response.StatusCode == 200)
            {
                var detalle = JsonConvert.DeserializeObject<OrderFullDetailDto>(response.Message);
                if (detalle != null)
                {
                    LoadOrderStatus(detalle.Status);
                    LoadComments(detalle.Comments);
                    items = detalle.Devices ?? [];
                    RefreshDevicesGrid();
                    SetControlsByRole(detalle.Status);
                }
            }
            else
            {
                MessageBox.Show("No se pudo cargar el detalle de la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComments(List<CommentDetailDto> comments)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns.Add("Comentario", "Comentario");
            dataGridView1.Columns.Add("Autor", "Autor");

            foreach (var comment in comments)
            {
                dataGridView1.Rows.Add(
                    comment.CreatedAt.ToString("dd/MM/yyyy"),
                    comment.Comment,
                    comment.UserName
                );
            }
        }

        private void RefreshDevicesGrid()
        {
            string basePath = ConfigurationManager.AppSettings["imagesPath"]!;
            var data = items.Select(e => new
            {
                Modelo = modelos.FirstOrDefault(m => m.ModelId == e.ModelId)?.Description ?? "Desconocido",
                Cantidad = e.Quantity,
                Especificaciones = e.DeviceSpecs,
                Imagen = !string.IsNullOrEmpty(e.IntakePhoto) && File.Exists(Path.Combine(basePath, e.IntakePhoto))
                    ? Image.FromFile(Path.Combine(basePath, e.IntakePhoto))
                    : null,
                Solución = !string.IsNullOrEmpty(e.SolutionPhoto) && File.Exists(Path.Combine(basePath, e.SolutionPhoto))
                    ? Image.FromFile(Path.Combine(basePath, e.SolutionPhoto))
                    : null,
                Estado = TranslateStatus(e.ItemStatus!)
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
            if (dtEquipos.Columns["Solución"] != null)
            {
                var col = (DataGridViewImageColumn)dtEquipos.Columns["Solución"];
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                col.HeaderText = "Solución";
                col.Width = 60;
            }
            if (dtEquipos.Columns["Estado"] != null)
            {
                dtEquipos.Columns["Estado"].HeaderText = "Estado";
            }
        }

        private static string TranslateStatus(string status)
        {
            return status switch
            {
                "Pending" => "Pendiente",
                "InProgress" => "En Proceso",
                "Completed" => "Completado",
                _ => status
            };
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dtEquipos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dtEquipos.CurrentRow.Index;
            if (rowIndex < 0 || rowIndex >= items.Count)
            {
                MessageBox.Show("Ítem no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var equipo = items[rowIndex];
            equipoEditandoIndex = rowIndex;

            cmbModels.SelectedValue = equipo.ModelId;
            txtQuantity.Text = equipo.Quantity.ToString();
            txtDevSpec.Text = equipo.DeviceSpecs;
            cmbItemStatus.SelectedValue = equipo.ItemStatusId;

            if (!string.IsNullOrEmpty(equipo.IntakePhoto))
            {
                string basePath = ConfigurationManager.AppSettings["imagesPath"]!;
                string intakePath = Path.Combine(basePath, equipo.IntakePhoto);
                pbImage.Image = File.Exists(intakePath) ? Image.FromFile(intakePath) : null;
            }
            else
            {
                pbImage.Image = null;
            }

            btnUpdate.Visible = false;
            btnUpdateConfirm.Visible = true;
            btnUpdateCancel.Visible = true;
        }

        private async void BtnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (equipoEditandoIndex == null || equipoEditandoIndex < 0 || equipoEditandoIndex >= items.Count)
            {
                MessageBox.Show("No hay equipo seleccionado para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? statusId = (int?)cmbItemStatus.SelectedValue;
            var equipo = items[(int)equipoEditandoIndex];
            equipo.OrderId = _orderId;

            if (cmbModels.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtDevSpec.Text) ||
                cmbItemStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un modelo, ingresar cantidad, especificaciones y estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            equipo.ModelId = (int)cmbModels.SelectedValue!;
            equipo.Quantity = cantidad;
            equipo.DeviceSpecs = txtDevSpec.Text.Trim();
            equipo.ItemStatusId = statusId;
            equipo.ItemStatus = estadosItem.FirstOrDefault(x => x.Id == equipo.ItemStatusId)?.Name;

            if (statusId != 3 && statusId != 4)
            {
                if (pbImage.Image != null && !string.IsNullOrEmpty(selectedImagePath))
                {
                    MessageBox.Show("No puedes modificar la imagen en este estado.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (pbImage.Image != null && !string.IsNullOrEmpty(selectedImagePath))
                {
                    var result = MessageBox.Show(
                        "¿Desea actualizar la imagen de solución para este equipo?",
                        "Confirmar actualización de imagen",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string basePath = ConfigurationManager.AppSettings["imagesPath"]!;
                        if (!Directory.Exists(basePath))
                            Directory.CreateDirectory(basePath);

                        string ext = Path.GetExtension(selectedImagePath).ToLower();
                        string fileName = $"{DateTime.Now:yyyyMMdd}-{equipo.OrderId}-{equipo.DetailId}-solution{ext}";
                        string destPath = Path.Combine(basePath, fileName);

                        File.Copy(selectedImagePath, destPath, true);
                        equipo.SolutionPhoto = destPath;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            var orderController = new OrderController();
            var response = await orderController.UpdateDeviceDetailAsync(equipo);

            if (response.StatusCode == 204)
            {
                RefreshDevicesGrid();
                ClearEditFields();
                MessageBox.Show("Equipo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar la orden: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateCancel_Click(object sender, EventArgs e)
        {
            ClearEditFields();
        }

        private void ClearEditFields()
        {
            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            cmbItemStatus.SelectedIndex = -1;
            btnUpdate.Visible = true;
            pbImage.Image = null;
            selectedImagePath = null;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
            equipoEditandoIndex = null;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
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

        private void PbImage_DragEnter(object sender, DragEventArgs e)
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

        private void PbImage_DragDrop(object sender, DragEventArgs e)
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
            string ext = System.IO.Path.GetExtension(file).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Ingrese un comentario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var commentController = new CommentController();
            var commentDto = new OrderCommentsDto
            {
                OrderId = _orderId,
                Comments =
                [
                    new CommentDetailDto
                    {
                        UserId = _userData.UserId,
                        UserName = _userData.Name,
                        Comment = txtComment.Text,
                        CreatedAt = DateTime.Now
                    }
                ]
            };

            var response = await commentController.AddCommentAsync(commentDto);

            if (response.StatusCode == 201)
            {
                LoadOrderDetail();
                txtComment.Text = string.Empty;
                MessageBox.Show("Comentario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar el comentario: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnFinalice_Click(object sender, EventArgs e)
        {
            var orderController = new OrderController();
            var mailController = new MailController();

            var response = await orderController.GetOrderDetailByIdAsync(_orderId);
            if (response.StatusCode != 200)
            {
                MessageBox.Show("No se pudo obtener la orden para finalizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var detalle = JsonConvert.DeserializeObject<OrderFullDetailDto>(response.Message);
            if (detalle == null)
            {
                MessageBox.Show("No se pudo deserializar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orderDto = new OrderDto
            {
                OrderId = detalle.OrderId,
                Description = detalle.Description,
                ScheduledFor = detalle.ScheduledFor,
                OrderStatusId = (int)cmbStateOrder.SelectedValue!,
                Customer = detalle.Customer,
                Devices = items,
                TechnicianId = _userData.UserId
            };

            var updateResponse = await orderController.UpdateOrderAsync(orderDto);

            if (updateResponse.StatusCode == 200)
            {
                if ((int)cmbStateOrder.SelectedValue == 3)
                {
                    try
                    {
                        orderDto.LastComment = detalle.Comments
                            .OrderByDescending(x => x.CommentId)
                            .FirstOrDefault();

                        var sendResult = await mailController.SendOrderCompletionMailAsync(orderDto);

                        if (sendResult.StatusCode != 200)
                        {
                            MessageBox.Show("La orden se finalizó, pero no se pudo enviar el correo: " + sendResult.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Orden finalizada y correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La orden se finalizó, pero no se pudo enviar el correo: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Orden actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Error al finalizar la orden: " + updateResponse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmTechnicianOrders frmTech)
                {
                    frmTech.LoadOrdersAsync();
                    break;
                }
            }

        }
    }
}
