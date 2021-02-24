using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoDetailsApi.RepoSource;
using RepoDetailsApi.Models;

namespace RepoDetailsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("Health")]

    public class GitHubRepoDetailsController : ControllerBase
    {

        private readonly ILogger<GitHubRepoDetailsController> _logger;
        private IRepoSourceHandler<GitHubPublicRepoDetailsQuery, GitHubPublicRepoDetailsResponse> _gitHubSourceHandler;

        public GitHubRepoDetailsController(ILogger<GitHubRepoDetailsController> logger,
             IRepoSourceHandler<GitHubPublicRepoDetailsQuery, GitHubPublicRepoDetailsResponse> gitHubSourceHandler )
        {
            _logger = logger;
            _gitHubSourceHandler = gitHubSourceHandler;
        }

        [HttpGet]        
        public IActionResult GetRepoDetails(){
            var response = _gitHubSourceHandler.GetRepoDetails(new GitHubPublicRepoDetailsQuery()
            {
                ProjectName = "RepoDetailsApiEx",
                UserName = "ameyakhedekar"
            });

            return Ok(response);
        }

    }
} 