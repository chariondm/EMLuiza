using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Repositories.Base;
using System;

namespace EMLuiza.Domain.Interfaces.Repositories
{
    public interface IRepositoryEmployee : IRepositoryBase<Employee, Guid>
    {
    }
}
