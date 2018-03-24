using System.Threading.Tasks;
using GitHubExplorer.Entities;

namespace GitHubExplorer.Repositories
{
    public interface IUserRepository
    {
        Task<GitHubUser> Get(string userName);
    }
}
