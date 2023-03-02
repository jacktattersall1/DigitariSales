using AutoMapper;
using DigitariSales.Application.Interfaces;
using DigitariSales.Domain;
using DigitariSales.Infrastructure.Clients.Interfaces;
using DigitariSales.Infrastructure.Clients.Models;

namespace DigitariSales.Infrastructure
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IRestCountriesClient _restCountriesClient;
        private readonly IMapper _mapper;

        public CountryRepository(IRestCountriesClient restCountriesClient, IMapper mapper)
        {
            _restCountriesClient = restCountriesClient;
            _mapper = mapper;
        }
        public async Task<Country?> GetCountryByRegionCode(string regionCode)
        {
            var countryResponse = await _restCountriesClient.GetCountryByRegionCode(regionCode);
            
            return _mapper.Map<CountryResponse, Country>(countryResponse);
        }
    }
}