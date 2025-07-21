namespace Adarec_ui.View.ChildForms
{
    partial class FrmTechnicianOrders
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
            dataGridView1 = new DataGridView();
            cmbState = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(813, 321);
            dataGridView1.TabIndex = 0;
            // 
            // cmbState
            // 
            cmbState.AutoResize = false;
            cmbState.BackColor = Color.FromArgb(255, 255, 255);
            cmbState.Depth = 0;
            cmbState.DrawMode = DrawMode.OwnerDrawVariable;
            cmbState.DropDownHeight = 174;
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbState.DropDownWidth = 121;
            cmbState.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbState.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbState.FormattingEnabled = true;
            cmbState.Hint = "Estado";
            cmbState.IntegralHeight = false;
            cmbState.ItemHeight = 43;
            cmbState.Location = new Point(629, 89);
            cmbState.MaxDropDownItems = 4;
            cmbState.MouseState = MaterialSkin.MouseState.OUT;
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(190, 49);
            cmbState.StartIndex = 0;
            cmbState.TabIndex = 1;
            // 
            // FrmTechnicianOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 518);
            Controls.Add(cmbState);
            Controls.Add(dataGridView1);
            Name = "FrmTechnicianOrders";
            Text = "Lista de Órdenes";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialComboBox cmbState;
    }
}