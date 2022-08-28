using eCommerceAPI.Repository;
using eCommerceAPI.Repository.Contract;
using eCommerceAPI.Service;
using eCommerceAPI.Service.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace eCommerceAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection"));
            });
        }

        public static void ConfigureUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
    }
}
