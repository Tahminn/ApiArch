using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services.CustomerServices;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConnectServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}
