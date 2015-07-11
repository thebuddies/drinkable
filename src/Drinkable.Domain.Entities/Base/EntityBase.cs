using System;

namespace Drinkable.Domain.Entities.Base
{
    public abstract class EntityBase<TKey> : IEntity<TKey>
        where TKey : IComparable<TKey>
    {
        public TKey Id { get; set; }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override bool Equals(object entity)
        {
            return entity != null
                && entity is EntityBase<TKey>
                && this == (EntityBase<TKey>)entity;
        }
    }
}