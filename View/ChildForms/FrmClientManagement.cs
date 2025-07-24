using Adarec_ui.Controller;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmClientManagement : MaterialForm
    {
        private readonly CustomerController _customerController = new();
        private List<CustomerDto> clientesOriginal = [];
        private bool cancelValidation = false;

        public FrmClientManagement()
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

        private async void FrmClientManagement_Load(object sender, EventArgs e)
        {
            await LoadClientsAsync();
            await LoadIdTypesAsync();
        }

        private async Task LoadClientsAsync()
        {
            CleanData();
            var response = await _customerController.GetAllCustomers();
            if (response.StatusCode == 200)
            {
                clientesOriginal = JsonConvert.DeserializeObject<List<CustomerDto>>(response.Message) ?? new List<CustomerDto>();
                dataGridView1.DataSource = clientesOriginal;

                if (dataGridView1.Columns["IdentificationTypeId"] != null)
                    dataGridView1.Columns["IdentificationTypeId"].Visible = false;
                if (dataGridView1.Columns["CustomerId"] != null)
                    dataGridView1.Columns["CustomerId"].HeaderText = "ID";
                if (dataGridView1.Columns["Name"] != null)
                    dataGridView1.Columns["Name"].HeaderText = "Nombre";
                if (dataGridView1.Columns["IdentificationNumber"] != null)
                    dataGridView1.Columns["IdentificationNumber"].HeaderText = "Identificación";
                if (dataGridView1.Columns["Email"] != null)
                    dataGridView1.Columns["Email"].HeaderText = "Correo";
                if (dataGridView1.Columns["Phone"] != null)
                    dataGridView1.Columns["Phone"].HeaderText = "Teléfono";
                if (dataGridView1.Columns["Address"] != null)
                    dataGridView1.Columns["Address"].HeaderText = "Dirección";
            }
            else
            {
                MessageBox.Show($"No se pudieron cargar los clientes.\n {response.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = null;
            }
        }

        private async Task LoadIdTypesAsync()
        {
            var response = await _customerController.GetIdentificationTypes();
            if (response.StatusCode == 200)
            {
                var tipos = JsonConvert.DeserializeObject<List<RolDto>>(response.Message);
                cmbIdentificationType.DataSource = tipos;
                cmbIdentificationType.ValueMember = "Id";
                cmbIdentificationType.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los tipos de identificación.\n" + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbIdentificationType.DataSource = null;
            }
        }

        private void TxtClient_TextChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtIdentificationClient.Text, @"[^\d]", "");

            if (txtIdentificationClient.Text != texto)
                txtIdentificationClient.Text = texto;

            txtIdentificationClient.SelectionStart = txtIdentificationClient.Text.Length;
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

        private void TxtNameClient_TextChanged(object sender, EventArgs e)
        {
            SanitizeField(txtNameClient);
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            SanitizeField(txtAddress);
        }

        private void SanitizeField(MaterialTextBox txt)
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
            if (cmbIdentificationType.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el tipo de identificación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIdentificationType.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNameClient.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificationClient.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^09\d{8}$"))
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos y empezar con 09.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            int tipoId = Convert.ToInt32(cmbIdentificationType.SelectedValue);
            string identificacion = txtIdentificationClient.Text.Trim();

            if (tipoId == 1 && identificacion.Length != 13)
            {
                MessageBox.Show("El RUC debe tener 13 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificationClient.Focus();
                return;
            }
            if (tipoId == 2 && identificacion.Length != 10)
            {
                MessageBox.Show("La cédula debe tener 10 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificationClient.Focus();
                return;
            }

            var nuevoCliente = new CustomerDto
            {
                Name = txtNameClient.Text.Trim(),
                IdentificationNumber = identificacion,
                IdentificationTypeId = tipoId,
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            var response = await _customerController.AddCustomer(nuevoCliente);
            if (response.StatusCode == 201)
            {
                MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadClientsAsync();
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
                MessageBox.Show("Seleccione un cliente para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;

            btnUpdateConfirm.Visible = true;
            btnUpdateCancel.Visible = true;

            var cliente = dataGridView1.CurrentRow.DataBoundItem as CustomerDto;
            if (cliente != null)
            {
                txtNameClient.Text = cliente.Name;
                txtIdentificationClient.Text = cliente.IdentificationNumber;
                cmbIdentificationType.SelectedValue = cliente.IdentificationTypeId;
                txtEmail.Text = cliente.Email;
                txtPhone.Text = cliente.Phone;
                txtAddress.Text = cliente.Address;
            }
        }

        private async void BtnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (cmbIdentificationType.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el tipo de identificación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIdentificationType.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNameClient.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificationClient.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^09\d{8}$"))
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos y empezar con 09.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            int tipoId = Convert.ToInt32(cmbIdentificationType.SelectedValue);
            string identificacion = txtIdentificationClient.Text.Trim();

            if (tipoId == 1 && identificacion.Length != 13)
            {
                MessageBox.Show("El RUC debe tener 13 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificationClient.Focus();
                return;
            }
            if (tipoId == 2 && identificacion.Length != 10)
            {
                MessageBox.Show("La cédula debe tener 10 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificationClient.Focus();
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Correo electrónico no válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado ningún cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustomerDto? cliente = dataGridView1.CurrentRow.DataBoundItem as CustomerDto;
            if (cliente == null)
            {
                MessageBox.Show("Error al obtener el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cliente.Name = txtNameClient.Text.Trim();
            cliente.IdentificationNumber = identificacion;
            cliente.IdentificationTypeId = tipoId;
            cliente.Email = txtEmail.Text.Trim();
            cliente.Phone = txtPhone.Text.Trim();
            cliente.Address = txtAddress.Text.Trim();

            var response = await _customerController.UpdateCustomer(cliente);
            if (response.StatusCode == 200)
            {
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadClientsAsync();
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateCancel_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        private void CleanData(){
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateCancel.Visible = false;

            txtNameClient.Text = "";
            txtIdentificationClient.Text = "";
            cmbIdentificationType.SelectedIndex = -1;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cliente = dataGridView1.CurrentRow.DataBoundItem as CustomerDto;
            if (cliente == null)
            {
                MessageBox.Show("Error al obtener el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar el cliente '{cliente.Name}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            var response = await _customerController.DeleteCustomer(cliente.CustomerId);
            if (response.StatusCode == 204)
            {
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadClientsAsync();
            }
            else
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            string texto = Regex.Replace(txtPhone.Text, @"[^\d]", "");

            if (txtPhone.Text != texto)
                txtPhone.Text = texto;

            txtPhone.SelectionStart = txtPhone.Text.Length;
        }

        private void FilterClients()
        {
            string filtro = txtFiltrer.Text.Trim().ToLower();

            IEnumerable<CustomerDto> filtrados = clientesOriginal;

            if (!string.IsNullOrEmpty(filtro))
            {
                if (rbIdentification.Checked)
                {
                    filtrados = clientesOriginal.Where(c => c.IdentificationNumber != null && c.IdentificationNumber.ToLower().Contains(filtro));
                }
                else if (rbNameClient.Checked)
                {
                    filtrados = clientesOriginal.Where(c => c.Name != null && c.Name.ToLower().Contains(filtro));
                }
            }

            dataGridView1.DataSource = filtrados.ToList();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterClients();
        }

        private void RbIdentificacion_CheckedChanged(object sender, EventArgs e)
        {
            FilterClients();
        }

        private void RbNombre_CheckedChanged(object sender, EventArgs e)
        {
            FilterClients();
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
