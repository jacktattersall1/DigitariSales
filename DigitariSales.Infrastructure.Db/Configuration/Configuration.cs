using DigitalSales.Infrastructure.Db;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitariSales.Infrastructure.Db.Configuration
{
    public static class Configuration
    {
        public static IServiceCollection AddDb(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.Configure<DbOptions>(configurationManager.GetSection(DbOptions.SectionName));
            services.AddSingleton<DigitariContext>();
            return services;
        }
    }
}
