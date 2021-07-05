using DemoProject.Repository;
using DemoProject.Vote;

namespace DemoProject.Services
{
    public class VoteService : IVoteService
    {
        public IVoteRepository VoteRepository { get; set; }
        public VoteService(IVoteRepository voteRepository)
        {
            this.VoteRepository = voteRepository;
        }

        public int Save(Vote.Vote vote)
        {
            return VoteRepository.Save(vote);
        }
    }
}