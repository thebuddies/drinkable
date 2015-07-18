using Drinkable.Infrastructure.Contracts;
using Drinkable.Infrastructure.EntityMappings.Base;
using System;
using System.Linq;
using System.Reflection;

namespace Drinkable.Infrastructure.EntityMappings
{
    public class MongoDbClassMapper : IMongoDbClassMapper
    {
        public void InitializeMappings()
        {
            var assembly = Assembly.GetAssembly(typeof(EntityBaseMap));

            var classMaps = assembly
                .GetTypes()
                .Where(t => t.BaseType != null && t.BaseType.IsGenericType &&
                            t.BaseType.GetGenericTypeDefinition() == typeof(MongoDbClassMapperBase<>));

            foreach (var classMap in classMaps)
            {
                Activator.CreateInstance(classMap);
            }
        }
    }
}