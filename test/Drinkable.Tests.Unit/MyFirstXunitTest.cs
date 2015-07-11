using Drinkable.Domain.Entities;
using Drinkable.Domain.Repositories;
using Drinkable.Tests.Unit.Mocks;
using System;
using Xunit;

namespace Drinkable.Tests.Unit
{
    public class MyFirstXunitTest
    {
        private IUserRepository<User, string> _userRepository;

        public MyFirstXunitTest()
        {
            _userRepository = new UserRepositoryMock();
        }

        [Fact]
        public void Try_To_Create_New_User()
        {
            User user = new User();
            user.Id = Guid.NewGuid().ToString();

            Assert.IsType(typeof(User), user);
        }

        [Fact(Skip = "Its like Ignore")]
        public void Try_Sum_2_Numbers()
        {
            Assert.Equal(2, 1 + 1);
        }

        [Fact]
        public void Try_To_Insert_User()
        {
            User user = new User();
            user.Id = Guid.NewGuid().ToString();

            _userRepository.Add(user);

            var actualUser = _userRepository.GetById(user.Id);

            Assert.Equal(actualUser.Id, user.Id);
        }
    }
}