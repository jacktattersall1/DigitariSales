using DigitariSales.Api.RequestModels;
using DigitariSales.Api.RequestModels.Extensions;
using DigitariSales.Application.Interfaces;
using DigitariSales.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DigitariSales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly IUserService _userService;

        public SpeakerController(ICountryService countryService, IUserService userService)
        {
            _countryService = countryService;
            _userService = userService;
        }

        // GET api/<SpeakerController>/5
        [HttpGet("{phoneNumber}")]
        public async Task<SpeakerResponse> GetByPhoneNumber(string phoneNumber)
        {
            Country country = await _countryService.GetCountryFromPhoneNumber(phoneNumber);
            var user = await _userService.GetRelevantUserByCountryCode(country.CountryCode);

            var userResponse = user.ToUserResponse();
            var countryResponse = country.ToCountryReponse(user.DefaultLanguage.Name);

            return new SpeakerResponse()
            {
                PhoneNumber = phoneNumber,
                CallingCode = country.CallingCode,
                CountryCode = country.CountryCode,
                User = userResponse,
                CallingCountryDetails = countryResponse
            };
        }
    }
}

