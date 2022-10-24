using System;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WEB_API_using_TDD.Controllers;
using Xunit;

namespace Tests.Systems.Controllers
{
    public class TestUserController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200_()
        {
            //Arrange
            var userController = new UsersController();
            //Act
            var result =(OkObjectResult) await  userController.Get();

            //Assertion
            result.StatusCode.Should().Be(200);
        }
    }
}
