using DigitalSales.Infrastructure.Db;
using DigitariSales.Application.Interfaces;
using DigitariSales.Domain;
using Microsoft.EntityFrameworkCore;

namespace DigitariSales.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly DigitariContext _digitariContext;

        public UserRepository(DigitariContext digitariContext)
        {
            _digitariContext = digitariContext;
        }
        public async Task<User?> GetUserByCountryCode(string countryCode)
        {
            var user = await _digitariContext.Users
                .Include(u => u.Languages)
                .Where(u => u.Languages.Any(l => l.Name.ToLower() == countryCode.ToLower()))
                .FirstOrDefaultAsync();

            return user ?? await _digitariContext.Users
                .Include(u => u.Languages)
                .Select(u => new 
                {
                    user = u,
                    languageCount = u.Languages.Count
                })
                .OrderByDescending(a => a.languageCount)
                .Select(a => a.user)
                .FirstAsync();
        } 
    }
}
