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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pbImage = new PictureBox();
            txtClient = new MaterialSkin.Controls.MaterialTextBox2();
            txtQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            txtDevSpec = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txtFailDesc = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            cmbModels = new MaterialSkin.Controls.MaterialComboBox();
            btnFinish = new MaterialSkin.Controls.MaterialButton();
            lbl1 = new MaterialSkin.Controls.MaterialLabel();
            cmbTechnician = new MaterialSkin.Controls.MaterialComboBox();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
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
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(50, 188);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(54, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Modelo";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(50, 260);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(65, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Cantidad";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(50, 344);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(120, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Especificaciones";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pbImage);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 495);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(1);
            materialCard1.Size = new Size(300, 249);
            materialCard1.TabIndex = 4;
            // 
            // pbImage
            // 
            pbImage.AllowDrop = true;
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(1, 1);
            pbImage.Margin = new Padding(0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(298, 247);
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
            txtClient.Location = new Point(213, 95);
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
            txtClient.Size = new Size(521, 48);
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
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(213, 248);
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
            txtQuantity.Size = new Size(521, 48);
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
            txtDevSpec.LeadingIcon = null;
            txtDevSpec.Location = new Point(213, 330);
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
            txtDevSpec.Size = new Size(521, 48);
            txtDevSpec.TabIndex = 9;
            txtDevSpec.TabStop = false;
            txtDevSpec.TextAlign = HorizontalAlignment.Left;
            txtDevSpec.TrailingIcon = null;
            txtDevSpec.UseSystemPasswordChar = false;
            txtDevSpec.TextChanged += TxtSanitizar_TextChanged;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(349, 495);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(144, 19);
            materialLabel5.TabIndex = 10;
            materialLabel5.Text = "Descripción de Falla";
            // 
            // txtFailDesc
            // 
            txtFailDesc.AnimateReadOnly = false;
            txtFailDesc.BackgroundImageLayout = ImageLayout.None;
            txtFailDesc.CharacterCasing = CharacterCasing.Normal;
            txtFailDesc.Depth = 0;
            txtFailDesc.HideSelection = true;
            txtFailDesc.Location = new Point(349, 531);
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
            txtFailDesc.Size = new Size(385, 150);
            txtFailDesc.TabIndex = 11;
            txtFailDesc.TabStop = false;
            txtFailDesc.TextAlign = HorizontalAlignment.Left;
            txtFailDesc.UseSystemPasswordChar = false;
            txtFailDesc.Click += txtFailDesc_Click;
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
            cmbModels.IntegralHeight = false;
            cmbModels.ItemHeight = 43;
            cmbModels.Location = new Point(213, 171);
            cmbModels.MaxDropDownItems = 4;
            cmbModels.MouseState = MaterialSkin.MouseState.OUT;
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(280, 49);
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
            btnFinish.Location = new Point(349, 708);
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
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Depth = 0;
            lbl1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl1.Location = new Point(50, 424);
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
            cmbTechnician.IntegralHeight = false;
            cmbTechnician.ItemHeight = 43;
            cmbTechnician.Location = new Point(213, 405);
            cmbTechnician.MaxDropDownItems = 4;
            cmbTechnician.MouseState = MaterialSkin.MouseState.OUT;
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(280, 49);
            cmbTechnician.StartIndex = 0;
            cmbTechnician.TabIndex = 15;
            // 
            // FrmNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 761);
            Controls.Add(cmbTechnician);
            Controls.Add(lbl1);
            Controls.Add(btnFinish);
            Controls.Add(cmbModels);
            Controls.Add(txtFailDesc);
            Controls.Add(materialLabel5);
            Controls.Add(txtDevSpec);
            Controls.Add(txtQuantity);
            Controls.Add(txtClient);
            Controls.Add(materialCard1);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            MaximizeBox = false;
            Name = "FrmNewOrder";
            Sizable = false;
            Text = "Registro de Orden";
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtClient;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantity;
        private MaterialSkin.Controls.MaterialTextBox2 txtDevSpec;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtFailDesc;
        private PictureBox pbImage;
        private MaterialSkin.Controls.MaterialComboBox cmbModels;
        private MaterialSkin.Controls.MaterialButton btnFinish;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialComboBox cmbTechnician;
    }
}