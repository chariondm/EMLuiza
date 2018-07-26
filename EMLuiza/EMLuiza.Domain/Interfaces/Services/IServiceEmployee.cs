using EMLuiza.Domain.Arguments;
using EMLuiza.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace EMLuiza.Domain.Interfaces.Services
{
    public interface IServiceEmployee : IServiceBase
    {
        AddEmployeeResponse Create(AddEmployeeRequest req);

        IEnumerable<EmployeeResponse> List(int takeCount, int takePage);

        RemoveEmployeeResponse Remove(Guid id);
    }
}
