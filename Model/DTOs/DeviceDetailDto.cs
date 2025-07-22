using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class DeviceDetailDto
    {
        [JsonProperty("detailId")]
        public int? DetailId { get; set; }

        [JsonProperty("modelId")]
        public int? ModelId { get; set; }

        [JsonProperty("modelName")]
        public string? ModelName { get; set; }

        [JsonProperty("brandName")]
        public string? BrandName { get; set; }

        [JsonProperty("deviceTypeId")]
        public string? DeviceTypeName { get; set; }

        [JsonProperty("itemStatusId")]
        public int? ItemStatusId { get; set; }

        [JsonProperty("itemStatus")]
        public string? ItemStatus { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("intakePhoto")]
        public string? IntakePhoto { get; set; }

        [JsonProperty("solutionPhoto")]
        public string? SolutionPhoto { get; set; }

        [JsonProperty("deviceSpecs")]
        public string? DeviceSpecs { get; set; }
    }
}
