using Drinkable.Data.Contracts;
using Drinkable.Data.Repositories.Base;
using Drinkable.Domain.Entities;
using Drinkable.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkable.Data.Repositories
{
    public class UserRepository : MongoDbRepository<User>, IUserRepository<User, string>
    {
        public UserRepository(IMongoDbContext context)
            : base(context)
        {

        }
    }
}
