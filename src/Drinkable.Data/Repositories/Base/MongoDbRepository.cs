using Drinkable.Data.Contracts;
using Drinkable.Domain.Entities.Base;
using Drinkable.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Drinkable.Data.Repositories.Base
{
    public class MongoDbRepository<TEntity> : IRepository<TEntity, string>
         where TEntity : class, IEntity<string>
    {
        public MongoDbRepository(IMongoDbContext context)
        {
            this.MongoDbContext = context;
        }

        protected IMongoDbContext MongoDbContext { get; set; }

        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}