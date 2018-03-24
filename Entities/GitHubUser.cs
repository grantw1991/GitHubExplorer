using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubExplorer.Entities
{
    public class GitHubUser
    {
        /*
         *{
  "login": "grantw1991",
  "id": 15818013,
  "avatar_url": "https://avatars2.githubusercontent.com/u/15818013?v=4",
  "gravatar_id": "",
  "url": "https://api.github.com/users/grantw1991",
  "html_url": "https://github.com/grantw1991",
  "followers_url": "https://api.github.com/users/grantw1991/followers",
  "following_url": "https://api.github.com/users/grantw1991/following{/other_user}",
  "gists_url": "https://api.github.com/users/grantw1991/gists{/gist_id}",
  "starred_url": "https://api.github.com/users/grantw1991/starred{/owner}{/repo}",
  "subscriptions_url": "https://api.github.com/users/grantw1991/subscriptions",
  "organizations_url": "https://api.github.com/users/grantw1991/orgs",
  "repos_url": "https://api.github.com/users/grantw1991/repos",
  "events_url": "https://api.github.com/users/grantw1991/events{/privacy}",
  "received_events_url": "https://api.github.com/users/grantw1991/received_events",
  "type": "User",
  "site_admin": false,
  "name": "Grant Wright",
  "company": "Beagle Street",
  "blog": "",
  "location": "Peterborough",
  "email": null,
  "hireable": null,
  "bio": "Software Engineer",
  "public_repos": 4,
  "public_gists": 0,
  "followers": 0,
  "following": 0,
  "created_at": "2015-11-12T14:20:36Z",
  "updated_at": "2017-10-10T11:00:20Z"
}
         *
         */

        public string AvatarUrl { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
    }
}
