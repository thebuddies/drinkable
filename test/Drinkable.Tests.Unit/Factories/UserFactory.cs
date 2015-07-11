using Drinkable.Domain.Entities;
using System;

namespace Drinkable.Tests.Unit.Factories
{
    internal class UserFactory
    {
        private static int factoryNumber = 0;

        public User GetUser()
        {
            factoryNumber++;
            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                Username = "tester_" + factoryNumber,
                FirstName = "Fname_" + factoryNumber,
                LastName = "Lname_" + factoryNumber,
                Age = factoryNumber
            };

            return user;
        }
    }
}