using Drinkable.Infrastructure.EntityMappings.Base;
using Drinkable.Domain.Entities;
using MongoDB.Bson.Serialization;

namespace Drinkable.Infrastructure.EntityMappings
{
    public class UserMap : MongoDbClassMapperBase<User>
    {
        public override void Map(BsonClassMap<User> classMap)
        {
            classMap.AutoMap();
        }
    }
}