using System.Text.Json.Serialization;

namespace PrStat.Core
{
    public class RepositoryDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
