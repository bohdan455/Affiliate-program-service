using Api.Model;
using DataAccess.Entities;

namespace Api.Extensions.Mapper
{
    public static class UserMappersExtensions
    {
        public static User ToUser(this UserModel user) 
        {
            return new User
            {
                Name = user.Name,
                Email = user.Email,
            };
        }
    }
}
