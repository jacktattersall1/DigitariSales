using DigitariSales.Infrastructure.Clients;
using DigitariSales.Infrastructure.Clients.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Infrastructure.Clients.Configuration
{
    public static class Configuration
    {
        public static IServiceCollection AddClients(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.Configure<ClientsOptions>(configurationManager.GetSection(ClientsOptions.SectionName));
            services.AddScoped<IRestCountriesClient, RestCountriesClient>();
            return services;
        }
    }
}
