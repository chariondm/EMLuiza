using EMLuiza.Domain.Entities;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class EmployeeResponse
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public static explicit operator EmployeeResponse(Employee employee)
        {
            return new EmployeeResponse()
            {
                Id = employee.Id,
                FullName = employee.ToString(),
                FirstName = employee.Name.FirstName,
                LastName = employee.Name.LastName,
                Email = employee.Email.Address,
                Department = employee.Department
            };
        }
    }
}
