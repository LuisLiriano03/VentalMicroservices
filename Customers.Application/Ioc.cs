using Customers.Application.Customers.Interfaces;
using Customers.Application.Customers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Customers.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            return service
                .AddScoped<ICustomersService, CustomersService>();

        }

    }

}
