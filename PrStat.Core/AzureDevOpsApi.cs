﻿using System;
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
        private readonly string apiVersionQueryString = "api-version=6.0";
        private readonly int maxRetryCount = 3;

        private HttpClient httpClient;

        public AzureDevOpsApi()
        {
            httpClient = CreateHttpClient();
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "PRStat .Net 5 Windows Client");
            return client;
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

        private async Task<HttpResponseMessage> GetWithRetry(string url, Config config, int retryCount = 0)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "PRStat .Net 5 Windows Client");
            httpClient.DefaultRequestHeaders.Authorization = GetAuthHeader(config);
            HttpResponseMessage resp;

            try
            {
                resp = await httpClient.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            }
            catch (TaskCanceledException ex)
            {
                return await HandleRetry(url, config, retryCount, ex);
            }

            if (resp.StatusCode != System.Net.HttpStatusCode.OK)
            {
                if (resp.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    httpClient = CreateHttpClient();
                }
                return await HandleRetry(url, config, retryCount);
            }

            return resp;

            async Task<HttpResponseMessage> HandleRetry(string url, Config config, int retryCount, Exception ex = null)
            {
                if (retryCount < maxRetryCount)
                {
                    return await GetWithRetry(url, config, retryCount + 1);
                }
                else
                {
                    httpClient = CreateHttpClient();
                    throw new HttpRequestException("Retry limit exceeded.", inner:ex);
                }
            }
        }

        private async Task<IList<PullRequest>> FetchPullRequests(string url, Config config)
        {
            var resp = await GetWithRetry(url, config);
            
            var dto = await JsonSerializer.DeserializeAsync<PullRequestsResponseDto>(resp.Content.ReadAsStream());
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
