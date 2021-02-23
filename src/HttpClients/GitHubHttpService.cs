
using System.Net.Http;
using Newtonsoft.Json;

namespace RepoDetailsApi.HttpClients {

    public interface IGitHubHttpService{
        T GetResponse<T>(string projectName);
        string GetAppName(string userName, string projectName);

        dynamic GetLatestTag(string userName, string projectName);
    }
    public class GitHubHttpService : IGitHubHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseClientUrl = "https://api.github.com";
        public GitHubHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string GetAppName(string userName, string projectName)
        {
            var project = GetResponse<dynamic>($"/repos/{userName}/{projectName}");
            return project.name;
        }

        public dynamic GetLatestTag(string userName, string projectName)
        {
            var tags = GetResponse<dynamic>($"/repos/{userName}/{projectName}/tags");
            if (tags.Count > 0) {
                return new {
                    TagName = tags[0].name,
                    Sha =  tags[0].commit.sha
                };

            }
            else 
            return new {TagName = "", Sha = "" };
        }

        public T GetResponse<T>(string path)
        {
            var httpResult = _httpClient.GetAsync($"{_baseClientUrl}{path}").Result;
            httpResult.EnsureSuccessStatusCode();
            var response = httpResult.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(response);


        }
    }
} 