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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            polarChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PolarChart();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(66, 113);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(429, 186);
            cartesianChart1.TabIndex = 0;
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(587, 113);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(434, 186);
            pieChart1.TabIndex = 1;
            // 
            // pieChart2
            // 
            pieChart2.InitialRotation = 0D;
            pieChart2.IsClockwise = true;
            pieChart2.Location = new Point(587, 399);
            pieChart2.MaxAngle = 360D;
            pieChart2.MaxValue = double.NaN;
            pieChart2.MinValue = 0D;
            pieChart2.Name = "pieChart2";
            pieChart2.Size = new Size(434, 216);
            pieChart2.TabIndex = 2;
            // 
            // polarChart1
            // 
            polarChart1.Location = new Point(66, 399);
            polarChart1.Name = "polarChart1";
            polarChart1.Size = new Size(429, 216);
            polarChart1.TabIndex = 3;
            // 
            // FrmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 681);
            Controls.Add(polarChart1);
            Controls.Add(pieChart2);
            Controls.Add(pieChart1);
            Controls.Add(cartesianChart1);
            MaximizeBox = false;
            Name = "FrmAdminDashboard";
            Sizable = false;
            Text = "Dashboard Estadistico";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.PolarChart polarChart1;
    }
}