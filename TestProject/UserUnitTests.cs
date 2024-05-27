using Entities;
using Moq;
using Moq.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{

    public class UserUnitTests
    {
        [Fact]
        public async Task TestLogin_Successful()
        {
            // Arrange
            var mockUserContext = new Mock<_214346710DbContext>();
            var users = new List<User>
            {
                new User { UserName = "testuser", Password = "password" }
            };

            mockUserContext.Setup(x => x.Users).ReturnsDbSet(users);

            var userRepository = new UserRepository(mockUserContext.Object);

            // Act
            var user = await userRepository.Login(new User { UserName = "testuser", Password = "password" });

            // Assert
            Assert.NotNull(user);
            Assert.Equal("testuser", user.UserName);
        }

        [Fact]
        public async Task TestLogin_Failed()
        {
            // Arrange
            var mockUserContext = new Mock<_214346710DbContext>();
            var users = new List<User>
        {
            new User { UserName = "testuser", Password = "password" }
        };

            mockUserContext.Setup(x => x.Users).ReturnsDbSet(users);

            var userService = new UserRepository(mockUserContext.Object);

            // Act
            var user = await userService.Login(new User { UserName = "testuser", Password = "wrongpassword" });

            // Assert
            Assert.Null(user);
        }
    }
}
