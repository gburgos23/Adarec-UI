using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class OrderDto
    {
        [JsonProperty("orderId")]
        public int? OrderId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduledFor")]
        public DateTime? ScheduledFor { get; set; }

        [JsonProperty("orderStatusId")]
        public int OrderStatusId { get; set; }

        [JsonProperty("customer")]
        public CustomerDto Customer { get; set; }

        [JsonProperty("devices")]
        public List<DeviceDetailDto> Devices { get; set; }

        [JsonProperty("technicianId")]
        public int? TechnicianId { get; set; }

        [JsonProperty("lastComment")]
        public CommentDetailDto? LastComment { get; set; }
    }
}
