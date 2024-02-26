using AutoMapper;
using Customers.Application.Customers.Dtos;
using Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
