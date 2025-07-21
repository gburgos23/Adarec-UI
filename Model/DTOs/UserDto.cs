using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Adarec_ui.Model.DTOs
{
    public class UserDto
    {
        [JsonProperty("id")]
        public int? UserId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("idRol")]
        public List<int?> IdRol { get; set; }

        [JsonPropertyName("status")]
        public bool Status { get; set; } = true;
    }
}
