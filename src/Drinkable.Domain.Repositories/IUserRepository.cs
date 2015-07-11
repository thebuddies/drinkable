using Drinkable.Domain.Entities.Base;
using Drinkable.Domain.Repositories.Base;
using System;

namespace Drinkable.Domain.Repositories
{
    public interface IUserRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable<TKey>
    {
    }
}