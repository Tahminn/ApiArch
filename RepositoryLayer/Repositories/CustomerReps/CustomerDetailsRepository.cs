using DomainLayer.Entities.CustomerEntities;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.CustomerReps
{
    public class CustomerDetailsRepository : Repository<CustomerDetails>, ICustomerDetailsRepository
    {
        public CustomerDetailsRepository(AppDbContext context) : base(context) { }
    }
}
