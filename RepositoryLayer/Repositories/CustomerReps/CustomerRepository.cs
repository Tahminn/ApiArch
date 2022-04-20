using DomainLayer.Entities.CustomerEntities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories.CustomerReps
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context) { }

    }
}
