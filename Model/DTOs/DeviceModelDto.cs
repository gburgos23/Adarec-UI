

using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class DeviceModelDto
    {
        [JsonProperty("modelId")]
        public int? ModelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("brandId")]
        public int BrandId { get; set; }

        [JsonProperty("deviceTypeId")]
        public int DeviceTypeId { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; } = true;
    }
}
