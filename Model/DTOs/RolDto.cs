using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class RolDto
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("status")]
        public bool Status { get; set; } = true;
    }
}
