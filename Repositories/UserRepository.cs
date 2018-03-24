using System;
using System.Threading.Tasks;
using GitHubExplorer.Entities;
using Microsoft.Extensions.Options;
using RestSharp;

namespace GitHubExplorer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IRestClient _restClient;
        private readonly IOptions<Settings> _settings;

        public UserRepository(IRestClient restClient, IOptions<Settings> settings)
        {
            _restClient = restClient;
            _settings = settings;
        }

        public async Task<GitHubUser> Get(string userName)
        {
            _restClient.BaseUrl = new Uri(_settings.Value.GitHubBaseUrl);
            
            var restRequest = new RestRequest($"{_settings.Value.GitHubBaseUrl}users/{userName}", Method.GET);

            return (await _restClient.ExecuteTaskAsync<GitHubUser>(restRequest)).Data;
        }
    }
}
