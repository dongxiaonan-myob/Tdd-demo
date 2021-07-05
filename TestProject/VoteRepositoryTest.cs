using System;
using System.Collections.Generic;
using DemoProject.Repository;
using DemoProject.Vote;
using Xunit;

namespace TestProject
{
    public class VoteRepositoryTest
    {
        [Fact]
        public void ShouldSaveVoteSuccessfullyWhenNotExist()
        {
            var repo = new VoteRepository();
            var voteOne = new Vote() {PlayerId = 1, UserId = 1, CreatedAt = DateTime.Now};
            var voteId = repo.Save(voteOne);
            Assert.Equal(1, voteId);
        }
        
        [Fact]
        public void ShouldNotSaveVoteDuplicateWhenAlreadyExist()
        {
            var repo = new VoteRepository();
            var voteOne = new Vote() {PlayerId = 1, UserId = 1, CreatedAt = DateTime.Now};
            repo.Save(voteOne);
            Assert.Throws<Exception>(() => repo.Save(voteOne));
        }
        
        [Fact]
        public void ShouldSaveVoteListSuccessfully()
        {
            var repo = new VoteRepository();
            var vote = new Vote() {PlayerId = 1, UserId = 1, CreatedAt = DateTime.Now};
            var result = repo.Save(new List<Vote>(){vote});
            Assert.Equal(1, result);
        }
    }
}