using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace Givestar.DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<IEnumerable<T>> GetData<T>(DynamicParameters queryParameters, string spName, string connectionId = "Default")
        {
            try
            {
                if (!string.IsNullOrEmpty(spName))
                {
                    using IDbConnection connection = new NpgsqlConnection(_config.GetConnectionString(connectionId));
                    {
                        return await connection.QueryAsync<T>("SELECT * FROM " + spName + "()", queryParameters, commandType: CommandType.Text);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> SetData(DynamicParameters dynamicParameters, string spName, string connectionId = "Default")
        {
            try
            {
                if (!string.IsNullOrEmpty(spName))
                {
                    using IDbConnection dbConnection = new NpgsqlConnection(_config.GetConnectionString(connectionId));
                    {
                        return await dbConnection.ExecuteAsync(spName, dynamicParameters, commandType: CommandType.StoredProcedure);
                    }
                }

                return -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
