namespace Adarec_ui.View.ChildForms
{
    partial class FrmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDashboard));
            barWorkload = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            btnReload = new MaterialSkin.Controls.MaterialButton();
            pieStatus = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            cmbHistoric = new MaterialSkin.Controls.MaterialRadioButton();
            cmbToday = new MaterialSkin.Controls.MaterialRadioButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            cmbTechnician = new MaterialSkin.Controls.MaterialComboBox();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // barWorkload
            // 
            barWorkload.Location = new Point(12, 13);
            barWorkload.Margin = new Padding(15);
            barWorkload.MatchAxesScreenDataRatio = false;
            barWorkload.Name = "barWorkload";
            barWorkload.Size = new Size(700, 205);
            barWorkload.TabIndex = 0;
            // 
            // btnReload
            // 
            btnReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReload.Depth = 0;
            btnReload.HighEmphasis = true;
            btnReload.Icon = null;
            btnReload.Location = new Point(294, 644);
            btnReload.Margin = new Padding(4, 6, 4, 6);
            btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            btnReload.Name = "btnReload";
            btnReload.NoAccentTextColor = Color.Empty;
            btnReload.Size = new Size(109, 36);
            btnReload.TabIndex = 4;
            btnReload.Text = "Actualizar";
            btnReload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReload.UseAccentColor = false;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += BtnReload_Click;
            // 
            // pieStatus
            // 
            pieStatus.InitialRotation = 0D;
            pieStatus.IsClockwise = true;
            pieStatus.Location = new Point(12, 65);
            pieStatus.MaxAngle = 360D;
            pieStatus.MaxValue = double.NaN;
            pieStatus.MinValue = 0D;
            pieStatus.Name = "pieStatus";
            pieStatus.Size = new Size(700, 210);
            pieStatus.TabIndex = 5;
            // 
            // cmbHistoric
            // 
            cmbHistoric.AutoSize = true;
            cmbHistoric.Depth = 0;
            cmbHistoric.Location = new Point(488, 14);
            cmbHistoric.Margin = new Padding(0);
            cmbHistoric.MouseLocation = new Point(-1, -1);
            cmbHistoric.MouseState = MaterialSkin.MouseState.HOVER;
            cmbHistoric.Name = "cmbHistoric";
            cmbHistoric.Ripple = true;
            cmbHistoric.Size = new Size(98, 37);
            cmbHistoric.TabIndex = 6;
            cmbHistoric.TabStop = true;
            cmbHistoric.Text = "Historico";
            cmbHistoric.UseVisualStyleBackColor = true;
            cmbHistoric.CheckedChanged += CmbHistoric_CheckedChanged;
            // 
            // cmbToday
            // 
            cmbToday.AutoSize = true;
            cmbToday.Depth = 0;
            cmbToday.Location = new Point(598, 14);
            cmbToday.Margin = new Padding(0);
            cmbToday.MouseLocation = new Point(-1, -1);
            cmbToday.MouseState = MaterialSkin.MouseState.HOVER;
            cmbToday.Name = "cmbToday";
            cmbToday.Ripple = true;
            cmbToday.Size = new Size(114, 37);
            cmbToday.TabIndex = 7;
            cmbToday.TabStop = true;
            cmbToday.Text = "Mes Actual";
            cmbToday.UseVisualStyleBackColor = true;
            cmbToday.CheckedChanged += CmbToday_CheckedChanged;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(barWorkload);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(6, 396);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(723, 228);
            materialCard1.TabIndex = 9;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(cmbToday);
            materialCard2.Controls.Add(cmbTechnician);
            materialCard2.Controls.Add(pieStatus);
            materialCard2.Controls.Add(cmbHistoric);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(6, 84);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(723, 284);
            materialCard2.TabIndex = 10;
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
            cmbTechnician.Hint = "Filtrar por Técnico";
            cmbTechnician.IntegralHeight = false;
            cmbTechnician.ItemHeight = 43;
            cmbTechnician.Location = new Point(12, 10);
            cmbTechnician.MaxDropDownItems = 4;
            cmbTechnician.MouseState = MaterialSkin.MouseState.OUT;
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(184, 49);
            cmbTechnician.StartIndex = 0;
            cmbTechnician.TabIndex = 11;
            cmbTechnician.SelectedIndexChanged += CmbTechs_SelectedIndexChanged;
            // 
            // FrmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 689);
            Controls.Add(btnReload);
            Controls.Add(materialCard1);
            Controls.Add(materialCard2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminDashboard";
            Sizable = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Dashboard Estadistico";
            TopMost = true;
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart barWorkload;
        private MaterialSkin.Controls.MaterialButton btnReload;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieStatus;
        private MaterialSkin.Controls.MaterialRadioButton cmbHistoric;
        private MaterialSkin.Controls.MaterialRadioButton cmbToday;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialComboBox cmbTechnician;
    }
}