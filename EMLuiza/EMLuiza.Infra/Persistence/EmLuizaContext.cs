using EMLuiza.Domain.Entities;
using EMLuiza.Infra.Persistence.Map;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EMLuiza.Infra.Persistence
{
    public class EMLuizaContext : DbContext
    {
        public EMLuizaContext() : base("dbEMLuiza")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new EmployeeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
