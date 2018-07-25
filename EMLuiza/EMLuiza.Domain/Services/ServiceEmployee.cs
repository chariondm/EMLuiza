using EMLuiza.Domain.Arguments;
using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Repositories;
using EMLuiza.Domain.Interfaces.Services;
using EMLuiza.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;
using System.Linq;

namespace EMLuiza.Domain.Services
{
    public class ServiceEmployee : Notifiable, IServiceEmployee
    {
        private readonly IRepositoryEmployee _repositoryEmployee;

        public ServiceEmployee(IRepositoryEmployee repositoryEmployee)
        {
            _repositoryEmployee = repositoryEmployee;
        }

        public AddEmployeeResponse Create(AddEmployeeRequest req)
        {
            var name = new Name(req.FirstName, req.LastName);
            var email = new Email(req.Email);

            var employee = new Employee(name, email, req.Department);

            AddNotifications(name, email);

            if (IsInvalid())
            {
                return null;
            }

            employee = _repositoryEmployee.Create(employee);

            return (AddEmployeeResponse)employee;
        }

        public IQueryable<Employee> List()
        {
            throw new NotImplementedException();
        }

        public RemoveEmployeeResponse Remove(AddEmployeeRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
