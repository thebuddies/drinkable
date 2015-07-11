using Drinkable.Domain.Entities.Base;

namespace Drinkable.Domain.Entities
{
    public class User : EntityBase<string>
    {
        public virtual string Username { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual int Age { get; set; }
    }
}