namespace Adarec_ui.View.ChildForms
{
    partial class FrmOrderDetail
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
            cmbStateOrder = new MaterialSkin.Controls.MaterialComboBox();
            dataGridView1 = new DataGridView();
            txtComment = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnUpdateCancel = new MaterialSkin.Controls.MaterialButton();
            btnUpdateConfirm = new MaterialSkin.Controls.MaterialButton();
            dtEquipos = new DataGridView();
            cmbModels = new MaterialSkin.Controls.MaterialComboBox();
            txtDevSpec = new MaterialSkin.Controls.MaterialTextBox2();
            txtQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pbImage = new PictureBox();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            txtOrderId = new MaterialSkin.Controls.MaterialTextBox();
            cmbItemStatus = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnFinalice = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEquipos).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // cmbStateOrder
            // 
            cmbStateOrder.AutoResize = false;
            cmbStateOrder.BackColor = Color.FromArgb(255, 255, 255);
            cmbStateOrder.Depth = 0;
            cmbStateOrder.DrawMode = DrawMode.OwnerDrawVariable;
            cmbStateOrder.DropDownHeight = 174;
            cmbStateOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStateOrder.DropDownWidth = 121;
            cmbStateOrder.Enabled = false;
            cmbStateOrder.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbStateOrder.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbStateOrder.FormattingEnabled = true;
            cmbStateOrder.Hint = "Estado Orden";
            cmbStateOrder.IntegralHeight = false;
            cmbStateOrder.ItemHeight = 43;
            cmbStateOrder.Location = new Point(570, 83);
            cmbStateOrder.MaxDropDownItems = 4;
            cmbStateOrder.MouseState = MaterialSkin.MouseState.OUT;
            cmbStateOrder.Name = "cmbStateOrder";
            cmbStateOrder.Size = new Size(195, 49);
            cmbStateOrder.StartIndex = 0;
            cmbStateOrder.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 559);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(739, 150);
            dataGridView1.TabIndex = 4;
            // 
            // txtComment
            // 
            txtComment.AnimateReadOnly = false;
            txtComment.BorderStyle = BorderStyle.None;
            txtComment.Depth = 0;
            txtComment.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtComment.Hint = "Nuevo Comentario";
            txtComment.LeadingIcon = null;
            txtComment.Location = new Point(27, 727);
            txtComment.MaxLength = 50;
            txtComment.MouseState = MaterialSkin.MouseState.OUT;
            txtComment.Multiline = false;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(738, 50);
            txtComment.TabIndex = 6;
            txtComment.Text = "";
            txtComment.TrailingIcon = null;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(28, 799);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(74, 36);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Añadir";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdateCancel
            // 
            btnUpdateCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateCancel.Depth = 0;
            btnUpdateCancel.HighEmphasis = true;
            btnUpdateCancel.Icon = null;
            btnUpdateCancel.Location = new Point(418, 468);
            btnUpdateCancel.Margin = new Padding(4, 6, 4, 6);
            btnUpdateCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateCancel.Name = "btnUpdateCancel";
            btnUpdateCancel.NoAccentTextColor = Color.Empty;
            btnUpdateCancel.Size = new Size(96, 36);
            btnUpdateCancel.TabIndex = 35;
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
            btnUpdateConfirm.Location = new Point(283, 468);
            btnUpdateConfirm.Margin = new Padding(4, 6, 4, 6);
            btnUpdateConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateConfirm.Name = "btnUpdateConfirm";
            btnUpdateConfirm.NoAccentTextColor = Color.Empty;
            btnUpdateConfirm.Size = new Size(88, 36);
            btnUpdateConfirm.TabIndex = 34;
            btnUpdateConfirm.Text = "Guardar";
            btnUpdateConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateConfirm.UseAccentColor = false;
            btnUpdateConfirm.UseVisualStyleBackColor = true;
            btnUpdateConfirm.Visible = false;
            btnUpdateConfirm.Click += BtnUpdateConfirm_Click;
            // 
            // dtEquipos
            // 
            dtEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEquipos.Location = new Point(52, 307);
            dtEquipos.Name = "dtEquipos";
            dtEquipos.Size = new Size(462, 152);
            dtEquipos.TabIndex = 30;
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
            cmbModels.Hint = "Modelo";
            cmbModels.IntegralHeight = false;
            cmbModels.ItemHeight = 43;
            cmbModels.Location = new Point(52, 162);
            cmbModels.MaxDropDownItems = 4;
            cmbModels.MouseState = MaterialSkin.MouseState.OUT;
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(164, 49);
            cmbModels.StartIndex = 0;
            cmbModels.TabIndex = 28;
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
            txtDevSpec.Location = new Point(52, 239);
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
            txtDevSpec.TabIndex = 27;
            txtDevSpec.TabStop = false;
            txtDevSpec.TextAlign = HorizontalAlignment.Left;
            txtDevSpec.TrailingIcon = null;
            txtDevSpec.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Cantidad";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(232, 162);
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
            txtQuantity.Size = new Size(102, 48);
            txtQuantity.TabIndex = 26;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(pbImage);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(531, 162);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(1);
            materialCard2.Size = new Size(222, 342);
            materialCard2.TabIndex = 25;
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
            pbImage.Click += PictureBox1_Click;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(28, 150);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(738, 363);
            materialDivider1.TabIndex = 29;
            materialDivider1.Text = "materialDivider1";
            // 
            // txtOrderId
            // 
            txtOrderId.AnimateReadOnly = false;
            txtOrderId.BorderStyle = BorderStyle.None;
            txtOrderId.Depth = 0;
            txtOrderId.Enabled = false;
            txtOrderId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOrderId.Hint = "Número de Orden";
            txtOrderId.LeadingIcon = null;
            txtOrderId.Location = new Point(27, 82);
            txtOrderId.MaxLength = 50;
            txtOrderId.MouseState = MaterialSkin.MouseState.OUT;
            txtOrderId.Multiline = false;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(153, 50);
            txtOrderId.TabIndex = 36;
            txtOrderId.Text = "";
            txtOrderId.TrailingIcon = null;
            // 
            // cmbItemStatus
            // 
            cmbItemStatus.AutoResize = false;
            cmbItemStatus.BackColor = Color.FromArgb(255, 255, 255);
            cmbItemStatus.Depth = 0;
            cmbItemStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cmbItemStatus.DropDownHeight = 174;
            cmbItemStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemStatus.DropDownWidth = 121;
            cmbItemStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbItemStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbItemStatus.FormattingEnabled = true;
            cmbItemStatus.Hint = "Estado";
            cmbItemStatus.IntegralHeight = false;
            cmbItemStatus.ItemHeight = 43;
            cmbItemStatus.Location = new Point(358, 161);
            cmbItemStatus.MaxDropDownItems = 4;
            cmbItemStatus.MouseState = MaterialSkin.MouseState.OUT;
            cmbItemStatus.Name = "cmbItemStatus";
            cmbItemStatus.Size = new Size(155, 49);
            cmbItemStatus.StartIndex = 0;
            cmbItemStatus.TabIndex = 37;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(340, 537);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(91, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Comentarios";
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(343, 468);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnFinalice
            // 
            btnFinalice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFinalice.Depth = 0;
            btnFinalice.HighEmphasis = true;
            btnFinalice.Icon = null;
            btnFinalice.Location = new Point(343, 841);
            btnFinalice.Margin = new Padding(4, 6, 4, 6);
            btnFinalice.MouseState = MaterialSkin.MouseState.HOVER;
            btnFinalice.Name = "btnFinalice";
            btnFinalice.NoAccentTextColor = Color.Empty;
            btnFinalice.Size = new Size(109, 36);
            btnFinalice.TabIndex = 39;
            btnFinalice.Text = "Actualizar";
            btnFinalice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFinalice.UseAccentColor = false;
            btnFinalice.UseVisualStyleBackColor = true;
            btnFinalice.Click += BtnFinalice_Click;
            // 
            // FrmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 897);
            Controls.Add(btnFinalice);
            Controls.Add(btnUpdate);
            Controls.Add(cmbItemStatus);
            Controls.Add(txtOrderId);
            Controls.Add(btnUpdateCancel);
            Controls.Add(btnUpdateConfirm);
            Controls.Add(dtEquipos);
            Controls.Add(cmbModels);
            Controls.Add(txtDevSpec);
            Controls.Add(txtQuantity);
            Controls.Add(materialCard2);
            Controls.Add(materialDivider1);
            Controls.Add(btnAdd);
            Controls.Add(txtComment);
            Controls.Add(materialLabel4);
            Controls.Add(dataGridView1);
            Controls.Add(cmbStateOrder);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOrderDetail";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Orden";
            TopMost = true;
            FormClosed += FrmOrderDetail_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEquipos).EndInit();
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cmbStateOrder;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox txtComment;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdateCancel;
        private MaterialSkin.Controls.MaterialButton btnUpdateConfirm;
        private DataGridView dtEquipos;
        private MaterialSkin.Controls.MaterialComboBox cmbModels;
        private MaterialSkin.Controls.MaterialTextBox2 txtDevSpec;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantity;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private PictureBox pbImage;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox txtOrderId;
        private MaterialSkin.Controls.MaterialComboBox cmbItemStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnFinalice;
    }
}