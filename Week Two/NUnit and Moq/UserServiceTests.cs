using NUnit.Framework;
using Moq;
using MyApp.Services;


namespace MyApp.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<IUserRepository> _mockRepo;
        private UserService _userService;


        [SetUp]
        public void SetUp()
        {
            _mockRepo = new Mock<IUserRepository>();
            _userService = new UserService(_mockRepo.Object);
        }


        [Test]
        public void GetUserName_UserExists_ReturnsUserName()
        {
            // Arrange
            var userId = 1;
            _mockRepo.Setup(r => r.GetUserById(userId))
                     .Returns(new User { Id = userId, Name = "Alice" });


            // Act
            var result = _userService.GetUserName(userId);


            // Assert
            Assert.AreEqual("Alice", result);
        }

        [Test]
        public void GetUserName_UserDoesNotExist_ReturnsUnknownUser()
        {
            // Arrange
            var userId = 2;
            _mockRepo.Setup(r => r.GetUserById(userId))
                     .Returns((User)null);


            // Act
            var result = _userService.GetUserName(userId);


            // Assert
            Assert.AreEqual("Unknown User", result);
        }
    }
}
