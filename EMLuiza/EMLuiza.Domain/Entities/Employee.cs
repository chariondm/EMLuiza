using EMLuiza.Domain.Entities.Base;

namespace EMLuiza.Domain.Entities
{
    class Employee : EntityBase
    {
        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Department { get; private set; }
    }
}
