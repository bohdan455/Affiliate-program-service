using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ObjectAccess
{
    public class AffiliateProgramAccess : IAffiliateProgramAccess
    {
        private readonly ISqlAccess _sqlAccess;

        public AffiliateProgramAccess(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;
        }
        public async Task<IEnumerable<AffiliateProgram>> GetAllAsync()
        {
            return await _sqlAccess.QueryDataAsync<AffiliateProgram, dynamic>("spAffiliateProgram_GetAll", new { });
        }
        public async Task<IEnumerable<AffiliateProgram>> GetByTitleSortedByPopularityAsync(string term)
        {
            return await _sqlAccess.QueryDataAsync<AffiliateProgram, dynamic>("spAffiliateProgram_GetByTitle_SortByPopularity", new { Term = term });
        }
    }
}
