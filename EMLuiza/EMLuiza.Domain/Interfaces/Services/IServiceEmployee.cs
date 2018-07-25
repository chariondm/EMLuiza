using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Services.Base;
using System.Linq;

namespace EMLuiza.Domain.Interfaces.Services
{
    public interface IServiceEmployee : IServiceBase
    {
        void Create(Employee employee);

        IQueryable<Employee> List();

        void Remove(Employee employee);
    }
}
