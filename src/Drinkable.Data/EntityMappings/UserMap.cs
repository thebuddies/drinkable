using Drinkable.Data.EntityMappings.Base;
using Drinkable.Domain.Entities;
using MongoDB.Bson.Serialization;

namespace Drinkable.Data.EntityMappings
{
    public class UserMap : MongoDbClassMapperBase<User>
    {
        public override void Map(BsonClassMap<User> classMap)
        {
            classMap.AutoMap();
        }
    }
}