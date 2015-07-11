using Drinkable.Data;
using Drinkable.Data.Repositories;
using Drinkable.Domain.Entities;
using Drinkable.Domain.Repositories;
using System.Threading;
using Xunit;
using System.Linq;

namespace Drinkable.Tests.Integration
{
    public class MyFirstIntegrationTest
    {
        private IUserRepository<User, string> _userRepository;

        public MyFirstIntegrationTest()
        {
            _userRepository = new UserRepository(new MongoDbContext());
        }

        [Fact]
        public void Try_To_Insert_User_Into_MongoDb()
        {
            var user = new User
            {
                Username = "tester"
            };

            _userRepository.Add(user);

            Thread.Sleep(1000);

            User actualUser = _userRepository.Get(user);

            Assert.Equal(user.Id, actualUser.Id);
        }

        [Fact]
        public void Try_To_Get_All_Users()
        {
            var users = _userRepository.GetAll();

            var usersCount = _userRepository.Count();

            Assert.Equal(users.Count(), usersCount);
        }
    }
}