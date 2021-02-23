namespace RepoDetailsApi.Models
{
    public interface IRepoDetailsResponse
    {
        public string ProjectName {get; set;}
        public string Hash {get; set;}
    }

}