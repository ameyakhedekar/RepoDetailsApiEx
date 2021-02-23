namespace RepoDetailsApi.Models
{
    public class GitHubPublicRepoDetailsResponse : IRepoDetailsResponse
    {
        public string ProjectName { get ; set ; }
        public string Hash { get ; set ; }

        public string TagName { get ; set ; }
    }

}