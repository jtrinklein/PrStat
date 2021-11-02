using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PrStat.Core
{
    public class PullRequestDto
    {
        [JsonPropertyName("createdBy")]
        public Author Author { get; set; }
        [JsonPropertyName("repository")]
        public RepositoryDto Repository { get; set; }
        [JsonPropertyName("pullRequestId")]
        public int Id { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("reviewers")]
        public List<Reviewer> Reviewers { get; set; }
    }
}
