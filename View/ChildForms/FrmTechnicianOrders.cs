using Adarec_ui.Controller;
using Adarec_ui.Model;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Data;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmTechnicianOrders : MaterialForm
    {
        private readonly UserDto _userData;
        private readonly int _selectedRoleId;
        private List<OrderGridDto> ordenesOriginal = [];
        private List<RolDto> status = [];

        public FrmTechnicianOrders(UserDto userDto, int selectedRoleId)
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

            dtData.BackgroundColor = ColorTranslator.FromHtml("#E0F2F1");
            dtData.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B2DFDB");
            dtData.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dtData.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#004D40");
            dtData.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#80CBC4");
            dtData.DefaultCellStyle.SelectionForeColor = Color.Black;
            dtData.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            dtData.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#26A69A");
            dtData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);

            dtData.GridColor = ColorTranslator.FromHtml("#B2DFDB");
            dtData.BorderStyle = BorderStyle.None;
            dtData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtData.EnableHeadersVisualStyles = false;

            _selectedRoleId = selectedRoleId;
            _userData = userDto;

            LoadOrdersAsync(); 
        }

        public async void LoadOrdersAsync()
        {
            LoadStatesAsync();
            var orderController = new OrderController();
            ApiResponseDto response;
            if (_selectedRoleId == (int)Roles.technician)
            {
                response = await orderController.GetPendingOrdersByTechnicianAsync(_userData.UserId!.Value);
            }
            else
            {
                response = await orderController.GetAllOrdersAsync();
            }

            if (response.StatusCode == 200)
            {
                var pendientesPorTecnico = JsonConvert.DeserializeObject<List<TechnicianPendingOrdersDto>>(response.Message) ?? [];
                ordenesOriginal = [];

                foreach (var tecnico in pendientesPorTecnico)
                {
                    foreach (var orden in tecnico.PendingOrders ?? [])
                    {
                        ordenesOriginal.Add(new OrderGridDto
                        {
                            IdOrden = orden.OrderId,
                            Descripcion = orden.Description ?? string.Empty,
                            FechaProgramada = orden.ScheduledFor?.ToString("yyyy/MM/dd")!,
                            Estado = orden.Status.ToString() ?? string.Empty,
                            EstadoDescripcion = orden.StatusDescription ?? string.Empty,
                            Cliente = tecnico.Customer?.Name ?? orden.CustomerName ?? string.Empty,
                            CedulaCliente = tecnico.Customer?.IdentificationNumber ?? string.Empty,
                            Tecnico = tecnico.TechnicianId.ToString() ?? string.Empty,
                            TecnicoNombre = tecnico.TechnicianName ?? string.Empty,
                        });
                    }
                }

                dtData.DataSource = ordenesOriginal;

                if (dtData.Columns["IdOrden"] != null)
                    dtData.Columns["IdOrden"].HeaderText = "ID Orden";
                if (dtData.Columns["Descripcion"] != null)
                    dtData.Columns["Descripcion"].HeaderText = "Descripción";
                if (dtData.Columns["FechaProgramada"] != null)
                    dtData.Columns["FechaProgramada"].HeaderText = "Fecha Programada";
                if (dtData.Columns["Estado"] != null)
                    dtData.Columns["Estado"].Visible = false;
                if (dtData.Columns["EstadoDescripcion"] != null)
                    dtData.Columns["EstadoDescripcion"].HeaderText = "Estado";
                if (dtData.Columns["Cliente"] != null)
                    dtData.Columns["Cliente"].HeaderText = "Cliente";
                if (dtData.Columns["CedulaCliente"] != null)
                    dtData.Columns["CedulaCliente"].HeaderText = "Cédula Cliente";
                if (dtData.Columns["Tecnico"] != null)
                    dtData.Columns["Tecnico"].Visible = false;
                if (dtData.Columns["TecnicoNombre"] != null)
                    dtData.Columns["TecnicoNombre"].HeaderText = "Técnico";
            }
            else
            {
                MessageBox.Show("No se pudieron cargar las órdenes.\n" + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtData.DataSource = null;
            }
            cmbState.SelectedIndex = -1;
            rbIdentification.Checked =false;
            rbNameClient.Checked = false;
            txtFiltrer.Clear();
        }

        private async void LoadStatesAsync()
        {
            var orderController = new OrderController();
            var response = await orderController.GetAllOrderStatusesAsync();
            if (response.StatusCode == 200)
            {
                status = JsonConvert.DeserializeObject<List<RolDto>>(response.Message) ?? [];
                cmbState.DataSource = status;
                cmbState.DisplayMember = "Name";
                cmbState.ValueMember = "Id";
                cmbState.SelectedIndex = -1;
            }
            else
            {
                cmbState.DataSource = null;
            }
        }

        private void FilterOrders(object sender, EventArgs e)
        {
            IEnumerable<OrderGridDto> filtradas = ordenesOriginal;

            if (cmbState.SelectedIndex != -1 && cmbState.SelectedValue is int estadoId)
                filtradas = filtradas.Where(o => int.TryParse(o.Estado, out var id) && id == estadoId);

            string filtro = txtFiltrer.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filtro))
            {
                if (rbIdentification.Checked)
                    filtradas = filtradas.Where(o => o.CedulaCliente != null && o.CedulaCliente.ToLower().Contains(filtro));
                else if (rbNameClient.Checked)
                    filtradas = filtradas.Where(o => o.Cliente != null && o.Cliente.ToLower().Contains(filtro));
            }

            dtData.DataSource = filtradas.ToList();
            dtData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void BtnDetailOrder_Click(object sender, EventArgs e)
        {
            if (dtData.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una orden para ver el detalle.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderGridDto? order = dtData.CurrentRow.DataBoundItem as OrderGridDto;
            if (order == null || order.IdOrden == null)
            {
                MessageBox.Show("No se pudo obtener el ID de la orden seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tab = this.Parent as TabPage;
            if (tab == null)
            {
                MessageBox.Show("No se pudo determinar la pestaña actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frmDetalle = new FrmOrderDetail(_userData, _selectedRoleId, order.IdOrden.Value, status)
            {
                TopLevel = false,
            };
            tab.Controls.Add(frmDetalle);
            frmDetalle.BringToFront();
            frmDetalle.Show();
        }

        private void BtnReloadOrders_Click(object sender, EventArgs e)
        {
            LoadOrdersAsync();
        }
    }
}
