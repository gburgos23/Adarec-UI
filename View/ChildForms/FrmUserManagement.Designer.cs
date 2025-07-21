namespace Adarec_ui.View.ChildForms
{
    partial class FrmUserManagement
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnUpdateCancel = new MaterialSkin.Controls.MaterialButton();
            btnUpdateConfirm = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtNameClient = new MaterialSkin.Controls.MaterialTextBox();
            dataGridView1 = new DataGridView();
            cmbIdRol = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(90, 90);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(101, 19);
            materialLabel2.TabIndex = 30;
            materialLabel2.Text = "Datos Usuario";
            // 
            // btnUpdateCancel
            // 
            btnUpdateCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateCancel.Depth = 0;
            btnUpdateCancel.HighEmphasis = true;
            btnUpdateCancel.Icon = null;
            btnUpdateCancel.Location = new Point(189, 478);
            btnUpdateCancel.Margin = new Padding(4, 6, 4, 6);
            btnUpdateCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateCancel.Name = "btnUpdateCancel";
            btnUpdateCancel.NoAccentTextColor = Color.Empty;
            btnUpdateCancel.Size = new Size(96, 36);
            btnUpdateCancel.TabIndex = 29;
            btnUpdateCancel.Text = "Cancelar";
            btnUpdateCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateCancel.UseAccentColor = false;
            btnUpdateCancel.UseVisualStyleBackColor = true;
            btnUpdateCancel.Visible = false;
            // 
            // btnUpdateConfirm
            // 
            btnUpdateConfirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateConfirm.Depth = 0;
            btnUpdateConfirm.HighEmphasis = true;
            btnUpdateConfirm.Icon = null;
            btnUpdateConfirm.Location = new Point(74, 478);
            btnUpdateConfirm.Margin = new Padding(4, 6, 4, 6);
            btnUpdateConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateConfirm.Name = "btnUpdateConfirm";
            btnUpdateConfirm.NoAccentTextColor = Color.Empty;
            btnUpdateConfirm.Size = new Size(88, 36);
            btnUpdateConfirm.TabIndex = 28;
            btnUpdateConfirm.Text = "Guardar";
            btnUpdateConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateConfirm.UseAccentColor = false;
            btnUpdateConfirm.UseVisualStyleBackColor = true;
            btnUpdateConfirm.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(243, 478);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(88, 36);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(120, 478);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(27, 478);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(67, 36);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Crear";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(27, 391);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(258, 50);
            txtPassword.TabIndex = 24;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Correo";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(27, 304);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 50);
            txtEmail.TabIndex = 23;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(644, 90);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(141, 19);
            materialLabel1.TabIndex = 20;
            materialLabel1.Text = "Listado de Usuarios";
            // 
            // txtNameClient
            // 
            txtNameClient.AnimateReadOnly = false;
            txtNameClient.BorderStyle = BorderStyle.None;
            txtNameClient.Depth = 0;
            txtNameClient.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNameClient.Hint = "Nombre";
            txtNameClient.LeadingIcon = null;
            txtNameClient.Location = new Point(27, 134);
            txtNameClient.MaxLength = 50;
            txtNameClient.MouseState = MaterialSkin.MouseState.OUT;
            txtNameClient.Multiline = false;
            txtNameClient.Name = "txtNameClient";
            txtNameClient.Size = new Size(258, 50);
            txtNameClient.TabIndex = 19;
            txtNameClient.Text = "";
            txtNameClient.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(384, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(648, 380);
            dataGridView1.TabIndex = 18;
            // 
            // cmbIdRol
            // 
            cmbIdRol.AutoResize = false;
            cmbIdRol.BackColor = Color.FromArgb(255, 255, 255);
            cmbIdRol.Depth = 0;
            cmbIdRol.DrawMode = DrawMode.OwnerDrawVariable;
            cmbIdRol.DropDownHeight = 174;
            cmbIdRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdRol.DropDownWidth = 121;
            cmbIdRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbIdRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbIdRol.FormattingEnabled = true;
            cmbIdRol.Hint = "Rol";
            cmbIdRol.IntegralHeight = false;
            cmbIdRol.ItemHeight = 43;
            cmbIdRol.Location = new Point(27, 213);
            cmbIdRol.MaxDropDownItems = 4;
            cmbIdRol.MouseState = MaterialSkin.MouseState.OUT;
            cmbIdRol.Name = "cmbIdRol";
            cmbIdRol.Size = new Size(258, 49);
            cmbIdRol.StartIndex = 0;
            cmbIdRol.TabIndex = 22;
            // 
            // FrmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 536);
            Controls.Add(materialLabel2);
            Controls.Add(btnUpdateCancel);
            Controls.Add(btnUpdateConfirm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(cmbIdRol);
            Controls.Add(materialLabel1);
            Controls.Add(txtNameClient);
            Controls.Add(dataGridView1);
            Name = "FrmUserManagement";
            Text = "Mantenimiento Usuarios";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnUpdateCancel;
        private MaterialSkin.Controls.MaterialButton btnUpdateConfirm;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNameClient;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialComboBox cmbIdRol;
    }
}