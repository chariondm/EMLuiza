using EMLuiza.Domain.Arguments;
using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Services.Base;
using System.Linq;

namespace EMLuiza.Domain.Interfaces.Services
{
    public interface IServiceEmployee : IServiceBase
    {
        AddEmployeeResponse Create(AddEmployeeRequest req);

        IQueryable<Employee> List();

        RemoveEmployeeResponse Remove(AddEmployeeRequest req);
    }
}
