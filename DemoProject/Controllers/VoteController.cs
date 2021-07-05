using DemoProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoteController : ControllerBase
    {
        public readonly IVoteService VoteService;

        public VoteController(IVoteService voteService)
        {
            this.VoteService = voteService;
        }
        
        [HttpPost]
        public int Save(Vote.Vote vote)
        {
            return VoteService.Save(vote);
        }
    }
}