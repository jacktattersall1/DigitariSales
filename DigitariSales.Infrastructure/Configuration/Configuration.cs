using DigitariSales.Application.Interfaces;
using DigitariSales.Infrastructure.Clients.Configuration;
using DigitariSales.Infrastructure.Db.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitariSales.Infrastructure.Configuration
{
    public static class Configuration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddClients(configurationManager);
            services.AddDb(configurationManager);
            services.AddAutoMapper(typeof(ClientsMappings));
            return services;
        }
    }
}
