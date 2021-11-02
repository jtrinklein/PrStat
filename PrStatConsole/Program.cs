using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PrStat.Core;

namespace prstat
{
    class Program
    {
        private static readonly string Version = "1.0.0";
        private static readonly string ConfigFilename = ".\\config.json";
        private static readonly string StateFilename = ".\\state.json";

        private static string ConfigPath => Path.Join(AppContext.BaseDirectory, ConfigFilename);
        private static string StatePath => Path.Join(AppContext.BaseDirectory, StateFilename);

        private static readonly Logger logger = new() { LogToFile = true };

        private static AzureDevOpsApi _adoApi;
        public static AzureDevOpsApi AdoApi => _adoApi ??= new AzureDevOpsApi();


        static async Task Main(string[] args)
        {
            var doConfigure = false;
            foreach (var arg in args)
            {
                if (arg.ToLower() == "-version")
                {
                    Console.WriteLine($"PrStat console version {Version}");
                    return;
                }
                doConfigure = doConfigure || arg.ToLower() == "-configure";
                
            }
            //ToastNotificationManagerCompat.History.Clear();
                        
            var config = Config.LoadConfig(ConfigPath);
            var state = ProgramState.LoadState(StatePath);

            if (doConfigure)
            {
                config = PromptUserForConfigOptions(config);
                Config.SaveConfig(config, ConfigPath);
            }
            logger.Log("Fetch PullRequest list");
            var prs = (await AdoApi.GetPullRequestListForReviewers(config))
                .Where(pr => pr.NeedsReview).ToList();
            foreach (var pr in prs)
            {
                Console.WriteLine($"{pr.Id} - {pr.Title} - {pr.Url}");
            }
            ProgramState.SaveState(state, StatePath);
        }

        private static Config PromptUserForConfigOptions(Config config)
        {
            Console.WriteLine("Update the configuration. Leave empty to use existing values.");
            string input = string.Empty;
            var newConfig = new Config();
            Console.Write($"Organization (current: {config.Organization ?? String.Empty}): ");
            input = Console.ReadLine().Trim();
            newConfig.Organization = !string.IsNullOrEmpty(input)
                ? input : config.Organization;

            Console.Write($"Project (current: {config.Project ?? String.Empty}): ");
            input = Console.ReadLine().Trim();
            newConfig.Project = !string.IsNullOrEmpty(input)
                ? input : config.Project;

            Console.Write($"Username (current: {config.Username ?? String.Empty}): ");
            input = Console.ReadLine().Trim();
            newConfig.Username = !string.IsNullOrEmpty(input)
                ? input : config.Username;

            Console.Write($"Access Token (current: {config.AccessToken?.Substring(0, 4).PadRight(15, '*') ?? String.Empty }): ");
            input = Console.ReadLine().Trim();
            newConfig.AccessToken = !string.IsNullOrEmpty(input)
                ? input : config.AccessToken;

            Console.WriteLine($"Reviewer Ids (current: {string.Join(",", config.ReviewerIds)})");
            Console.WriteLine("Leave empty to stop");
            string reviewerId;
            do
            {
                Console.Write("> ");
                reviewerId = Console.ReadLine().Trim();
                if (reviewerId.Length > 0)
                {
                    newConfig.ReviewerIds.Add(reviewerId);
                }
            } while (reviewerId.Length > 0);
            

            if (newConfig.ReviewerIds.Count == 0)
            {
                newConfig.ReviewerIds.AddRange(config.ReviewerIds);
            }

            return newConfig;
        }
    }
}
