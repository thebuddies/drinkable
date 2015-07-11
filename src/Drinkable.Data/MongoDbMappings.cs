using Drinkable.Data.EntityMappings.Base;
using System;
using System.Linq;
using System.Reflection;

namespace Drinkable.Data
{
    public class MongoDbMappings
    {
        public void InitialiseMappings()
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