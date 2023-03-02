using DigitariSales.Infrastructure.Clients.Interfaces;
using DigitariSales.Infrastructure.Clients.Configuration;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using DigitariSales.Infrastructure.Clients.Models;

namespace DigitariSales.Infrastructure.Clients
{
    public class RestCountriesClient : IRestCountriesClient
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<ClientsOptions> _options;
        public RestCountriesClient(HttpClient httpClient, IOptions<ClientsOptions> options)
        {
            _httpClient = httpClient;
            _options = options;
            _httpClient.BaseAddress = new Uri(_options.Value.RestCountriesClientBaseUrl);
        }

        public async Task<CountryResponse?> GetCountryByRegionCode(string regionCode)
        {
            var requestUrl = $"/v2/alpha/?codes={regionCode}&fields=name,languages,region,flag,translations";
            var response = await _httpClient.GetAsync(requestUrl);
            var country = await response.Content.ReadFromJsonAsync<IEnumerable<CountryResponse>>();
            return country?.FirstOrDefault();
        }
    }
}