
using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class ApiResponseDto
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; } = string.Empty;
    }
}
