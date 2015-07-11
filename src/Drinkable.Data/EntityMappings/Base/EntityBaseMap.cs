using Drinkable.Domain.Entities.Base;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Drinkable.Data.EntityMappings.Base
{
    public class EntityBaseMap : MongoDbClassMapperBase<EntityBase<string>>
    {
        public override void Map(BsonClassMap<EntityBase<string>> classMap)
        {
            classMap.AutoMap();
            classMap.SetIdMember(classMap.GetMemberMap(x => x.Id)
                  .SetIdGenerator(StringObjectIdGenerator.Instance));
        }
    }
}