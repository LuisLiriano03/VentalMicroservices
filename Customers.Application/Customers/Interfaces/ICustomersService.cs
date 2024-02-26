using Customers.Application.Customers.Dtos;

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
