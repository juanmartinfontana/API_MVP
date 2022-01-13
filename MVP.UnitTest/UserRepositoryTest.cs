using Moq;
using MVP.Core.Entities;
using MVP.Core.Interfaces;
using MVP.Core.Services;
using System.Threading.Tasks;
using Xunit;

namespace MVP.UnitTest
{
    public class UserRepositoryTest
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;

        public UserRepositoryTest()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
        }

        [Fact]
        public async Task UpdateUser_WhenUpdateUserSuccessfully_ShouldReturnExpectedResult()
        {
            _userRepositoryMock
                .Setup(x => x.UpdateUser(It.IsAny<int>()))
                .ReturnsAsync(true);
            var sust = new UserServices(_userRepositoryMock.Object);
            var result = await sust.UpdateUser(10);

            Assert.True(result);
        }

        [Fact]
        public async Task DeleteUser_WhenDeleteUserSuccessfully_ShouldReturnExpectedResult()
        {
            _userRepositoryMock
                .Setup(x => x.DeleteUser(It.IsAny<int>()))
                .ReturnsAsync(true);
            var sust = new UserServices(_userRepositoryMock.Object);
            var result = await sust.DeleteUser(10);

            Assert.True(result);
        }


        [Fact]
        public async Task AddUser_WhenAddUserSuccessfully_ShouldReturnExpectedResult()
        {
            var newUser = new User();
            _userRepositoryMock
                .Setup(x => x.AddUser(It.IsAny<User>()))
                .ReturnsAsync(true);
            var sust = new UserServices(_userRepositoryMock.Object);
            var result = await sust.AddUser(newUser);

            Assert.True(result);
        }

    }
}
