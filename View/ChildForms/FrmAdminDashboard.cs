using Adarec_ui.Controller;
using Adarec_ui.Model;
using Adarec_ui.Model.DTOs;
using LiveCharts;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Globalization;

namespace Adarec_ui.View.ChildForms
{
    public partial class FrmAdminDashboard : MaterialForm
    {
        public FrmAdminDashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,
                Primary.Teal700,
                Primary.Teal100,
                Accent.Orange200,
                TextShade.BLACK);

            cmbToday.Checked = true;
            pieStatus.Title = new LabelVisual
            {
                Text = "Ordenes por Estado",
                TextSize = 20,
                Paint = new SolidColorPaint { Color = SkiaSharp.SKColors.Black }
            }
            ;
            barWorkload.Title = new LabelVisual
            {
                Text = "Ordenes Pendientes por Técnico",
                TextSize = 20,
                Paint = new SolidColorPaint { Color = SkiaSharp.SKColors.Black }
            };
            LoadCharts();
            LoadCombosAsync();
        }

        private async void LoadCombosAsync()
        {
            var userController = new UserController();
            var userResponse = await userController.GetActiveUsersAsync();
            if (userResponse.StatusCode == 200)
            {
                var users = JsonConvert.DeserializeObject<List<TechnicianDto>>(userResponse.Message);
                var techs = users?
                    .Where(u => u.IdRol != null && u.IdRol.Contains((int)Roles.technician))
                    .ToList();

                cmbTechnician.DataSource = techs;
                cmbTechnician.DisplayMember = "Name";
                cmbTechnician.ValueMember = "TechnicianId";
                cmbTechnician.SelectedIndex = -1;
            }
        }

        private async void LoadCharts()
        {
            var orderController = new OrderController();
            ApiResponseDto statusResponse;
            ApiResponseDto workloadResponse;
            List<TicketCountByStatusDto> statusData = [];
            List<TechnicianWorkloadDto> workloadData = [];

            int? idTechnician = null;
            if (cmbTechnician.SelectedIndex != -1)
                idTechnician = cmbTechnician.SelectedValue as int?;

            if (cmbToday.Checked)
            {
                var date = DateTime.Now.Date;
                statusResponse = await orderController.GetTicketCountByStatusAsync(date.Year, date.Month, idTechnician);
            }
            else
            {
                statusResponse = await orderController.GetTicketCountByStatusAsync(technicianId: idTechnician);
            }

            workloadResponse = await orderController.GetTechnicianWorkloadAsync();

            if (statusResponse.StatusCode == 200 && !string.IsNullOrEmpty(statusResponse.Message))
                statusData = JsonConvert.DeserializeObject<List<TicketCountByStatusDto>>(statusResponse.Message) ?? [];

            if (workloadResponse.StatusCode == 200 && !string.IsNullOrEmpty(workloadResponse.Message))
                workloadData = JsonConvert.DeserializeObject<List<TechnicianWorkloadDto>>(workloadResponse.Message) ?? [];

            pieStatus.Series = [.. statusData
                .GroupBy(x => x.Status)
                .Select(g => new PieSeries<int>
                {
                    Name = g.Key,
                    Values = [g.Sum(x => x.Count)] 
                })];

            barWorkload.Series =
            [
                new ColumnSeries<int>
                {
                    Name = "Orders",
                    Values = [.. workloadData.Select(x => x.AssignedOrdersCount)]
                }
            ];
            barWorkload.XAxes = [new Axis { Labels = [.. workloadData.Select(x => x.TechnicianName)] }];
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void CmbHistoric_CheckedChanged(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void CmbToday_CheckedChanged(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void CmbTechs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCharts();
        }
    }
}
