using System.Text.Json.Serialization;

namespace prstat
{
    public enum ReviewVote
    {
        Approved = 10,
        ApprovedWithSuggestions = 5,
        NotReviewed = 0,
        WaitingForAuthor = -5,
        Rejected = -10
    }

    public class Reviewer
    {
        [JsonPropertyName("vote")]
        public ReviewVote Vote { get; set; }
        [JsonPropertyName("displayName")]
        public string Name { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        public bool RequiresReview
        {
            get { return Vote == ReviewVote.NotReviewed || Vote == ReviewVote.NotReviewed; }
        }
    }
}
