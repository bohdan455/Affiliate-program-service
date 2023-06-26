using DataAccess.Entities;

namespace DataAccess.Interfaces
{
    public interface IAffiliateProgramAccess
    {
        Task<IEnumerable<AffiliateProgram>> GetAllAsync();
        Task<IEnumerable<AffiliateProgram>> GetByTitleSortedByPopularityAsync(string term);
    }
}