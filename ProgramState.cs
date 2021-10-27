using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace prstat
{
    public class ProgramState
    {
        [JsonPropertyName("toasted")]
        public List<int> ToastedIds { get; set; } = new List<int>();
    }
}
