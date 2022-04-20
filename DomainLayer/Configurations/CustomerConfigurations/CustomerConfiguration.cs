using DomainLayer.Entities.CustomerEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations.CustomerConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Age).IsRequired();
            builder.Property(c => c.SoftDelete).HasDefaultValue(false);
        }
    }
}
