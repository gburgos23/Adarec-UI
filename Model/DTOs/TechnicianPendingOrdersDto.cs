
namespace Adarec_ui.Model.DTOs
{
    public class TechnicianPendingOrdersDto
    {
        public int? TechnicianId { get; set; }
        public string? TechnicianName { get; set; }
        public List<PendingOrderSummaryDto>? PendingOrders { get; set; }
        public CustomerDto? Customer { get; set; }
    }
}
