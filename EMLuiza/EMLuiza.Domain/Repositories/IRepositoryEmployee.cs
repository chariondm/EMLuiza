using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Repositories.Base;
using System;

namespace EMLuiza.Domain.Repositories
{
    public interface IRepositoryEmployee : IRepositoryBase<Employee, Guid>
    {
    }
}
