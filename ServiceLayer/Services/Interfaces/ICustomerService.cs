using ServiceLayer.DTOs.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerListDto>> GetAllAsync();
        Task CreateAsync(CustomerListDto customerList);
    }
}
