using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinPrStat
{
    internal static class UpdateUtils
    {
        private static readonly string serverRoot = "https://apps.trinkle.in";
        private static readonly string serverVersionFile = "winprstat.latest.json";

        private static HttpClient CreateClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "WinPRStat .Net 5 Update Client");
            return client;
        }

        private static string GetVersionFileUrl()
        {
            return $"{serverRoot}/{serverVersionFile}";
        }

        private static string GetUpdatePageUrl(string version)
        {
            return $"https://github.com/jtrinklein/PrStat/releases/tag/v{version}";
        }

        private static async Task<ServerVersionInformation> GetLatestServerVersionInformation()
        {
            var client = CreateClient();
            var response = await client.GetAsync(GetVersionFileUrl());
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await JsonSerializer.DeserializeAsync<ServerVersionInformation>(response.Content.ReadAsStream());
        }

        public static async Task<UpdateInformation> CheckForUpdates(string currentVersion)
        {
            if (currentVersion.Split(".").Length < 3)
            {
                return new UpdateInformation();
            }

            var serverVersion = await GetLatestServerVersionInformation();
            if (serverVersion == null)
            {
                return new UpdateInformation();
            }

            return new UpdateInformation
            {
                Version = serverVersion.Version,
                Url = GetUpdatePageUrl(serverVersion.Version),
                NewerVersionAvailable = serverVersion.Version.IsNewerVersionThan(currentVersion),
            };
        }
    }
}
