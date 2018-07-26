using EMLuiza.Domain.Entities;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class EmployeeResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public static explicit operator EmployeeResponse(Employee employee)
        {
            return new EmployeeResponse()
            {
                Id = employee.Id,
                Name = employee.ToString(),
                Email = employee.Email.Address,
                Department = employee.Department
            };
        }
    }
}
