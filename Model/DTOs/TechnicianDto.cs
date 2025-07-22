using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class TechnicianDto
    {
        [JsonProperty("id")]
        public int? TechnicianId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("idRol")]
        public List<int?> IdRol { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; } = true;
    }
}
