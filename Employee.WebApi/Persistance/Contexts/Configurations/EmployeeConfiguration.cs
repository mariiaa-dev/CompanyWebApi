using CompanyWebApi.Domeins.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyWebApi.Persistance.Contexts.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.HasIndex(p=>p.Mail).IsUnique();
            builder.HasCheckConstraint("CH_Employee_Salary_IsPositiveNumber", "[Salary] > 0");

            builder.HasOne(p => p.Position).WithMany(p => p.Employees)
                .HasForeignKey(p => p.PositionId);

            builder.HasOne(p => p.Company).WithMany(p => p.Employees)
                .HasForeignKey(p => p.CompanyId);
        }
    }
}
