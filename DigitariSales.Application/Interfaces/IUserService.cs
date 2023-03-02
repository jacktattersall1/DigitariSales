using DigitariSales.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Application.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetRelevantUserByCountryCode(string countryCode);
    }
}
