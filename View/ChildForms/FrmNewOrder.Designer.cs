namespace Adarec_ui.View.ChildForms
{
    partial class FrmNewOrder
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pbImage = new PictureBox();
            txtClient = new MaterialSkin.Controls.MaterialTextBox2();
            txtQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            txtDevSpec = new MaterialSkin.Controls.MaterialTextBox2();
            txtFailDesc = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            cmbModels = new MaterialSkin.Controls.MaterialComboBox();
            btnFinish = new MaterialSkin.Controls.MaterialButton();
            lbl1 = new MaterialSkin.Controls.MaterialLabel();
            cmbTechnician = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            dtPicker = new DateTimePicker();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            dtEquipos = new DataGridView();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdateConfirm = new MaterialSkin.Controls.MaterialButton();
            btnUpdateCancel = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEquipos).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(50, 110);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(49, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Cliente";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pbImage);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(520, 167);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(1);
            materialCard1.Size = new Size(222, 342);
            materialCard1.TabIndex = 4;
            // 
            // pbImage
            // 
            pbImage.AllowDrop = true;
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(1, 1);
            pbImage.Margin = new Padding(0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(220, 340);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            pbImage.Click += PbImage_Click;
            pbImage.DragDrop += PbImage_DragDrop;
            pbImage.DragEnter += PbImage_DragEnter;
            // 
            // txtClient
            // 
            txtClient.AnimateReadOnly = false;
            txtClient.BackgroundImageLayout = ImageLayout.None;
            txtClient.CharacterCasing = CharacterCasing.Normal;
            txtClient.Depth = 0;
            txtClient.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClient.HideSelection = true;
            txtClient.LeadingIcon = null;
            txtClient.Location = new Point(139, 91);
            txtClient.MaxLength = 13;
            txtClient.MouseState = MaterialSkin.MouseState.OUT;
            txtClient.Name = "txtClient";
            txtClient.PasswordChar = '\0';
            txtClient.PrefixSuffixText = null;
            txtClient.ReadOnly = false;
            txtClient.RightToLeft = RightToLeft.No;
            txtClient.SelectedText = "";
            txtClient.SelectionLength = 0;
            txtClient.SelectionStart = 0;
            txtClient.ShortcutsEnabled = true;
            txtClient.Size = new Size(393, 48);
            txtClient.TabIndex = 6;
            txtClient.TabStop = false;
            txtClient.TextAlign = HorizontalAlignment.Left;
            txtClient.TrailingIcon = null;
            txtClient.UseSystemPasswordChar = false;
            txtClient.KeyPress += TxtClient_KeyPress;
            txtClient.TextChanged += TxtClient_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Ingrese Cantidad";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(306, 167);
            txtQuantity.MaxLength = 3;
            txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.ReadOnly = false;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(197, 48);
            txtQuantity.TabIndex = 8;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            txtQuantity.KeyPress += TxtQuantity_KeyPress;
            txtQuantity.TextChanged += TxtQuantity_TextChanged;
            // 
            // txtDevSpec
            // 
            txtDevSpec.AnimateReadOnly = false;
            txtDevSpec.BackgroundImageLayout = ImageLayout.None;
            txtDevSpec.CharacterCasing = CharacterCasing.Normal;
            txtDevSpec.Depth = 0;
            txtDevSpec.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDevSpec.HideSelection = true;
            txtDevSpec.Hint = "Especificaciones";
            txtDevSpec.LeadingIcon = null;
            txtDevSpec.Location = new Point(41, 244);
            txtDevSpec.MaxLength = 32767;
            txtDevSpec.MouseState = MaterialSkin.MouseState.OUT;
            txtDevSpec.Name = "txtDevSpec";
            txtDevSpec.PasswordChar = '\0';
            txtDevSpec.PrefixSuffixText = null;
            txtDevSpec.ReadOnly = false;
            txtDevSpec.RightToLeft = RightToLeft.No;
            txtDevSpec.SelectedText = "";
            txtDevSpec.SelectionLength = 0;
            txtDevSpec.SelectionStart = 0;
            txtDevSpec.ShortcutsEnabled = true;
            txtDevSpec.Size = new Size(462, 48);
            txtDevSpec.TabIndex = 9;
            txtDevSpec.TabStop = false;
            txtDevSpec.TextAlign = HorizontalAlignment.Left;
            txtDevSpec.TrailingIcon = null;
            txtDevSpec.UseSystemPasswordChar = false;
            txtDevSpec.TextChanged += TxtSanitizar_TextChanged;
            // 
            // txtFailDesc
            // 
            txtFailDesc.AnimateReadOnly = false;
            txtFailDesc.BackgroundImageLayout = ImageLayout.None;
            txtFailDesc.CharacterCasing = CharacterCasing.Normal;
            txtFailDesc.Depth = 0;
            txtFailDesc.HideSelection = true;
            txtFailDesc.Hint = "Descripición Problema";
            txtFailDesc.Location = new Point(41, 618);
            txtFailDesc.MaxLength = 32767;
            txtFailDesc.MouseState = MaterialSkin.MouseState.OUT;
            txtFailDesc.Name = "txtFailDesc";
            txtFailDesc.PasswordChar = '\0';
            txtFailDesc.ReadOnly = false;
            txtFailDesc.ScrollBars = ScrollBars.None;
            txtFailDesc.SelectedText = "";
            txtFailDesc.SelectionLength = 0;
            txtFailDesc.SelectionStart = 0;
            txtFailDesc.ShortcutsEnabled = true;
            txtFailDesc.Size = new Size(712, 120);
            txtFailDesc.TabIndex = 11;
            txtFailDesc.TabStop = false;
            txtFailDesc.TextAlign = HorizontalAlignment.Left;
            txtFailDesc.UseSystemPasswordChar = false;
            txtFailDesc.TextChanged += TxtSanitizar_TextChanged;
            // 
            // cmbModels
            // 
            cmbModels.AutoResize = false;
            cmbModels.BackColor = Color.FromArgb(255, 255, 255);
            cmbModels.Depth = 0;
            cmbModels.DrawMode = DrawMode.OwnerDrawVariable;
            cmbModels.DropDownHeight = 174;
            cmbModels.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModels.DropDownWidth = 121;
            cmbModels.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbModels.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbModels.FormattingEnabled = true;
            cmbModels.Hint = "Seleccione Modelo";
            cmbModels.IntegralHeight = false;
            cmbModels.ItemHeight = 43;
            cmbModels.Location = new Point(41, 167);
            cmbModels.MaxDropDownItems = 4;
            cmbModels.MouseState = MaterialSkin.MouseState.OUT;
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(232, 49);
            cmbModels.StartIndex = 0;
            cmbModels.TabIndex = 12;
            // 
            // btnFinish
            // 
            btnFinish.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFinish.Depth = 0;
            btnFinish.HighEmphasis = true;
            btnFinish.Icon = null;
            btnFinish.Location = new Point(339, 756);
            btnFinish.Margin = new Padding(4, 6, 4, 6);
            btnFinish.MouseState = MaterialSkin.MouseState.HOVER;
            btnFinish.Name = "btnFinish";
            btnFinish.NoAccentTextColor = Color.Empty;
            btnFinish.Size = new Size(99, 36);
            btnFinish.TabIndex = 13;
            btnFinish.Text = "Registrar";
            btnFinish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFinish.UseAccentColor = false;
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += BtnFinish_Click;
            btnFinish.KeyPress += TxtClient_KeyPress;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Depth = 0;
            lbl1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl1.Location = new Point(50, 559);
            lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(57, 19);
            lbl1.TabIndex = 14;
            lbl1.Text = "Técnico";
            // 
            // cmbTechnician
            // 
            cmbTechnician.AutoResize = false;
            cmbTechnician.BackColor = Color.FromArgb(255, 255, 255);
            cmbTechnician.Depth = 0;
            cmbTechnician.DrawMode = DrawMode.OwnerDrawVariable;
            cmbTechnician.DropDownHeight = 174;
            cmbTechnician.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTechnician.DropDownWidth = 121;
            cmbTechnician.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTechnician.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTechnician.FormattingEnabled = true;
            cmbTechnician.Hint = "Seleccione Técnico";
            cmbTechnician.IntegralHeight = false;
            cmbTechnician.ItemHeight = 43;
            cmbTechnician.Location = new Point(139, 544);
            cmbTechnician.MaxDropDownItems = 4;
            cmbTechnician.MouseState = MaterialSkin.MouseState.OUT;
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(207, 49);
            cmbTechnician.StartIndex = 0;
            cmbTechnician.TabIndex = 15;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(413, 558);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(115, 19);
            materialLabel6.TabIndex = 16;
            materialLabel6.Text = "Fecha Estimada";
            // 
            // dtPicker
            // 
            dtPicker.Location = new Point(553, 554);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(200, 23);
            dtPicker.TabIndex = 17;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(17, 155);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(738, 363);
            materialDivider1.TabIndex = 18;
            materialDivider1.Text = "materialDivider1";
            // 
            // dtEquipos
            // 
            dtEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEquipos.Location = new Point(41, 312);
            dtEquipos.Name = "dtEquipos";
            dtEquipos.Size = new Size(462, 152);
            dtEquipos.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(163, 473);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(88, 36);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Agregar";
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
            btnUpdate.Location = new Point(294, 473);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 21;
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
            btnDelete.Location = new Point(429, 473);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Quitar";
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
            btnUpdateConfirm.Location = new Point(221, 473);
            btnUpdateConfirm.Margin = new Padding(4, 6, 4, 6);
            btnUpdateConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateConfirm.Name = "btnUpdateConfirm";
            btnUpdateConfirm.NoAccentTextColor = Color.Empty;
            btnUpdateConfirm.Size = new Size(88, 36);
            btnUpdateConfirm.TabIndex = 23;
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
            btnUpdateCancel.Location = new Point(363, 473);
            btnUpdateCancel.Margin = new Padding(4, 6, 4, 6);
            btnUpdateCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateCancel.Name = "btnUpdateCancel";
            btnUpdateCancel.NoAccentTextColor = Color.Empty;
            btnUpdateCancel.Size = new Size(96, 36);
            btnUpdateCancel.TabIndex = 24;
            btnUpdateCancel.Text = "Cancelar";
            btnUpdateCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateCancel.UseAccentColor = false;
            btnUpdateCancel.UseVisualStyleBackColor = true;
            btnUpdateCancel.Visible = false;
            btnUpdateCancel.Click += BtnUpdateCancel_Click;
            // 
            // FrmNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 806);
            Controls.Add(btnUpdateCancel);
            Controls.Add(btnUpdateConfirm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtEquipos);
            Controls.Add(dtPicker);
            Controls.Add(materialLabel6);
            Controls.Add(cmbTechnician);
            Controls.Add(lbl1);
            Controls.Add(btnFinish);
            Controls.Add(cmbModels);
            Controls.Add(txtFailDesc);
            Controls.Add(txtDevSpec);
            Controls.Add(txtQuantity);
            Controls.Add(txtClient);
            Controls.Add(materialCard1);
            Controls.Add(materialLabel1);
            Controls.Add(materialDivider1);
            MaximizeBox = false;
            Name = "FrmNewOrder";
            Sizable = false;
            Text = "Registro de Orden";
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtClient;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantity;
        private MaterialSkin.Controls.MaterialTextBox2 txtDevSpec;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtFailDesc;
        private PictureBox pbImage;
        private MaterialSkin.Controls.MaterialComboBox cmbModels;
        private MaterialSkin.Controls.MaterialButton btnFinish;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialComboBox cmbTechnician;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DateTimePicker dtPicker;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private DataGridView dtEquipos;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdateConfirm;
        private MaterialSkin.Controls.MaterialButton btnUpdateCancel;
    }
}