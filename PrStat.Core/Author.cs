using System.Text.Json.Serialization;

namespace PrStat.Core
{
    public class Author
    {
        [JsonPropertyName("displayName")]
        public string Name { get; set; }
        
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
