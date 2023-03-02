
using DigitariSales.Domain;

namespace DigitariSales.Api.RequestModels.Extensions
{
    public static class UserConverter
    {
        public static UserResponse ToUserResponse(this User user) 
        {
            return new UserResponse()
            {
                Id = user.Id,
                Languages = user.Languages.Select(l => l.Name)
            };
        }
    }
}
