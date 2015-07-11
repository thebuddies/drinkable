using System;

namespace Drinkable.Domain.Entities.Base
{
    public interface IEntity<TKey>
        where TKey : IComparable<TKey>
    {
        TKey Id { get; set; }
    }
}