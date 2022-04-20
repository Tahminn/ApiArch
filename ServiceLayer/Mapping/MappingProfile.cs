using AutoMapper;
using DomainLayer.Entities.CustomerEntities;
using ServiceLayer.DTOs.Customer;

namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerListDto>().ReverseMap();
            CreateMap<CustomerDetails, CustomerListDto>().ReverseMap();
        }
    }
}
