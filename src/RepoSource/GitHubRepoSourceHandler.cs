using RepoDetailsApi.RepoSource;
using RepoDetailsApi.Models;
using RepoDetailsApi.HttpClients;
using System.Threading.Tasks;

namespace RepoDetailsApi.RepoSource
{
    /// <summary>
    /// CQRS command handler for Github Source Requests
    /// </summary>
    public class GitHubRepoSourceHandler : IRepoSourceHandler<GitHubPublicRepoDetailsQuery, GitHubPublicRepoDetailsResponse>
    {

        private IGitHubHttpService _gitHubHttpService;

        public GitHubRepoSourceHandler(IGitHubHttpService gitHubHttpService)
        {
            _gitHubHttpService = gitHubHttpService;
        }

        public  GitHubPublicRepoDetailsResponse GetRepoDetails(GitHubPublicRepoDetailsQuery query)
        {
            var response = new GitHubPublicRepoDetailsResponse();
            
            response.ProjectName = _gitHubHttpService.GetAppName(query.UserName, query.ProjectName);
            var tagInfo = _gitHubHttpService.GetLatestTag(query.UserName, query.ProjectName);
            response.Hash = tagInfo.Sha;
            response.TagName = tagInfo.TagName;

            return response;   
        }

    }
}