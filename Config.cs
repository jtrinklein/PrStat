using System.Collections.Generic;

namespace prstat
{
    public class Config
    {
        public string Organization { get; set; }
        public string Project { get; set; }
        public List<string> ReviewerIds { get; set; } = new List<string>();
        public string AccessToken { get; set; }
        public string Username { get; set; }
    }
}
