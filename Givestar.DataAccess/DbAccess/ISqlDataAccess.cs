using Dapper;

namespace Givestar.DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetData<T>(DynamicParameters queryParameters, string spName, string connectionId = "Default");
        Task<int> SetData(DynamicParameters dynamicParameters, string spName, string connectionId = "Default");
    }
}