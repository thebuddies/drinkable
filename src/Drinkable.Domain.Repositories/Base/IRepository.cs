using Drinkable.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Drinkable.Domain.Repositories.Base
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable<TKey>
    {
        IQueryable<TEntity> Query();

        void Add(TEntity entity);

        TEntity Get(TEntity entity);

        TEntity GetById(TKey id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void DeleteById(TKey id);
    }
}