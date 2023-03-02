using DigitariSales.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByCountryCode(string countryCode);
    }
}
