using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ObjectAccess
{
    public class UserAccess : IUserAccess
    {
        private readonly ISqlAccess _sqlAccess;

        public UserAccess(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;
        }
        public async Task<User?> GetByIdAsync(int id)
        {
            var rawResult = await _sqlAccess.QueryDataAsync<User, dynamic>("spUser_GetById", new { Id = id });
            return rawResult.FirstOrDefault();
        }
        public async Task InsertAsync(User user)
        {
            await _sqlAccess.LoadDataAsync("spUser_Insert", new { user.Email, user.Name });
        }
        public async Task SubscribeToAffiliateAsync(int userId, int affiliateProgramId)
        {
            await _sqlAccess.LoadDataAsync("spUser_SubscribeToAffiliateProgram", new { UserId = userId, AffiliateProgramId = affiliateProgramId });
        }

    }
}
