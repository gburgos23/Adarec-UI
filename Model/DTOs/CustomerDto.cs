using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class CustomerDto
    {
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonProperty("identificationTypeId")]
        public int IdentificationTypeId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
