using CompanyWebApi.Domains.Models;

namespace CompanyWebApi.Persistance.Contexts.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.HasIndex(p => p.DirectorId).IsUnique();

            builder.Property(p => p.MounthlyBudget).IsRequired().HasDefaultValue(500000);
            builder.HasCheckConstraint("CH_Company_MounthlyBudget_IsPositiveNumber", 
                "[MounthlyBudget] > 0");
        }
    }
}
