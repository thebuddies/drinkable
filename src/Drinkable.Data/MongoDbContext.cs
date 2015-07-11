using Drinkable.Data.Contracts;
using Drinkable.Domain.Entities;
using MongoDB.Driver;

namespace Drinkable.Data
{
    public class MongoDbContext : IMongoDbContext
    {
        public MongoDbContext()
        {

        }

        public IMongoDatabase MongoDatabase { get; set; }

        public IMongoCollection<User> Users { get; set; }
    }
}