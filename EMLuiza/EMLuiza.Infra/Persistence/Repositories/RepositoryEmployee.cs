using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Repositories;
using EMLuiza.Infra.Persistence.Repositories.Base;
using System;

namespace EMLuiza.Infra.Persistence.Repositories
{
    public class RepositoryEmployee : RepositoryBase<Employee, Guid>, IRepositoryEmployee
    {
        protected readonly EMLuizaContext _context;

        public RepositoryEmployee(EMLuizaContext context) : base(context)
        {
            _context = context;
        }
    }
}
