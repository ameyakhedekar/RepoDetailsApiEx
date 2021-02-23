using RepoDetailsApi.Models;
using System.Threading.Tasks;

namespace RepoDetailsApi.RepoSource
{
    public interface IRepoSourceHandler<IRepoDetailsQuery, IRepoDetailsResponse>
    {
        public IRepoDetailsResponse GetRepoDetails(IRepoDetailsQuery IRepoDetailsQuery);
    }
    
}