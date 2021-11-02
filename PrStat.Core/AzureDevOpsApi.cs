using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrStat.Core
{
    public class AzureDevOpsApi
    {
        private readonly HttpClient httpClient;

        private readonly string apiVersionQueryString = "api-version=6.0";
        public AzureDevOpsApi()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "PRStat .Net 5 Windows Client");
        }

        private AuthenticationHeaderValue GetAuthHeader(Config config)
        {
            var creds = $"{config.Username}:{config.AccessToken}";
            var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(creds));
            return new AuthenticationHeaderValue("Basic", auth);
        }

        public async Task<IList<PullRequest>> GetPullRequests(Config config)
        {
            var url = $"https://dev.azure.com/{config.Organization}/{config.Project}/_apis/git/pullrequests?{apiVersionQueryString}";

            return await FetchPullRequests(url, config);
        }
        private async Task<IList<PullRequest>> FetchPullRequests(string url, Config config)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "PRStat .Net 5 Windows Client");
            httpClient.DefaultRequestHeaders.Authorization = GetAuthHeader(config);
            var dto = await JsonSerializer.DeserializeAsync<PullRequestsResponseDto>(await httpClient.GetStreamAsync(url));
            return dto.PullRequests.Select(prDto =>
            {
                var pr = new PullRequest
                {
                    NeedsReview = true,
                    Description = prDto.Description,
                    Title = prDto.Title,
                    Id = prDto.Id,
                    Reviewers = prDto.Reviewers,
                    Author = prDto.Author,
                    Url = $"https://dev.azure.com/{config.Organization}/{config.Project}/_git/{prDto.Repository.Name}/pullrequest/{prDto.Id}"
                };

                return pr;

            }).ToList();
        }
        public async Task<IList<PullRequest>> GetPullRequestListForReviewers(Config config)
        {
            var urls = from id in config.ReviewerIds
                       select $"https://dev.azure.com/{config.Organization}/{config.Project}/_apis/git/pullrequests?searchCriteria.reviewerId={id}&{apiVersionQueryString}";

            
            var pullRequests = new List<PullRequest>();
            foreach (var url in urls)
            {
                var prs = (await FetchPullRequests(url, config))
                    .Where(pr => pr.Reviewers.Any(r => config.ReviewerIds.Contains(r.Id)))
                    .Select(pr =>
                    {
                        pr.NeedsReview = pr.Reviewers.Any(r => r.RequiresReview && config.ReviewerIds.Contains(r.Id));
                        return pr;
                    });
                pullRequests.AddRange(prs);
            }

            return pullRequests.GroupBy(pr => pr.Id).Select(g => g.First()).ToList();
        }

    }
}
