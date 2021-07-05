using System;
using DemoProject.Controllers;
using DemoProject.Services;
using DemoProject.Vote;
using NSubstitute;
using Xunit;

namespace TestProject
{
    public class VoteControllerTest
    {
        [Fact]
        public void ShouldReturnOkWhenPayloadValid()
        {
            var mockService = Substitute.For<IVoteService>();
            mockService.Save(Arg.Any<Vote>()).Returns(3);
            var controller = new VoteController(mockService);
            var result = controller.Save(new Vote(){PlayerId = 3, UserId = 1, CreatedAt = DateTime.Now});
            
            Assert.Equal(3, result);
        }
    }
}