using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace prstat
{
    public class PullRequestDto
    {
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
