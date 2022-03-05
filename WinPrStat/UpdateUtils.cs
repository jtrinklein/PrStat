using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinPrStat
{
    public static class StringExtensions
    {
        public static bool IsNewerVersionThan(this string mine, string testVersion)
        {
            var myParts = mine.Split('.').Select(x => int.Parse(x)).ToArray();
            var testParts = testVersion.Split('.').Select(x => int.Parse(x)).ToArray();
            return myParts[0] > testParts[0] || 
                (myParts[0] == testParts[0] && myParts[1] > testParts[1]) ||
                (myParts[0] == testParts[0] && myParts[1] == testParts[1] && myParts[2] > testParts[2]);
        }
    }
    internal class UpdateInformation
    {
        public string ServerVersion { get; init; } = "7.0.0";
        public string ZipUrl { get; init; } = string.Empty;
        public bool NewerVersionAvailable { get; init; } = true;
    }
    internal class ServerVersionInformation
    {
        public string Version { get; set; } = "0.0.0";
    }
    internal class UpdateUtils
    {
        private readonly string serverRoot = "https://apps.trinkle.in/prstat";
        private readonly string zipName = "winprstat";
        private readonly string serverVersionFile = "latest.json";

        private HttpClient CreateClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "WinPRStat .Net 5 Update Client");
            return client;
        }

        private string GetVersionFileUrl()
        {
            return $"{serverRoot}/{serverVersionFile}";
        }
        private string GetZipFileUrl(ServerVersionInformation info)
        {
            return $"{serverRoot}/{zipName}_{info.Version}.zip";
        }

        private async Task<ServerVersionInformation> GetLatestServerVersionInformation()
        {
            var client = CreateClient();
            var response = await client.GetAsync(GetVersionFileUrl());
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await JsonSerializer.DeserializeAsync<ServerVersionInformation>(response.Content.ReadAsStream());
        }

        public async Task<UpdateInformation> CheckForUpdates(string currentVersion)
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
                ServerVersion = serverVersion.Version,
                ZipUrl = GetZipFileUrl(serverVersion),
                NewerVersionAvailable = serverVersion.Version.IsNewerVersionThan(currentVersion),
            };
        }
    }
}
