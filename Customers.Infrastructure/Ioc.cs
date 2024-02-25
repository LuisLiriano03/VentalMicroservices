using Customers.Domain.Interfaces;
using Customers.Infrastructure.Repositorys;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Infrastructure
{
    public static class Ioc
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            return service.
                AddTransient(typeof(ICustomerRepository<>), typeof(CustomerRepository<>));

        }

    }

}
