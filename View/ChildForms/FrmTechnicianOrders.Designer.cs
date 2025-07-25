﻿namespace Adarec_ui.View.ChildForms
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
            dtData = new DataGridView();
            cmbState = new MaterialSkin.Controls.MaterialComboBox();
            btnDetailOrder = new MaterialSkin.Controls.MaterialButton();
            txtFiltrer = new MaterialSkin.Controls.MaterialTextBox();
            rbNameClient = new MaterialSkin.Controls.MaterialRadioButton();
            rbIdentification = new MaterialSkin.Controls.MaterialRadioButton();
            btnReloadOrders = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dtData).BeginInit();
            SuspendLayout();
            // 
            // dtData
            // 
            dtData.AllowUserToAddRows = false;
            dtData.AllowUserToDeleteRows = false;
            dtData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtData.Location = new Point(6, 146);
            dtData.Name = "dtData";
            dtData.ReadOnly = true;
            dtData.Size = new Size(935, 344);
            dtData.TabIndex = 0;
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
            cmbState.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbState.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbState.FormattingEnabled = true;
            cmbState.Hint = "Estado";
            cmbState.IntegralHeight = false;
            cmbState.ItemHeight = 43;
            cmbState.Location = new Point(751, 88);
            cmbState.MaxDropDownItems = 4;
            cmbState.MouseState = MaterialSkin.MouseState.OUT;
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(190, 49);
            cmbState.StartIndex = 0;
            cmbState.TabIndex = 1;
            cmbState.SelectedIndexChanged += FilterOrders;
            // 
            // btnDetailOrder
            // 
            btnDetailOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDetailOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDetailOrder.Depth = 0;
            btnDetailOrder.HighEmphasis = true;
            btnDetailOrder.Icon = null;
            btnDetailOrder.Location = new Point(7, 499);
            btnDetailOrder.Margin = new Padding(4, 6, 4, 6);
            btnDetailOrder.MouseState = MaterialSkin.MouseState.HOVER;
            btnDetailOrder.Name = "btnDetailOrder";
            btnDetailOrder.NoAccentTextColor = Color.Empty;
            btnDetailOrder.Size = new Size(113, 36);
            btnDetailOrder.TabIndex = 2;
            btnDetailOrder.Text = "Ver Detalle";
            btnDetailOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDetailOrder.UseAccentColor = false;
            btnDetailOrder.UseVisualStyleBackColor = true;
            btnDetailOrder.Click += BtnDetailOrder_Click;
            // 
            // txtFiltrer
            // 
            txtFiltrer.AnimateReadOnly = false;
            txtFiltrer.BorderStyle = BorderStyle.None;
            txtFiltrer.Depth = 0;
            txtFiltrer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFiltrer.Hint = "Valor a Filtrar";
            txtFiltrer.LeadingIcon = null;
            txtFiltrer.Location = new Point(458, 87);
            txtFiltrer.MaxLength = 50;
            txtFiltrer.MouseState = MaterialSkin.MouseState.OUT;
            txtFiltrer.Multiline = false;
            txtFiltrer.Name = "txtFiltrer";
            txtFiltrer.Size = new Size(279, 50);
            txtFiltrer.TabIndex = 20;
            txtFiltrer.Text = "";
            txtFiltrer.TrailingIcon = null;
            txtFiltrer.TextChanged += FilterOrders;
            // 
            // rbNameClient
            // 
            rbNameClient.AutoSize = true;
            rbNameClient.Depth = 0;
            rbNameClient.Location = new Point(315, 100);
            rbNameClient.Margin = new Padding(0);
            rbNameClient.MouseLocation = new Point(-1, -1);
            rbNameClient.MouseState = MaterialSkin.MouseState.HOVER;
            rbNameClient.Name = "rbNameClient";
            rbNameClient.Ripple = true;
            rbNameClient.Size = new Size(91, 37);
            rbNameClient.TabIndex = 19;
            rbNameClient.TabStop = true;
            rbNameClient.Text = "Nombre";
            rbNameClient.UseVisualStyleBackColor = true;
            rbNameClient.CheckedChanged += FilterOrders;
            // 
            // rbIdentification
            // 
            rbIdentification.AutoSize = true;
            rbIdentification.Depth = 0;
            rbIdentification.Location = new Point(156, 100);
            rbIdentification.Margin = new Padding(0);
            rbIdentification.MouseLocation = new Point(-1, -1);
            rbIdentification.MouseState = MaterialSkin.MouseState.HOVER;
            rbIdentification.Name = "rbIdentification";
            rbIdentification.Ripple = true;
            rbIdentification.Size = new Size(131, 37);
            rbIdentification.TabIndex = 18;
            rbIdentification.TabStop = true;
            rbIdentification.Text = "Identificacion";
            rbIdentification.UseVisualStyleBackColor = true;
            rbIdentification.CheckedChanged += FilterOrders;
            // 
            // btnReloadOrders
            // 
            btnReloadOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReloadOrders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReloadOrders.Depth = 0;
            btnReloadOrders.HighEmphasis = true;
            btnReloadOrders.Icon = null;
            btnReloadOrders.Location = new Point(775, 498);
            btnReloadOrders.Margin = new Padding(4, 6, 4, 6);
            btnReloadOrders.MouseState = MaterialSkin.MouseState.HOVER;
            btnReloadOrders.Name = "btnReloadOrders";
            btnReloadOrders.NoAccentTextColor = Color.Empty;
            btnReloadOrders.Size = new Size(165, 36);
            btnReloadOrders.TabIndex = 21;
            btnReloadOrders.Text = "Recargar Ordenes";
            btnReloadOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReloadOrders.UseAccentColor = false;
            btnReloadOrders.UseVisualStyleBackColor = true;
            btnReloadOrders.Click += BtnReloadOrders_Click;
            // 
            // FrmTechnicianOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 543);
            Controls.Add(btnReloadOrders);
            Controls.Add(txtFiltrer);
            Controls.Add(rbNameClient);
            Controls.Add(rbIdentification);
            Controls.Add(btnDetailOrder);
            Controls.Add(cmbState);
            Controls.Add(dtData);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTechnicianOrders";
            Sizable = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Lista de Órdenes";
            TopMost = true;
            FormClosing += FrmTechnicianOrders_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dtData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtData;
        private MaterialSkin.Controls.MaterialComboBox cmbState;
        private MaterialSkin.Controls.MaterialButton btnDetailOrder;
        private MaterialSkin.Controls.MaterialTextBox txtFiltrer;
        private MaterialSkin.Controls.MaterialRadioButton rbNameClient;
        private MaterialSkin.Controls.MaterialRadioButton rbIdentification;
        private MaterialSkin.Controls.MaterialButton btnReloadOrders;
    }
}