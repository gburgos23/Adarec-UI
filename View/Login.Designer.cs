namespace Adarec_ui.View
{
    partial class Login
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
            txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtUserName = new MaterialSkin.Controls.MaterialTextBox2();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            btnLogout = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(37, 329);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(260, 48);
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            // 
            // txtUserName
            // 
            txtUserName.AnimateReadOnly = false;
            txtUserName.BackgroundImageLayout = ImageLayout.None;
            txtUserName.CharacterCasing = CharacterCasing.Normal;
            txtUserName.Depth = 0;
            txtUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.HideSelection = true;
            txtUserName.Hint = "Usuario";
            txtUserName.LeadingIcon = null;
            txtUserName.Location = new Point(37, 245);
            txtUserName.MaxLength = 32767;
            txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PrefixSuffixText = null;
            txtUserName.ReadOnly = false;
            txtUserName.RightToLeft = RightToLeft.No;
            txtUserName.SelectedText = "";
            txtUserName.SelectionLength = 0;
            txtUserName.SelectionStart = 0;
            txtUserName.ShortcutsEnabled = true;
            txtUserName.Size = new Size(260, 48);
            txtUserName.TabIndex = 1;
            txtUserName.TabStop = false;
            txtUserName.TextAlign = HorizontalAlignment.Left;
            txtUserName.TrailingIcon = null;
            txtUserName.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(119, 410);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(91, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ingresar";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(119, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(146, 478);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(45, 45);
            btnLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogout.TabIndex = 6;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 177);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 7;
            label1.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 552);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            FormStyle = FormStyles.ActionBar_None;
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtUserName;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private PictureBox pictureBox1;
        private PictureBox btnLogout;
        private Label label1;
    }
}