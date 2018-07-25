using EMLuiza.Domain.ValueObjects.Base;
using prmToolkit.NotificationPattern;

namespace EMLuiza.Domain.ValueObjects
{
    public class Email : ValueObjectBase
    {
        public Email(string address)
        {
            Address = address;

            new AddNotifications<Email>(this)
                .IfNotEmail(Address, "Email.Address", "E-mail invalid");
        }

        public string Address { get; private set; }
    }
}
