using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrStat.Core
{
    public class ProgramState
    {
        [JsonPropertyName("toasted")]
        public List<int> ToastedIds { get; set; } = new List<int>();

        [JsonPropertyName("requiresReview")]
        public List<int> RequiresReview { get; set; } = new List<int>();

        [JsonPropertyName("reviewed")]
        public List<int> Reviewed { get; set; } = new List<int>();

        public static void SaveState(ProgramState ps, string statePath)
        {
            using var f = File.OpenWrite(statePath);
            f.Write(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(ps)));
        }

        public static ProgramState LoadState(string statePath)
        {
            try
            {
                using var f = File.OpenText(statePath);
                var state = JsonSerializer.Deserialize<ProgramState>(f.ReadToEnd());
                return state;
            }
            catch (FileNotFoundException)
            {
                var state = new ProgramState();
                SaveState(state, statePath);
                return state;
            }

        }
    }
}
