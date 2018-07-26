using EMLuiza.Domain.Interfaces.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLuiza.Domain.Arguments
{
    public class AddEmployeeRequest : IRequest
    {
        private string _firstName, _lastName;

        public AddEmployeeRequest(string name, string email, string department)
        {
            _firstName = name.Split(' ')[0];
            _lastName = string.Join(" ", name.Split(' ').Skip(1));
            Name = name;
            Email = email;
            Department = department;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Department { get; private set; }

        public string FirstName()
        {
            return _firstName;
        }

        public string LastName()
        {
            return _lastName;
        }
    }
}
