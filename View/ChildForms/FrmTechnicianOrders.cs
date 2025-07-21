using MaterialSkin;
using MaterialSkin.Controls;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmTechnicianOrders : MaterialForm
    {
        public FrmTechnicianOrders()
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
