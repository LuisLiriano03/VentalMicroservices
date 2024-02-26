using AutoMapper;
using Customers.Application.Customers.Dtos;
using Customers.Domain.Entities;

namespace Customers.Application.Customers.AutoMappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            CreateMap<Customer, CreateCustomers>().ReverseMap();
            CreateMap<Customer, GetCustomers>().ReverseMap();
            CreateMap<Customer, UpdateCustomers>().ReverseMap();

        }

    }

}
