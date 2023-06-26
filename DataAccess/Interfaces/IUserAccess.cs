using DataAccess.Entities;

namespace DataAccess.Interfaces
{
    public interface IUserAccess
    {
        Task<User?> GetByIdAsync(int id);
        Task<IEnumerable<AffiliateProgram>> GetSubscribedAffiliateProgramsAsync(int userId);
        Task InsertAsync(User user);
        Task SubscribeToAffiliateAsync(int userId, int affiliateProgramId);
    }
}