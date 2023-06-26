using DataAccess.Entities;

namespace DataAccess.Interfaces
{
    public interface IUserAccess
    {
        Task<User?> GetByIdAsync(int id);
        Task InsertAsync(User user);
        Task SubscribeToAffiliateAsync(int userId, int affiliateProgramId);
    }
}