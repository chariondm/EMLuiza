using EMLuiza.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EMLuiza.Infra.Persistence.Map
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("employee");

            Property(p => p.Email.Address)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(200)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(
                        new IndexAttribute("uk_employee_email")
                        {
                            IsUnique = true
                        })
                    );

            Property(p => p.Name.FirstName)
                .IsRequired()
                .HasColumnName("firstname")
                .HasMaxLength(50);

            Property(p => p.Name.LastName)
                .IsRequired()
                .HasColumnName("lastname")
                .HasMaxLength(50);

            Property(p => p.Department)
                .IsRequired()
                .HasColumnName("department")
                .HasMaxLength(50);
        }
    }
}
