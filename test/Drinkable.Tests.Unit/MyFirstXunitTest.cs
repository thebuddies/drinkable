using Drinkable.Domain.Entities;
using Drinkable.Domain.Repositories;
using Drinkable.Tests.Unit.Factories;
using Drinkable.Tests.Unit.Mocks;
using System;
using Xunit;

namespace Drinkable.Tests.Unit
{
    public class MyFirstXunitTest
    {
        private IUserRepository<User, string> _userRepository;
        private UserFactory _userFactory;

        public MyFirstXunitTest()
        {
            _userRepository = new UserRepositoryMock();
            _userFactory = new UserFactory();
        }

        [Fact]
        public void Try_To_Create_New_User()
        {
            User user = new User();
            user.Id = Guid.NewGuid().ToString();

            Assert.IsType(typeof(User), user);
        }

        [Fact(Skip = "Its like [Ignore]")]
        public void Try_Sum_2_Numbers()
        {
            Assert.Equal(2, 1 + 1);
        }


        [Fact]
        public void Test_User_Factory()
        {
            User user1 = _userFactory.GetUser();
            User user2 = _userFactory.GetUser();

            Assert.NotEqual<User>(user1, user2);
            Assert.NotEqual(user1.Id, user2.Id);
            Assert.NotEqual(user1.Username, user2.Username);
            Assert.NotEqual(user1.FirstName, user2.FirstName);
            Assert.NotEqual(user1.LastName, user2.LastName);
            Assert.NotEqual(user1.Age, user2.Age);
        }

        [Fact]
        public void Try_To_Insert_User()
        {
            User user = _userFactory.GetUser();

            _userRepository.Add(user);

            var actualUser = _userRepository.GetById(user.Id);

            Assert.Equal(actualUser.Id, user.Id);
        }

        
    }
}