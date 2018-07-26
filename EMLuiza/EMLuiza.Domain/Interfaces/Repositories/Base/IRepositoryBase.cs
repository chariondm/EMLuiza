using System;
using System.Linq;
using System.Linq.Expressions;

namespace EMLuiza.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity, TId>
       where TEntity : class
       where TId : struct
    {
        TEntity GetById(TId id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity Create(TEntity entity);

        IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] includeProperties);

        void Remove(TEntity entity);
    }
}
