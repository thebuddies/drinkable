namespace Drinkable.Domain.Repositories
{
    public interface IUserRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
    }
}