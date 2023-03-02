using DigitariSales.Domain;

namespace DigitariSales.Api.RequestModels.Extensions
{
    public static class CountryConverter
    {
        public static CountryResponse ToCountryReponse(this Country country, string userDefaultLanguage)
        {
            string countryNameInUserLanguage = country.Name;
            country.NameTranslations.TryGetValue(userDefaultLanguage, out countryNameInUserLanguage);

            return new CountryResponse
            {
                Name = country.Name,
                DefaultLang = country.DefaultLanguage,
                CountryNameInUsersLnguage = countryNameInUserLanguage ?? country.Name,
                Region = country.Region,
                FlagURL = country.FlagUrl
            };
        }
    }
}
