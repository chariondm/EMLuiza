using EMLuiza.Domain.Entities.Base;
using EMLuiza.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using System.Threading.Tasks;

namespace EMLuiza.Infra.Persistence.Repositories.Base
{
    public class RepositoryBase<TEntity, TId> : IRepositoryBase<TEntity, TId>
        where TEntity : EntityBase
        where TId : struct
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public TEntity Create(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity);
        }

        public IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (includeProperties.Any())
            {
                return Include(_context.Set<TEntity>(), includeProperties);
            }

            return query;
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        private IQueryable<TEntity> Include(IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            return query;
        }
    }
}
