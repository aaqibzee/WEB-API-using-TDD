using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WEB_API_using_TDD.Controllers;
using WEB_API_using_TDD.Models;
using WEB_API_using_TDD.Services;
using Xunit;

namespace Tests.Systems.Controllers
{
    public class TestUserController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            //Arrange
            var userService = new Mock<IUserService>();
            var userController = new UsersController(userService.Object);
            //Act
            var result =(OkObjectResult) await  userController.Get();

            //Assertion
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task Get_OnSuccess_InvokesUserService()
        {
            //Arrange
            var userService = new Mock<IUserService>();
            userService.Setup(x => x.GetAllUsers()).ReturnsAsync(It.IsAny<IEnumerable<User>>());
            var userController = new UsersController(userService.Object);

            //Act
            var result = await userController.Get();
            //Assertion
            userService.Verify(
                service=>service.GetAllUsers(),
                Times.Once
            );        
        }
    }
}
