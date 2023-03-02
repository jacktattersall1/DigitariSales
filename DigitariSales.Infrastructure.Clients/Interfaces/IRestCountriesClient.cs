using DigitariSales.Infrastructure.Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Infrastructure.Clients.Interfaces
{
    public interface IRestCountriesClient
    {
        Task<CountryResponse?> GetCountryByRegionCode(string regionCode);
    }
}
