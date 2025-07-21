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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lblIdOrder = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cmbStateOrder = new MaterialSkin.Controls.MaterialComboBox();
            dataGridView1 = new DataGridView();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtComment = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pbImage = new PictureBox();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnAccept = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(27, 101);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(132, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Número de Orden: ";
            // 
            // lblIdOrder
            // 
            lblIdOrder.AutoSize = true;
            lblIdOrder.Depth = 0;
            lblIdOrder.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIdOrder.Location = new Point(165, 101);
            lblIdOrder.MouseState = MaterialSkin.MouseState.HOVER;
            lblIdOrder.Name = "lblIdOrder";
            lblIdOrder.Size = new Size(107, 19);
            lblIdOrder.TabIndex = 1;
            lblIdOrder.Text = "materialLabel2";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(27, 158);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(54, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Estado:";
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
            cmbStateOrder.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbStateOrder.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbStateOrder.FormattingEnabled = true;
            cmbStateOrder.IntegralHeight = false;
            cmbStateOrder.ItemHeight = 43;
            cmbStateOrder.Location = new Point(165, 141);
            cmbStateOrder.MaxDropDownItems = 4;
            cmbStateOrder.MouseState = MaterialSkin.MouseState.OUT;
            cmbStateOrder.Name = "cmbStateOrder";
            cmbStateOrder.Size = new Size(282, 49);
            cmbStateOrder.StartIndex = 0;
            cmbStateOrder.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(608, 150);
            dataGridView1.TabIndex = 4;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(286, 220);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(91, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Comentarios";
            // 
            // txtComment
            // 
            txtComment.AnimateReadOnly = false;
            txtComment.BorderStyle = BorderStyle.None;
            txtComment.Depth = 0;
            txtComment.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtComment.LeadingIcon = null;
            txtComment.Location = new Point(306, 466);
            txtComment.MaxLength = 50;
            txtComment.MouseState = MaterialSkin.MouseState.OUT;
            txtComment.Multiline = false;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(330, 50);
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
            btnAdd.Location = new Point(562, 525);
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
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pbImage);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(27, 456);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(1);
            materialCard1.Size = new Size(244, 203);
            materialCard1.TabIndex = 8;
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(1, 1);
            pbImage.Margin = new Padding(0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(242, 201);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(306, 613);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccept.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAccept.Depth = 0;
            btnAccept.HighEmphasis = true;
            btnAccept.Icon = null;
            btnAccept.Location = new Point(377, 613);
            btnAccept.Margin = new Padding(4, 6, 4, 6);
            btnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            btnAccept.Name = "btnAccept";
            btnAccept.NoAccentTextColor = Color.Empty;
            btnAccept.Size = new Size(99, 36);
            btnAccept.TabIndex = 10;
            btnAccept.Text = "Grabar";
            btnAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAccept.UseAccentColor = false;
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // FrmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 676);
            Controls.Add(btnAccept);
            Controls.Add(btnUpdate);
            Controls.Add(materialCard1);
            Controls.Add(btnAdd);
            Controls.Add(txtComment);
            Controls.Add(materialLabel4);
            Controls.Add(dataGridView1);
            Controls.Add(cmbStateOrder);
            Controls.Add(materialLabel3);
            Controls.Add(lblIdOrder);
            Controls.Add(materialLabel1);
            Name = "FrmOrderDetail";
            Text = "Detalle de Orden";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblIdOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbStateOrder;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtComment;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox pbImage;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAccept;
    }
}