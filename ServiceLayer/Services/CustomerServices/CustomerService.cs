using AutoMapper;
using DomainLayer.Entities.CustomerEntities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Customer;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerDetailsRepository _customerDetailsRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository,
                               IMapper mapper,
         ICustomerDetailsRepository customerDetailsRepository)
        {
            _customerRepository = repository;
            _mapper = mapper;
            _customerDetailsRepository = customerDetailsRepository;
        }

        public async Task<List<CustomerListDto>> GetAllAsync()
        {
            var model = await _customerRepository.GetAllAsync();

            var model2 = await _customerDetailsRepository.GetAllAsync();

            var mappedData = _mapper.Map<List<CustomerListDto>>(model);

            //_mapper.Map(model2, mappedData);

            return mappedData;
        }

        public async Task CreateAsync(CustomerListDto customerList)
        {
            var entity = _mapper.Map<Customer>(customerList);

            await _customerRepository.CreateAsync(entity);
        }
    }
}
