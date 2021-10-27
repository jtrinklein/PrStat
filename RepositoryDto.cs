using System.Text.Json.Serialization;

namespace prstat
{
    public class RepositoryDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
