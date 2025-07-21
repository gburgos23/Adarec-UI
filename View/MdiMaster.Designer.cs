namespace Adarec_ui.View
{
    partial class MdiMaster
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gpPages = new MaterialSkin.Controls.MaterialTabControl();
            tpRClients = new TabPage();
            tpRNewOrder = new TabPage();
            tpROrders = new TabPage();
            tpTMyOrders = new TabPage();
            tpADashboard = new TabPage();
            tpAUsers = new TabPage();
            gpPages.SuspendLayout();
            SuspendLayout();
            // 
            // gpPages
            // 
            gpPages.Controls.Add(tpRClients);
            gpPages.Controls.Add(tpRNewOrder);
            gpPages.Controls.Add(tpROrders);
            gpPages.Controls.Add(tpTMyOrders);
            gpPages.Controls.Add(tpADashboard);
            gpPages.Controls.Add(tpAUsers);
            gpPages.Depth = 0;
            gpPages.Dock = DockStyle.Fill;
            gpPages.Location = new Point(3, 64);
            gpPages.MouseState = MaterialSkin.MouseState.HOVER;
            gpPages.Multiline = true;
            gpPages.Name = "gpPages";
            gpPages.SelectedIndex = 0;
            gpPages.Size = new Size(730, 456);
            gpPages.TabIndex = 4;
            gpPages.SelectedIndexChanged += gpPages_SelectedIndexChanged;
            // 
            // tpRClients
            // 
            tpRClients.Location = new Point(4, 24);
            tpRClients.Name = "tpRClients";
            tpRClients.Padding = new Padding(3);
            tpRClients.Size = new Size(722, 428);
            tpRClients.TabIndex = 0;
            tpRClients.Text = "Clientes";
            tpRClients.UseVisualStyleBackColor = true;
            // 
            // tpRNewOrder
            // 
            tpRNewOrder.Location = new Point(4, 24);
            tpRNewOrder.Name = "tpRNewOrder";
            tpRNewOrder.Padding = new Padding(3);
            tpRNewOrder.Size = new Size(722, 428);
            tpRNewOrder.TabIndex = 1;
            tpRNewOrder.Text = "Registro de Orden\n";
            tpRNewOrder.UseVisualStyleBackColor = true;
            // 
            // tpROrders
            // 
            tpROrders.Location = new Point(4, 24);
            tpROrders.Name = "tpROrders";
            tpROrders.Padding = new Padding(3);
            tpROrders.Size = new Size(722, 428);
            tpROrders.TabIndex = 2;
            tpROrders.Text = "Órdenes";
            tpROrders.UseVisualStyleBackColor = true;
            // 
            // tpTMyOrders
            // 
            tpTMyOrders.Location = new Point(4, 24);
            tpTMyOrders.Name = "tpTMyOrders";
            tpTMyOrders.Padding = new Padding(3);
            tpTMyOrders.Size = new Size(722, 428);
            tpTMyOrders.TabIndex = 3;
            tpTMyOrders.Text = "Mis Órdenes\n\n";
            tpTMyOrders.UseVisualStyleBackColor = true;
            // 
            // tpADashboard
            // 
            tpADashboard.Location = new Point(4, 24);
            tpADashboard.Name = "tpADashboard";
            tpADashboard.Size = new Size(722, 428);
            tpADashboard.TabIndex = 6;
            tpADashboard.Text = "Dashboard";
            tpADashboard.UseVisualStyleBackColor = true;
            // 
            // tpAUsers
            // 
            tpAUsers.Location = new Point(4, 24);
            tpAUsers.Name = "tpAUsers";
            tpAUsers.Size = new Size(722, 428);
            tpAUsers.TabIndex = 5;
            tpAUsers.Text = "Usuarios";
            tpAUsers.UseVisualStyleBackColor = true;
            // 
            // MdiMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(737, 523);
            Controls.Add(gpPages);
            DrawerTabControl = gpPages;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MdiMaster";
            Padding = new Padding(3, 64, 4, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido(a)";
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            FormClosing += MdiMaster_FormClosing;
            gpPages.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl gpPages;
        private TabPage tpRNewOrder;
        private TabPage tpROrders;
        private TabPage tpTMyOrders;
        private TabPage tpAUsers;
        private TabPage tpADashboard;
        private TabPage tpRClients;
    }
}



