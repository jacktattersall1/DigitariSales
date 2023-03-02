using DigitariSales.Application.Interfaces;
using DigitariSales.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Application
{
    public class UserService :IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetRelevantUserByCountryCode(string countryCode)
        {
            return await _userRepository.GetUserByCountryCode(countryCode);
        }
    }
}
