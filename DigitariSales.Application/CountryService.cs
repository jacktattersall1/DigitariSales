using DigitariSales.Application.Configuration;
using DigitariSales.Application.Interfaces;
using DigitariSales.Domain;
using Microsoft.Extensions.Options;
using PhoneNumbers;

namespace DigitariSales.Application
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IOptions<ApplicationOptions> _options;
        public CountryService(ICountryRepository countryRepository, IOptions<ApplicationOptions> options)
        {
            _countryRepository = countryRepository;
            _options = options;
        }

        public async Task<Country> GetCountryFromPhoneNumber(string phoneNumber)
        {
            
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            var defaultRegionCode = _options.Value.DefaultRegionCode;

            var parsedPhoneNumber = phoneNumberUtil.Parse(phoneNumber, null);

            var callingCode = parsedPhoneNumber.HasCountryCode 
                ? parsedPhoneNumber.CountryCode 
                : phoneNumberUtil.GetCountryCodeForRegion(defaultRegionCode);

            var region = phoneNumberUtil.GetRegionCodeForCountryCode(callingCode).ToLower();

            var country = await _countryRepository.GetCountryByRegionCode(region);
            if(country is null)
            {
                country = await _countryRepository.GetCountryByRegionCode(defaultRegionCode);
            }

            country.CallingCode = callingCode;
            country.CountryCode = region;
            return country;
        }
    }
}