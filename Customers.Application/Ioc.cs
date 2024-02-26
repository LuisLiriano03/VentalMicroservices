using Customers.Application.Customers.Interfaces;
using Customers.Application.Customers.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
