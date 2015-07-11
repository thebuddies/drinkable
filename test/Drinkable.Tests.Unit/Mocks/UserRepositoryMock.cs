using Drinkable.Domain.Entities;
using Drinkable.Domain.Repositories;
using Drinkable.Tests.Unit.Mocks.Base;

namespace Drinkable.Tests.Unit.Mocks
{
    internal class UserRepositoryMock : RepositoryMockBase<User, string>, IUserRepository<User, string>
    {
    }
}