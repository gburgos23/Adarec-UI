namespace Adarec_ui.View.ChildForms
{
    partial class FrmClientManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            txtNameClient = new MaterialSkin.Controls.MaterialTextBox();
            txtIdentificationClient = new MaterialSkin.Controls.MaterialTextBox();
            cmbIdentificationType = new MaterialSkin.Controls.MaterialComboBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdateConfirm = new MaterialSkin.Controls.MaterialButton();
            btnUpdateCancel = new MaterialSkin.Controls.MaterialButton();
            rbIdentification = new MaterialSkin.Controls.MaterialRadioButton();
            rbNameClient = new MaterialSkin.Controls.MaterialRadioButton();
            txtFiltrer = new MaterialSkin.Controls.MaterialTextBox();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(377, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(822, 435);
            dataGridView1.TabIndex = 0;
            // 
            // txtNameClient
            // 
            txtNameClient.AnimateReadOnly = false;
            txtNameClient.BorderStyle = BorderStyle.None;
            txtNameClient.Depth = 0;
            txtNameClient.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNameClient.Hint = "Nombre";
            txtNameClient.LeadingIcon = null;
            txtNameClient.Location = new Point(21, 102);
            txtNameClient.MaxLength = 250;
            txtNameClient.MouseState = MaterialSkin.MouseState.OUT;
            txtNameClient.Multiline = false;
            txtNameClient.Name = "txtNameClient";
            txtNameClient.Size = new Size(322, 50);
            txtNameClient.TabIndex = 0;
            txtNameClient.Text = "";
            txtNameClient.TrailingIcon = null;
            txtNameClient.TextChanged += TxtNameClient_TextChanged;
            // 
            // txtIdentificationClient
            // 
            txtIdentificationClient.AnimateReadOnly = false;
            txtIdentificationClient.BorderStyle = BorderStyle.None;
            txtIdentificationClient.Depth = 0;
            txtIdentificationClient.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdentificationClient.Hint = "Número de Identificación";
            txtIdentificationClient.LeadingIcon = null;
            txtIdentificationClient.Location = new Point(21, 234);
            txtIdentificationClient.MaxLength = 13;
            txtIdentificationClient.MouseState = MaterialSkin.MouseState.OUT;
            txtIdentificationClient.Multiline = false;
            txtIdentificationClient.Name = "txtIdentificationClient";
            txtIdentificationClient.Size = new Size(322, 50);
            txtIdentificationClient.TabIndex = 2;
            txtIdentificationClient.Text = "";
            txtIdentificationClient.TrailingIcon = null;
            txtIdentificationClient.TextChanged += TxtClient_TextChanged;
            // 
            // cmbIdentificationType
            // 
            cmbIdentificationType.AutoResize = false;
            cmbIdentificationType.BackColor = Color.FromArgb(255, 255, 255);
            cmbIdentificationType.Depth = 0;
            cmbIdentificationType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbIdentificationType.DropDownHeight = 174;
            cmbIdentificationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdentificationType.DropDownWidth = 121;
            cmbIdentificationType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbIdentificationType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbIdentificationType.FormattingEnabled = true;
            cmbIdentificationType.Hint = "Tipo de Identificación";
            cmbIdentificationType.IntegralHeight = false;
            cmbIdentificationType.ItemHeight = 43;
            cmbIdentificationType.Location = new Point(21, 169);
            cmbIdentificationType.MaxDropDownItems = 4;
            cmbIdentificationType.MouseState = MaterialSkin.MouseState.OUT;
            cmbIdentificationType.Name = "cmbIdentificationType";
            cmbIdentificationType.Size = new Size(322, 49);
            cmbIdentificationType.StartIndex = 0;
            cmbIdentificationType.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Correo";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(21, 305);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 50);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            txtEmail.KeyDown += TxtEmail_KeyDown;
            txtEmail.Leave += TxtEmail_Leave;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.Hint = "Dirección";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(21, 371);
            txtAddress.MaxLength = 150;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(322, 50);
            txtAddress.TabIndex = 4;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(21, 523);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(67, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Crear";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(114, 523);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(237, 523);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(88, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnUpdateConfirm
            // 
            btnUpdateConfirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateConfirm.Depth = 0;
            btnUpdateConfirm.HighEmphasis = true;
            btnUpdateConfirm.Icon = null;
            btnUpdateConfirm.Location = new Point(68, 523);
            btnUpdateConfirm.Margin = new Padding(4, 6, 4, 6);
            btnUpdateConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateConfirm.Name = "btnUpdateConfirm";
            btnUpdateConfirm.NoAccentTextColor = Color.Empty;
            btnUpdateConfirm.Size = new Size(88, 36);
            btnUpdateConfirm.TabIndex = 12;
            btnUpdateConfirm.Text = "Guardar";
            btnUpdateConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateConfirm.UseAccentColor = false;
            btnUpdateConfirm.UseVisualStyleBackColor = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateConfirm.Click += BtnUpdateConfirm_Click;
            // 
            // btnUpdateCancel
            // 
            btnUpdateCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateCancel.Depth = 0;
            btnUpdateCancel.HighEmphasis = true;
            btnUpdateCancel.Icon = null;
            btnUpdateCancel.Location = new Point(183, 523);
            btnUpdateCancel.Margin = new Padding(4, 6, 4, 6);
            btnUpdateCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateCancel.Name = "btnUpdateCancel";
            btnUpdateCancel.NoAccentTextColor = Color.Empty;
            btnUpdateCancel.Size = new Size(96, 36);
            btnUpdateCancel.TabIndex = 13;
            btnUpdateCancel.Text = "Cancelar";
            btnUpdateCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateCancel.UseAccentColor = false;
            btnUpdateCancel.UseVisualStyleBackColor = true;
            btnUpdateCancel.Visible = false;
            btnUpdateCancel.Click += BtnUpdateCancel_Click;
            // 
            // rbIdentification
            // 
            rbIdentification.AutoSize = true;
            rbIdentification.Depth = 0;
            rbIdentification.Location = new Point(604, 93);
            rbIdentification.Margin = new Padding(0);
            rbIdentification.MouseLocation = new Point(-1, -1);
            rbIdentification.MouseState = MaterialSkin.MouseState.HOVER;
            rbIdentification.Name = "rbIdentification";
            rbIdentification.Ripple = true;
            rbIdentification.Size = new Size(131, 37);
            rbIdentification.TabIndex = 9;
            rbIdentification.TabStop = true;
            rbIdentification.Text = "Identificacion";
            rbIdentification.UseVisualStyleBackColor = true;
            rbIdentification.CheckedChanged += RbIdentificacion_CheckedChanged;
            // 
            // rbNameClient
            // 
            rbNameClient.AutoSize = true;
            rbNameClient.Depth = 0;
            rbNameClient.Location = new Point(761, 93);
            rbNameClient.Margin = new Padding(0);
            rbNameClient.MouseLocation = new Point(-1, -1);
            rbNameClient.MouseState = MaterialSkin.MouseState.HOVER;
            rbNameClient.Name = "rbNameClient";
            rbNameClient.Ripple = true;
            rbNameClient.Size = new Size(91, 37);
            rbNameClient.TabIndex = 10;
            rbNameClient.TabStop = true;
            rbNameClient.Text = "Nombre";
            rbNameClient.UseVisualStyleBackColor = true;
            rbNameClient.CheckedChanged += RbNombre_CheckedChanged;
            // 
            // txtFiltrer
            // 
            txtFiltrer.AnimateReadOnly = false;
            txtFiltrer.BorderStyle = BorderStyle.None;
            txtFiltrer.Depth = 0;
            txtFiltrer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFiltrer.Hint = "Valor a filtrar";
            txtFiltrer.LeadingIcon = null;
            txtFiltrer.Location = new Point(906, 80);
            txtFiltrer.MaxLength = 50;
            txtFiltrer.MouseState = MaterialSkin.MouseState.OUT;
            txtFiltrer.Multiline = false;
            txtFiltrer.Name = "txtFiltrer";
            txtFiltrer.Size = new Size(293, 50);
            txtFiltrer.TabIndex = 11;
            txtFiltrer.Text = "";
            txtFiltrer.TrailingIcon = null;
            txtFiltrer.TextChanged += TxtFilter_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.Hint = "Teléfono";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(21, 436);
            txtPhone.MaxLength = 10;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(322, 50);
            txtPhone.TabIndex = 5;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            // 
            // FrmClientManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 596);
            Controls.Add(txtPhone);
            Controls.Add(txtFiltrer);
            Controls.Add(rbNameClient);
            Controls.Add(rbIdentification);
            Controls.Add(btnUpdateCancel);
            Controls.Add(btnUpdateConfirm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(cmbIdentificationType);
            Controls.Add(txtIdentificationClient);
            Controls.Add(txtNameClient);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "FrmClientManagement";
            Sizable = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mantenimiento Clientes";
            Load += FrmClientManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox txtNameClient;
        private MaterialSkin.Controls.MaterialTextBox txtIdentificationClient;
        private MaterialSkin.Controls.MaterialComboBox cmbIdentificationType;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton btnUpdateConfirm;
        private MaterialSkin.Controls.MaterialButton btnUpdateCancel;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialRadioButton rbIdentification;
        private MaterialSkin.Controls.MaterialRadioButton rbNameClient;
        private MaterialSkin.Controls.MaterialTextBox txtFiltrer;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
    }
}