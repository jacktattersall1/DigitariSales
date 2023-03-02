
namespace DigitariSales.Api.RequestModels
{
    public class SpeakerResponse
    {
        public string PhoneNumber { get; set; }
        public int CallingCode { get; set; }
        public string CountryCode { get; set; }
        public UserResponse User { get; set; }
        public CountryResponse CallingCountryDetails { get; set; }
    }

    public class UserResponse
    {
        public int Id { get; set; }
        public IEnumerable<string> Languages { get; set; }
    }

    public class CountryResponse
    {
        public string Name { get; set; }
        public string DefaultLang { get; set; }
        public string CountryNameInUsersLnguage { get; set; }
        public string Region { get; set; }
        public string FlagURL { get; set; }
    }
}
