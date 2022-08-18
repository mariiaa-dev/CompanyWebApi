using CompanyWebApi.Domains.Models;

namespace CompanyWebApi.Persistance.Contexts.Configuration
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Position");

            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
