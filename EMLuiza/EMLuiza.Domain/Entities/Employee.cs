using EMLuiza.Domain.Entities.Base;
using EMLuiza.Domain.ValueObjects;

namespace EMLuiza.Domain.Entities
{
    class Employee : EntityBase
    {
        public Employee(Name name, Email email, string department)
        {
            Name = name;
            Email = email;
            Department = department;
            
            AddNotifications(name, email);
        }

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public string Department { get; private set; }
    }
}
