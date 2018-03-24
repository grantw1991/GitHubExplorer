using System.Threading.Tasks;
using GitHubExplorer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GitHubExplorer.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{userName}")]
        public async Task<IActionResult> GetUser(string userName)
        {
            return Ok(await _repository.Get(userName));
        }
    }
}
