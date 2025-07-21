namespace Adarec_ui.View
{
    partial class Rol
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
            cmbRoles = new MaterialSkin.Controls.MaterialComboBox();
            btnContinue = new MaterialSkin.Controls.MaterialButton();
            btnLogout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(125, 53);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(199, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Seleccione su rol de acceso:";
            // 
            // cmbRoles
            // 
            cmbRoles.AutoResize = false;
            cmbRoles.BackColor = Color.FromArgb(255, 255, 255);
            cmbRoles.Depth = 0;
            cmbRoles.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRoles.DropDownHeight = 174;
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.DropDownWidth = 121;
            cmbRoles.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRoles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.IntegralHeight = false;
            cmbRoles.ItemHeight = 43;
            cmbRoles.Location = new Point(64, 104);
            cmbRoles.MaxDropDownItems = 4;
            cmbRoles.MouseState = MaterialSkin.MouseState.OUT;
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(311, 49);
            cmbRoles.StartIndex = 0;
            cmbRoles.TabIndex = 1;
            // 
            // btnContinue
            // 
            btnContinue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnContinue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnContinue.Depth = 0;
            btnContinue.HighEmphasis = true;
            btnContinue.Icon = null;
            btnContinue.Location = new Point(165, 190);
            btnContinue.Margin = new Padding(4, 6, 4, 6);
            btnContinue.MouseState = MaterialSkin.MouseState.HOVER;
            btnContinue.Name = "btnContinue";
            btnContinue.NoAccentTextColor = Color.Empty;
            btnContinue.Size = new Size(104, 36);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Continuar";
            btnContinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnContinue.UseAccentColor = false;
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += BtnContinue_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(382, 201);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(45, 45);
            btnLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogout.TabIndex = 7;
            btnLogout.TabStop = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // Rol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 261);
            ControlBox = false;
            Controls.Add(btnLogout);
            Controls.Add(btnContinue);
            Controls.Add(cmbRoles);
            Controls.Add(materialLabel1);
            FormStyle = FormStyles.ActionBar_None;
            MaximizeBox = false;
            Name = "Rol";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rol";
            FormClosing += Rol_FormClosing;
            Load += Rol_Load;
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbRoles;
        private MaterialSkin.Controls.MaterialButton btnContinue;
        private PictureBox btnLogout;
    }
}