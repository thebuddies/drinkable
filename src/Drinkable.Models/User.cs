using Drinkable.Models.Base;

namespace Drinkable.Models
{
    public class User : EntityBase<string>
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}