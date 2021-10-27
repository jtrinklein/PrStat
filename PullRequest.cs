using System.Collections.Generic;

namespace prstat
{
    public class PullRequest
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<Reviewer> Reviewers { get; set; }
    }
}
