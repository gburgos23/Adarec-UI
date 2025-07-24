
namespace Adarec_ui.Model.DTOs
{
    public class PendingOrderSummaryDto
    {
        public int? OrderId { get; set; }
        public string? CustomerName { get; set; }
        public string? Description { get; set; }
        public string? CustomerIdentification { get; set; }
        public int? Status { get; set; }
        public string? StatusDescription { get; set; }
        public DateTime? ScheduledFor { get; set; }
    }
}
