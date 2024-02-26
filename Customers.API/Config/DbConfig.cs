using Customers.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Customers.API.Config
{
    public static class DbConfig
    {
        public static IServiceCollection ConfigDbConnection(this IServiceCollection service, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection")!;
            service.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            return service;
        }
    }
}
