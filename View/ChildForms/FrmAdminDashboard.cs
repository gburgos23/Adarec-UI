using MaterialSkin;
using MaterialSkin.Controls;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmAdminDashboard : MaterialForm
    {
        public FrmAdminDashboard()
        {
            InitializeComponent();
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
        }
    }
}
