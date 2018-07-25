using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System;
using System.Linq;

namespace EMLuiza.Domain.Services
{
    public class ServiceEmployee : Notifiable, IServiceEmployee
    {
        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> List()
        {
            throw new NotImplementedException();
        }

        public void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
