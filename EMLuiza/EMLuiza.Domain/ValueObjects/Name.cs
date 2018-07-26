using EMLuiza.Domain.ValueObjects.Base;
using prmToolkit.NotificationPattern;

namespace EMLuiza.Domain.ValueObjects
{
    public class Name : ValueObjectBase
    {
        protected Name()
        {

        }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            new AddNotifications<Name>(this)
                .IfNullOrInvalidLength(FirstName, 3, 50, "Name.FirstName", "Invalid FirstName")
                .IfNullOrInvalidLength(LastName, 3, 50, "Name.LastName", "Invalid LastName");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
