using Customers.Application.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Application.Customers.Interfaces
{
    public interface ICustomersService
    {
        Task<List<GetCustomers>> GetAllCustomers();
        Task<GetCustomers> CreateCustomers(CreateCustomers model);
        Task<bool> UpdateCustomers(UpdateCustomers model);
        Task<bool> EliminateCustomers(int id);

    }

}
