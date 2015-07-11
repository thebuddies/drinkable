using Drinkable.Data.Contracts;
using Drinkable.Domain.Entities.Base;
using Drinkable.Domain.Repositories.Base;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Drinkable.Data.Repositories.Base
{
    public class GenericRepository<TEntity> : IRepository<TEntity, string>
         where TEntity : class, IEntity<string>
    {
        public GenericRepository(IMongoDbContext context)
        {
            this.MongoDbContext = context;
            this.MongoCollection = context.MongoDatabase.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        protected IMongoDbContext MongoDbContext { get; set; }

        protected IMongoCollection<TEntity> MongoCollection { get; set; }

        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            this.MongoCollection.InsertOneAsync(entity);
        }

        public TEntity Get(TEntity entity)
        {
            return this.GetById(entity.Id);
        }

        public TEntity GetById(string id)
        {
            return this.MongoCollection.Find(x => x.Id == id).ToListAsync().Result.FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.MongoCollection.Find(new BsonDocument()).ToListAsync().Result;
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

        public long Count()
        {
            return this.MongoCollection.CountAsync(new BsonDocument()).Result;
        }
    }
}