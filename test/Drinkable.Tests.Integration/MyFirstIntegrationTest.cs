using Drinkable.Domain.Entities;
using Drinkable.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Drinkable.Tests.Integration
{
    public class MyFirstIntegrationTest
    {
        private IUserRepository<User, string> _userRepository;

        [Fact]
        public void Try_To_Insert_User_Into_MongoDb()
        {

        }
    }
}
