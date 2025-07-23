using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnUpdateCancel = new MaterialSkin.Controls.MaterialButton();
            btnUpdateConfirm = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            dataGridView1 = new DataGridView();
            chkActivo = new MaterialSkin.Controls.MaterialCheckbox();
            ckAdmin = new MaterialSkin.Controls.MaterialCheckbox();
            ckTech = new MaterialSkin.Controls.MaterialCheckbox();
            ckFront = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCheckedListBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateCancel
            // 
            btnUpdateCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateCancel.Depth = 0;
            btnUpdateCancel.HighEmphasis = true;
            btnUpdateCancel.Icon = null;
            btnUpdateCancel.Location = new Point(176, 429);
            btnUpdateCancel.Margin = new Padding(4, 6, 4, 6);
            btnUpdateCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateCancel.Name = "btnUpdateCancel";
            btnUpdateCancel.NoAccentTextColor = Color.Empty;
            btnUpdateCancel.Size = new Size(96, 36);
            btnUpdateCancel.TabIndex = 8;
            btnUpdateCancel.Text = "Cancelar";
            btnUpdateCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateCancel.UseAccentColor = false;
            btnUpdateCancel.UseVisualStyleBackColor = true;
            btnUpdateCancel.Visible = false;
            btnUpdateCancel.Click += BtnUpdateCancel_Click;
            // 
            // btnUpdateConfirm
            // 
            btnUpdateConfirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateConfirm.Depth = 0;
            btnUpdateConfirm.HighEmphasis = true;
            btnUpdateConfirm.Icon = null;
            btnUpdateConfirm.Location = new Point(71, 429);
            btnUpdateConfirm.Margin = new Padding(4, 6, 4, 6);
            btnUpdateConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateConfirm.Name = "btnUpdateConfirm";
            btnUpdateConfirm.NoAccentTextColor = Color.Empty;
            btnUpdateConfirm.Size = new Size(88, 36);
            btnUpdateConfirm.TabIndex = 7;
            btnUpdateConfirm.Text = "Guardar";
            btnUpdateConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateConfirm.UseAccentColor = false;
            btnUpdateConfirm.UseVisualStyleBackColor = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateConfirm.Click += BtnUpdateConfirm_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(260, 429);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(15, 429);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(67, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Crear";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(15, 299);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(344, 50);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Correo";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(15, 230);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 50);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            txtEmail.KeyDown += TxtEmail_KeyDown;
            txtEmail.Leave += TxtEmail_Leave;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Nombre";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(15, 76);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 50);
            txtName.TabIndex = 0;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(365, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(637, 380);
            dataGridView1.TabIndex = 0;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Depth = 0;
            chkActivo.Location = new Point(15, 372);
            chkActivo.Margin = new Padding(0);
            chkActivo.MouseLocation = new Point(-1, -1);
            chkActivo.MouseState = MaterialSkin.MouseState.HOVER;
            chkActivo.Name = "chkActivo";
            chkActivo.ReadOnly = false;
            chkActivo.Ripple = true;
            chkActivo.Size = new Size(79, 37);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // ckAdmin
            // 
            ckAdmin.AutoSize = true;
            ckAdmin.Depth = 0;
            ckAdmin.Location = new Point(9, 11);
            ckAdmin.Margin = new Padding(0);
            ckAdmin.MouseLocation = new Point(-1, -1);
            ckAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            ckAdmin.Name = "ckAdmin";
            ckAdmin.ReadOnly = false;
            ckAdmin.Ripple = true;
            ckAdmin.Size = new Size(135, 37);
            ckAdmin.TabIndex = 11;
            ckAdmin.Text = "Administrador";
            ckAdmin.UseVisualStyleBackColor = true;
            // 
            // ckTech
            // 
            ckTech.AutoSize = true;
            ckTech.Depth = 0;
            ckTech.Location = new Point(161, 11);
            ckTech.Margin = new Padding(0);
            ckTech.MouseLocation = new Point(-1, -1);
            ckTech.MouseState = MaterialSkin.MouseState.HOVER;
            ckTech.Name = "ckTech";
            ckTech.ReadOnly = false;
            ckTech.Ripple = true;
            ckTech.Size = new Size(91, 37);
            ckTech.TabIndex = 12;
            ckTech.Text = "Técnico";
            ckTech.UseVisualStyleBackColor = true;
            // 
            // ckFront
            // 
            ckFront.AutoSize = true;
            ckFront.Depth = 0;
            ckFront.Location = new Point(263, 11);
            ckFront.Margin = new Padding(0);
            ckFront.MouseLocation = new Point(-1, -1);
            ckFront.MouseState = MaterialSkin.MouseState.HOVER;
            ckFront.Name = "ckFront";
            ckFront.ReadOnly = false;
            ckFront.Ripple = true;
            ckFront.Size = new Size(72, 37);
            ckFront.TabIndex = 13;
            ckFront.Text = "Front";
            ckFront.UseVisualStyleBackColor = true;
            // 
            // materialCheckedListBox1
            // 
            materialCheckedListBox1.AutoScroll = true;
            materialCheckedListBox1.BackColor = SystemColors.Control;
            materialCheckedListBox1.Controls.Add(ckAdmin);
            materialCheckedListBox1.Controls.Add(ckTech);
            materialCheckedListBox1.Controls.Add(ckFront);
            materialCheckedListBox1.Depth = 0;
            materialCheckedListBox1.Location = new Point(15, 147);
            materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckedListBox1.Name = "materialCheckedListBox1";
            materialCheckedListBox1.Size = new Size(344, 58);
            materialCheckedListBox1.Striped = false;
            materialCheckedListBox1.StripeDarkColor = Color.Empty;
            materialCheckedListBox1.TabIndex = 14;
            // 
            // FrmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 483);
            Controls.Add(chkActivo);
            Controls.Add(btnUpdateCancel);
            Controls.Add(btnUpdateConfirm);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Controls.Add(materialCheckedListBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUserManagement";
            Sizable = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mantenimiento Usuarios";
            TopMost = true;
            Load += FrmUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCheckedListBox1.ResumeLayout(false);
            materialCheckedListBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnUpdateCancel;
        private MaterialSkin.Controls.MaterialButton btnUpdateConfirm;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCheckbox chkActivo;
        private MaterialSkin.Controls.MaterialCheckbox ckAdmin;
        private MaterialSkin.Controls.MaterialCheckbox ckTech;
        private MaterialSkin.Controls.MaterialCheckbox ckFront;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
    }
}