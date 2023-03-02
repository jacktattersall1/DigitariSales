using DigitariSales.Domain.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DigitariSales.Domain
{
    public class Country
    {
        public string? DefaultLanguage { get; set; }
        public string Name { get; set; }
        public IDictionary<string, string> NameTranslations { get; set; }
        public string Region { get; set; }
        public string FlagUrl { get; set; }
        public int CallingCode { get; set; }
        public string CountryCode { get; set; }
    }
}
