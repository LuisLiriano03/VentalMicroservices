using Customers.Domain.Interfaces;
using Customers.Infrastructure.Repositorys;
using Microsoft.Extensions.DependencyInjection;

namespace Customers.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            return service.
                AddTransient(typeof(ICustomerRepository<>), typeof(CustomerRepository<>));

        }

    }

}
