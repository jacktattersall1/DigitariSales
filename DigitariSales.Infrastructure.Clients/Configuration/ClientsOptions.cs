using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Infrastructure.Clients.Configuration
{
    public class ClientsOptions
    {
        public const string SectionName = "ClientsOptions";
        public string RestCountriesClientBaseUrl { get; set; } = null!;
    }
}
