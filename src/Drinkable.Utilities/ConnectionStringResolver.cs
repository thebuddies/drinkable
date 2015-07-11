using Drinkable.Utilities.Contracts;
using System.Configuration;

namespace Drinkable.Utilities
{
    public class ConnectionStringResolver : IConnectionStringResolver
    {
        public string Resolve(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}