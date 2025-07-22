using Newtonsoft.Json;

namespace Adarec_ui.Model.DTOs
{
    public class CommentDetailDto
    {
        [JsonProperty("commentId")]
        public int CommentId { get; set; }

        [JsonProperty("userId")]
        public int? UserId { get; set; }

        [JsonProperty("userName")]
        public string? UserName { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
