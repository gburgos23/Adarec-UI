using Adarec_ui.Model;
using Adarec_ui.Model.DTOs;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Adarec_ui.View
{
    public partial class MdiMaster : MaterialForm
    {
        private readonly UserDto _userData;
        private readonly int _rolSeleccionado;

        public MdiMaster(UserDto userData, int rolSeleccionado)
        {
            InitializeComponent();
            this.Text += $" - {userData.Name}";

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Orange700,
                TextShade.WHITE
            );

            _userData = userData;
            _rolSeleccionado = rolSeleccionado;
            ConfigurarVistasPorRol();

            if (gpPages.TabPages.Count > 0)
            {
                gpPages.SelectedIndex = 0;
                gpPages_SelectedIndexChanged(gpPages, EventArgs.Empty);
            }
        }

        private void ConfigurarVistasPorRol()
        {
            gpPages.TabPages.Clear();

            switch ((Roles)_rolSeleccionado!)
            {
                case Roles.front_desk:
                    gpPages.TabPages.Add(tpRNewOrder);
                    gpPages.TabPages.Add(tpROrders);
                    gpPages.TabPages.Add(tpRClients);
                    break;
                case Roles.technician:
                    gpPages.TabPages.Add(tpTMyOrders);
                    break;
                case Roles.admin:
                    gpPages.TabPages.Add(tpADashboard);
                    gpPages.TabPages.Add(tpAUsers);
                    break;
            }
        }

        private void gpPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = gpPages.SelectedTab;
            if (tab == null) return;

            Type? formType = null;

            switch (tab.Name)
            {
                case "tpRClients":
                    formType = typeof(ChildForms.FrmClientManagement);
                    break;
                case "tpRNewOrder":
                    formType = typeof(ChildForms.FrmNewOrder);
                    break;
                case "tpROrders":
                    formType = typeof(ChildForms.FrmTechnicianOrders);
                    break;
                case "tpTMyOrders":
                    formType = typeof(ChildForms.FrmTechnicianOrders);
                    break;
                case "tpAUsers":
                    formType = typeof(ChildForms.FrmUserManagement);
                    break;
                case "tpADashboard":
                    formType = typeof(ChildForms.FrmAdminDashboard);
                    break;
            }

            if (formType == null) return;

            foreach (Control ctrl in tab.Controls)
            {
                if (ctrl.GetType() == formType)
                {
                    ctrl.BringToFront();
                    return;
                }
            }

            Form formToShow = (Form)Activator.CreateInstance(formType)!;
            formToShow.TopLevel = false;
            formToShow.StartPosition = FormStartPosition.CenterParent;
            tab.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void MdiMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(
                "¿Está seguro de que desea cerrar la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
