using Drinkable.Data.Contracts;
using Drinkable.Utilities;
using MongoDB.Driver;

namespace Drinkable.Data
{
    public class MongoDbContext : IMongoDbContext
    {
        public MongoDbContext()
        {
            var connectionStringResolver = new ConnectionStringResolver();
            string connectionString = connectionStringResolver.Resolve("Drinkable.Local");

            var mongoDbMappings = new MongoDbMappings();
            mongoDbMappings.InitialiseMappings();

            IMongoClient client = new MongoClient(connectionString);
            MongoDatabase = client.GetDatabase("test");
        }

        public IMongoDatabase MongoDatabase { get; set; }
    }
}