namespace RepoDetailsApi.Models
{
    public class GitHubPublicRepoDetailsQuery : IRepoDetailsQuery
    {
        public string ProjectName { get ; set ; }
        public string UserName { get ; set ; }
    }

}