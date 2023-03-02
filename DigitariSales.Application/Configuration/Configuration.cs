using DigitariSales.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace DigitariSales.Application.Configuration
{
    public static class Configuration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.Configure<ApplicationOptions>(configurationManager.GetSection(ApplicationOptions.SectionName));
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
