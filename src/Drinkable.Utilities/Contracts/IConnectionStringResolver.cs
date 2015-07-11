namespace Drinkable.Utilities.Contracts
{
    public interface IConnectionStringResolver
    {
        string Resolve(string name);
    }
}