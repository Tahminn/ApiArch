using DomainLayer.Entities.CustomerEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DomainLayer.Configurations.CustomerConfigurations
{
    public class CustomerDetailsConfiguration : IEntityTypeConfiguration<CustomerDetails>
    {
        public void Configure(EntityTypeBuilder<CustomerDetails> builder)
        {
            builder.Property(c => c.Address).IsRequired().HasMaxLength(200);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Mail).IsRequired().HasMaxLength(200);
            builder.Property(c => c.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
