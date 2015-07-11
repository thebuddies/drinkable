using Drinkable.Domain.Entities.Base;
using Drinkable.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkable.Tests.Unit.Mocks.Base
{
    internal class RepositoryMockBase<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IComparable<TKey>
    {
        private static readonly HashSet<TEntity> _data = new HashSet<TEntity>();

        public IQueryable<TEntity> Query()
        {
            return _data.AsQueryable();
        }

        public void Add(TEntity entity)
        {
            _data.Add(entity);
        }

        public TEntity Get(TEntity entity)
        {
            return _data.FirstOrDefault(x => x.Id.Equals(entity.Id));
        }

        public TEntity GetById(TKey id)
        {
            return _data.FirstOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _data;
        }

        public void Update(TEntity entity)
        {
            _data.Remove(entity);
            _data.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _data.Remove(entity);
        }

        public void DeleteById(TKey id)
        {
            _data.RemoveWhere(x => x.Id.Equals(id));
        }
    }
}