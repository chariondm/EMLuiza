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
        public AddEmployeeRequest(string firstName, string lastName, string email, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Department { get; private set; }
    }
}
