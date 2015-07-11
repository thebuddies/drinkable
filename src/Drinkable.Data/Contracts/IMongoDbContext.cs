using MongoDB.Driver;

namespace Drinkable.Data.Contracts
{
    public interface IMongoDbContext
    {
        IMongoDatabase MongoDatabase { get; set; }
    }
}