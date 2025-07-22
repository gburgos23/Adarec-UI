using Adarec_ui.Controller;
using Adarec_ui.Model.DTOs;
using Adarec_ui.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmOrderDetail : MaterialForm
    {
        private readonly UserDto _userData;
        private readonly int _selectedRoleId;
        private readonly int _orderId;
        private List<RolDto> _status = [];
        private List<DeviceDetailDto> items = [];
        private List<DeviceModelDto> modelos = [];
        private List<RolDto> estadosItem = [];
        private int? equipoEditandoIndex = null;

        public FrmOrderDetail(UserDto userDto, int selectedRoleId, int orderId, List<RolDto> status)
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

            _selectedRoleId = selectedRoleId;
            _userData = userDto;
            _orderId = orderId;
            _status = status;

            dtEquipos.BackgroundColor = Color.FromArgb(55, 71, 79);
            dtEquipos.DefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dtEquipos.DefaultCellStyle.ForeColor = Color.White;
            dtEquipos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dtEquipos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;

            dataGridView1.BackgroundColor = Color.FromArgb(55, 71, 79);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;

            txtOrderId.Text = _orderId.ToString();

            ConfigurarControlesPorRol();
            PrecargarCombosAsync();
            CargarDetalleOrden();
        }

        private void ConfigurarControlesPorRol()
        {
            bool esTecnico = _selectedRoleId == (int)Roles.technician;

            txtComment.Enabled = esTecnico;
            txtOrderId.Enabled = esTecnico;
            txtDevSpec.Enabled = esTecnico;
            txtQuantity.Enabled = esTecnico;
            cmbStateOrder.Enabled = esTecnico;
            cmbModels.Enabled = esTecnico;
            cmbItemStatus.Enabled = esTecnico;
            btnAdd.Enabled = esTecnico;
            btnUpdateCancel.Enabled = esTecnico;
            btnUpdateConfirm.Enabled = esTecnico;
            btnUpdate.Enabled = esTecnico;
            btnFinalice.Enabled = esTecnico;

            btnUpdate.Visible = esTecnico;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
        }

        private async void PrecargarCombosAsync()
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

        private void PrecargarEstados(int estadoSeleccionado)
        {
            cmbStateOrder.DataSource = _status;
            cmbStateOrder.DisplayMember = "Name";
            cmbStateOrder.ValueMember = "Id";
            cmbStateOrder.SelectedValue = estadoSeleccionado;
        }

        private async void CargarDetalleOrden()
        {
            var orderController = new OrderController();
            var response = await orderController.GetOrderDetailByIdAsync(_orderId);
            if (response.StatusCode == 200)
            {
                var detalle = JsonConvert.DeserializeObject<OrderFullDetailDto>(response.Message);
                if (detalle != null)
                {
                    PrecargarEstados(detalle.Status);
                    CargarComentarios(detalle.Comments);
                    items = detalle.Devices ?? [];
                    ActualizarGridEquipos();
                }
            }
            else
            {
                MessageBox.Show("No se pudo cargar el detalle de la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComentarios(List<CommentDetailDto> comentarios)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns.Add("Comentario", "Comentario");
            dataGridView1.Columns.Add("Autor", "Autor");

            foreach (var comentario in comentarios)
            {
                dataGridView1.Rows.Add(
                    comentario.CreatedAt.ToString("dd/MM/yyyy"),
                    comentario.Comment,
                    comentario.UserName
                );
            }
        }

        private void ActualizarGridEquipos()
        {
            var data = items.Select(e => new
            {
                Modelo = modelos.FirstOrDefault(m => m.ModelId == e.ModelId)?.Description ?? "Desconocido",
                Cantidad = e.Quantity,
                Especificaciones = e.DeviceSpecs,
                Imagen = !string.IsNullOrEmpty(e.IntakePhoto)
                    ? ConvertirBase64AImagen(e.IntakePhoto)
                    : null,
                Solución = !string.IsNullOrEmpty(e.SolutionPhoto)
                    ? ConvertirBase64AImagen(e.SolutionPhoto)
                    : null,
                Estado = TraducirEstado(e.ItemStatus!)
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

        private static Image? ConvertirBase64AImagen(string base64)
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

        private static string TraducirEstado(string estado)
        {
            return estado switch
            {
                "Pending" => "Pendiente",
                "InProgress" => "En Proceso",
                "Completed" => "Completado",
                _ => estado
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
                try
                {
                    byte[] bytes = Convert.FromBase64String(equipo.IntakePhoto);
                    using var ms = new MemoryStream(bytes);
                    pbImage.Image = Image.FromStream(ms);
                }
                catch (FormatException)
                {
                    MessageBox.Show("La imagen proporcionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbImage.Image = null;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("La imagen no se pudo cargar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbImage.Image = null;
                }
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

            int? statusId = (int?)cmbItemStatus.SelectedValue;
            if (statusId != 3 && statusId != 4)
            {
                MessageBox.Show("Solo puede actualizar si el estado es 'Reparado' o 'No Reparado'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var equipo = items[(int)equipoEditandoIndex];
            equipo.ModelId = (int)cmbModels.SelectedValue!;
            equipo.Quantity = cantidad;
            equipo.DeviceSpecs = txtDevSpec.Text.Trim();
            equipo.ItemStatusId = statusId;
            equipo.ItemStatus = estadosItem.FirstOrDefault(x => x.Id == equipo.ItemStatusId)?.Name;

            string? solutionPhoto = null;
            if (pbImage.Image != null)
            {
                using var ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                solutionPhoto = Convert.ToBase64String(ms.ToArray());
            }
            equipo.SolutionPhoto = solutionPhoto;

            var orderController = new OrderController();
            var response = await orderController.UpdateDeviceDetailAsync(equipo);

            if (response.StatusCode == 200)
            {
                ActualizarGridEquipos();
                LimpiarCamposEdicion();
                MessageBox.Show("Equipo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar la orden: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateCancel_Click(object sender, EventArgs e)
        {
            LimpiarCamposEdicion();
        }

        private void LimpiarCamposEdicion()
        {
            cmbModels.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            txtDevSpec.Text = string.Empty;
            cmbItemStatus.SelectedIndex = -1;
            btnUpdate.Visible = true;
            pbImage.Image = null;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;
            equipoEditandoIndex = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                CargarDetalleOrden();
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
                OrderStatusId = (int)cmbStateOrder.SelectedValue,
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
                        string asunto = "Su orden ha sido completada";
                        string cuerpo = $"Estimado/a {detalle.Customer.Name},<br>Su orden #{detalle.OrderId} ha sido completada.<br>Adjuntamos imágenes de la solución.<br>Gracias por confiar en nosotros.";
                        EnviarCorreoOrdenCompletada(detalle.Customer.Email, asunto, cuerpo, items);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La orden se finalizó, pero no se pudo enviar el correo: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show("Orden finalizada y actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al finalizar la orden: " + updateResponse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarCorreoOrdenCompletada(string destinatario, string asunto, string cuerpo, List<DeviceDetailDto> equipos)
        {
            var smtpHost = System.Configuration.ConfigurationManager.AppSettings["smtpHost"];
            var smtpPort = int.Parse(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
            var smtpUser = System.Configuration.ConfigurationManager.AppSettings["smtpUser"];
            var smtpPass = System.Configuration.ConfigurationManager.AppSettings["smtpPass"];
            var smtpFrom = System.Configuration.ConfigurationManager.AppSettings["smtpFrom"];

            using var mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(smtpFrom!);
            mail.To.Add(destinatario);
            mail.Subject = asunto;
            mail.Body = cuerpo;
            mail.IsBodyHtml = true;

            int i = 1;
            foreach (var equipo in equipos)
            {
                if (!string.IsNullOrEmpty(equipo.SolutionPhoto))
                {
                    byte[] bytes = Convert.FromBase64String(equipo.SolutionPhoto);
                    using var ms = new MemoryStream(bytes);
                    var img = Image.FromStream(ms);
                    var tempPath = Path.GetTempFileName();
                    img.Save(tempPath, img.RawFormat);
                    mail.Attachments.Add(new System.Net.Mail.Attachment(tempPath)
                    {
                        Name = $"Solucion_{i}.jpg"
                    });
                    i++;
                }
            }

            using var smtp = new System.Net.Mail.SmtpClient(smtpHost, smtpPort)
            {
                Credentials = new System.Net.NetworkCredential(smtpUser, smtpPass),
                EnableSsl = true
            };
            smtp.Send(mail);

            // Limpieza de archivos temporales
            foreach (var att in mail.Attachments)
            {
                try { File.Delete(att.Name); } catch { }
            }
        }
    }
}
