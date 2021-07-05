using System;
using System.Collections.Generic;
using DemoProject.Vote;

namespace DemoProject.Repository
{
    public class VoteRepository : IVoteRepository
    {
        public IList<Vote.Vote> Votes = new List<Vote.Vote>();
        
        public int Save(Vote.Vote vote)
        {
            if (Votes.Contains(vote))
            {
                throw new Exception("Vote duplicate exception");
            }
            Votes.Add(vote);
            return Votes.IndexOf(vote) + 1;
        }
        
        public int Save(List<Vote.Vote> votes)
        {
            foreach (var vote in votes)
            {
                Votes.Add(vote);
            }

            return votes.Count;
        }
    }
}