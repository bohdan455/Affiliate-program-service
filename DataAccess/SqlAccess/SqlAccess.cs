using Dapper;
using DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlAccess
{
    public class SqlAccess : ISqlAccess
    {
        private readonly IConfiguration _configuration;

        public SqlAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task LoadDataAsync<T>(string storedProcedure, T param)
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("Default"));
            await connection.ExecuteAsync(storedProcedure, param: param, commandType: System.Data.CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<T>> QueryDataAsync<T, U>(string storedProcedure, U param)
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("Default"));
            return await connection.QueryAsync<T>(storedProcedure, param: param, commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
