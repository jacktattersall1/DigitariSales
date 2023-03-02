using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DigitariSales.Infrastructure.Clients.Models
{
    public class CountryResponse
    {
        public IEnumerable<Language> Languages { get; set; }
        public string Name { get; set; }
        public IDictionary<string, string> Translations { get; set; }
        public string Region { get; set; }
        public string Flag { get; set; }
    }

    public class Language
    {
        [JsonPropertyName("iso639_1")]
        public string iso639_1 { get; set; }
    }
}
