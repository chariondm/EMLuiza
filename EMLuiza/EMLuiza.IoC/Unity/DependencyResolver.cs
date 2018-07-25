using EMLuiza.Domain.Interfaces.Repositories;
using EMLuiza.Domain.Interfaces.Repositories.Base;
using EMLuiza.Domain.Interfaces.Services;
using EMLuiza.Domain.Services;
using EMLuiza.Infra.Persistence;
using EMLuiza.Infra.Persistence.Repositories;
using EMLuiza.Infra.Persistence.Repositories.Base;
using EMLuiza.Infra.Transactions;
using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System.Data.Entity;

namespace EMLuiza.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DbContext, EMLuizaContext>(new HierarchicalLifetimeManager());

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            container.RegisterType<IServiceEmployee, ServiceEmployee>(new HierarchicalLifetimeManager());

            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryEmployee, RepositoryEmployee>(new HierarchicalLifetimeManager());
        }
    }
}
