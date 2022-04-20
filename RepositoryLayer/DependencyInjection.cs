using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.CustomerReps;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConnectRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerDetailsRepository, CustomerDetailsRepository>();

            return services;
        }
    }
}
