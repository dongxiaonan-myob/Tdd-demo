using System;
using System.Collections.Generic;
using DemoProject.Repository;
using DemoProject.Services;
using DemoProject.Vote;
using NSubstitute;
using Xunit;

namespace TestProject
{
    public class VoteServiceTest
    {
        [Fact]
        public void ShouldSaveVoteSuccessfullyWhenNotExist()
        {
            var mockRepo = Substitute.For<IVoteRepository>();
            mockRepo.Save(Arg.Any<Vote>()).Returns(2);
            var service = new VoteService(mockRepo);
            
            var voteOne = new Vote() {PlayerId = 1, UserId = 1, CreatedAt = DateTime.Now};
            var voteId = service.Save(voteOne);
            Assert.Equal(2, voteId);
        }
    }
}