using DomainLayer.Configurations.CustomerConfigurations;
using DomainLayer.Entities.CustomerEntities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Configurations

            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new CustomerDetailsConfiguration());

            #endregion

            base.OnModelCreating(builder);

            #region FluentAPIConfig

            builder.Entity<Customer>()
                .HasOne<CustomerDetails>(c => c.CustomerDetails)
                .WithOne(cd => cd.Customer)
                .HasForeignKey<CustomerDetails>(cd => cd.CustomerId);

            #endregion
        }

    }
}
