using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace PrStat.Core
{
    public class Config
    {
        public string Organization { get; set; }
        public string Project { get; set; }
        public List<string> ReviewerIds { get; set; } = new List<string>();
        public string AccessToken { get; set; }
        public string Username { get; set; }
        public bool ShowNotifications { get; set; } = true;
        public bool MinimizeToTray { get; set; }
        public bool Autostart { get; set; }

        public static void SaveConfig(Config c, string configPath)
        {
            using var f = File.OpenWrite(configPath);
            f.Write(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(c)));
        }
        private static Config CreateNewConfigFile(string configPath)
        {
            var config = new Config();
            SaveConfig(config, configPath);
            return config;
        }
        public static Config LoadConfig(string configPath)
        {
            try
            {
                using var f = File.OpenText(configPath);
                var config = JsonSerializer.Deserialize<Config>(f.ReadToEnd());
                return config;
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(configPath));
                return CreateNewConfigFile(configPath);
            }
            catch (FileNotFoundException)
            {
                return CreateNewConfigFile(configPath);
            }
        }
    }
}
