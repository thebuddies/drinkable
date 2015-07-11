using MongoDB.Bson.Serialization;

namespace Drinkable.Data.EntityMappings.Base
{
    public abstract class MongoDbClassMapperBase<TEntity>
    {
        public MongoDbClassMapperBase()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(TEntity)))
            {
                BsonClassMap.RegisterClassMap<TEntity>(Map);
            }
        }

        public abstract void Map(BsonClassMap<TEntity> classMap);
    }
}