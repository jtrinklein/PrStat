using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PrStat.Core
{
    public class PullRequestsResponseDto
    {
        [JsonPropertyName("value")]
        public List<PullRequestDto> PullRequests { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
