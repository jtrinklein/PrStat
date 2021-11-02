using System.Collections.Generic;

namespace PrStat.Core
{
    public class PullRequest
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<Reviewer> Reviewers { get; set; }
        public bool NeedsReview { get; set; }
        public Author Author { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
