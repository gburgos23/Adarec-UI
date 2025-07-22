using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adarec_ui.Model.DTOs
{
    public class OrderFullDetailDto
    {
        [JsonProperty("orderId")]
        public int? OrderId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("scheduledFor")]
        public DateTime? ScheduledFor { get; set; }

        [JsonProperty("customer")]
        public CustomerDto Customer { get; set; }

        [JsonProperty("devices")]
        public List<DeviceDetailDto> Devices { get; set; }

        [JsonProperty("technician")]
        public TechnicianDto? Technician { get; set; }

        [JsonProperty("comments")]
        public List<CommentDetailDto> Comments { get; set; }
    }
}
