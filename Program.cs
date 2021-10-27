using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace prstat
{
    class Program
    {
        private static readonly string HandleToastArgument = "-ToastActivated";
        private static readonly string PrIdArg = "prId";
        private static readonly string PrUrlArg = "prUrl";
        private static readonly string ActionArg = "action";
        private static readonly string Action_View = "view";
        private static readonly string Action_MarkRead = "ignore";
        private static readonly string Action_Close = "close";
        private static readonly string ConfigFilename = ".\\appsettings.json";
        private static readonly string StateFilename = ".\\state.json";

        private static string ConfigPath => Path.Join(AppContext.BaseDirectory, ConfigFilename);
        private static string StatePath => Path.Join(AppContext.BaseDirectory, StateFilename);
        private static HttpClient _httpClient;
        private static HttpClient httpClient => _httpClient ??= new HttpClient();
        private static readonly Logger logger = new() { LogToFile = true };

        static void ListenToNotificationActivation()
        {
            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                // Obtain the arguments from the notification
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
                var prId = args.GetInt(PrIdArg);
                var action = args.Get(ActionArg);
                var url = args.Get(PrUrlArg);
                // Obtain any user input (text boxes, menu selections) from the notification
                ValueSet userInput = toastArgs.UserInput;

                logger.Log($"For PR: {prId} doing Action: {action}");

                if (action == Action_View)
                {
                    OpenUrl(url);
                }
                // Need to dispatch to UI thread if performing UI operations
                // TODO: Show the corresponding content
                logger.Log("Toast activated. Args: " + toastArgs.Argument);

                //Toast activated.Args: action=view;prId=5672
                
            };

        }

        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private static void GenerateToastForPr(PullRequest pr)
        {
            var shortDescriptionLength = Math.Min(pr.Description?.Length ?? 0, 40);
            var description = pr.Description?[..shortDescriptionLength] ?? string.Empty;
            new ToastContentBuilder()
                .AddArgument(PrIdArg, pr.Id)
                .AddArgument(PrUrlArg, pr.Url)
                .AddText($"PR {pr.Id} Needs Review")
                .AddText(pr.Title)
                .AddText(description)

                .AddButton(new ToastButton()
                    .SetContent("View")
                    .AddArgument(ActionArg, Action_View)
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Mark Read")
                    .AddArgument(ActionArg, Action_MarkRead)
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Dismiss")
                    .AddArgument(ActionArg, Action_Close)
                    .SetBackgroundActivation())

                .Show();
        }

        private static AuthenticationHeaderValue GetAuthHeader(Config config)
        {
            var creds = $"{config.Username}:{config.AccessToken}";
            var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(creds));
            return new AuthenticationHeaderValue("Basic", auth);
        }

        private static async Task<IList<PullRequest>> GetPullRequestList(Config config)
        {
            var urls = from id in config.ReviewerIds
                       select $"https://dev.azure.com/{config.Organization}/{config.Project}/_apis/git/pullrequests?searchCriteria.reviewerId={id}&api-version=6.0";

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Authorization = GetAuthHeader(config);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "PRStat .Net 5 Windows Client");
            var pullRequests = new List<PullRequest>();
            foreach (var url in urls)
            {
                var dto = await JsonSerializer.DeserializeAsync<PullRequestsResponseDto>(await httpClient.GetStreamAsync(url));
                foreach (var prDto in dto.PullRequests)
                {
                    if (prDto.Reviewers.Any(r => r.RequiresReview && config.ReviewerIds.Contains(r.Id)))
                    { 
                        var pr = new PullRequest { 
                            Description = prDto.Description,
                            Title = prDto.Title,
                            Id = prDto.Id,
                            Reviewers = prDto.Reviewers,
                            Url = $"https://dev.azure.com/{config.Organization}/{config.Project}/_git/{prDto.Repository.Name}/pullrequest/{prDto.Id}"
                        };
                        pullRequests.Add(pr);
                    }

                }
            }
            
            return pullRequests;
        }

        private static void SaveState(ProgramState ps)
        {
            using var f = File.OpenWrite(StatePath);
            f.Write(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(ps)));
        }
        
        private static ProgramState LoadState()
        {
            try
            {
                using var f = File.OpenText(StatePath);
                var state = JsonSerializer.Deserialize<ProgramState>(f.ReadToEnd());
                return state;
            }
            catch (FileNotFoundException)
            {
                var state = new ProgramState();
                SaveState(state);
                return state;
            }
            
        }
        private static void SaveConfig(Config c)
        {
            using var f = File.OpenWrite(ConfigPath);
            f.Write(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(c)));
        }

        private static Config LoadConfig()
        {
            try
            {
                using var f = File.OpenText(ConfigPath);
                var config = JsonSerializer.Deserialize<Config>(f.ReadToEnd());
                return config;
            }
            catch (FileNotFoundException)
            {
                var config = new Config();

                SaveConfig(config);
                return config;
            }
        }
        
        static async Task Main(string[] args)
        {
            var isHandlingToast = args.Contains(HandleToastArgument);
            logger.Log("Listen for toasts");
            ListenToNotificationActivation();

            if (isHandlingToast)
            {
                logger.Log("Handled toast, exiting.");
                return;
            }

            logger.Log("clear toast history");
            ToastNotificationManagerCompat.History.Clear();
                        
            var config = LoadConfig();
            var state = LoadState();
            logger.Log("Fetch PullRequest list");
            var prs = await GetPullRequestList(config);
            prs = prs.Where(pr => !state.ToastedIds.Contains(pr.Id)).ToList();
            state.ToastedIds.AddRange(prs.Select(pr => pr.Id));
            foreach (var pr in prs)
            {
                //Console.WriteLine("===========================================================");
                //Console.WriteLine($"PR: {pr.Id}");
                //Console.WriteLine(pr.Title);
                //Console.WriteLine(" * " + string.Join("\n * ", pr.Reviewers.Select(r => $"{r.Name.PadRight(30)} - {r.Vote}")));
                GenerateToastForPr(pr);
            }
            SaveState(state);
        }
    }
}
