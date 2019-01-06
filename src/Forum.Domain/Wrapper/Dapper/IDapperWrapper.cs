using System.Collections.Generic;
using System.Threading.Tasks;

namespace Forum.Domain.Wrapper.Dapper
{
    public interface IDapperWrapper
    {
        IEnumerable<T> QueryStoredProcedure<T>(string storedProcedureName, object param = null);
        Task<IEnumerable<T>> QueryStoredProcedureAsync<T>(string storedProcedureName, object param = null);
        IEnumerable<T> Query<T>(string query, object param);
        Task<IEnumerable<T>> QueryAsync<T>(string query, object param);
        T QueryFirstOrDefaultStoredProcedure<T>(string storedProcedureName, object param);
        Task<T> QueryFirstOrDefaultStoredProcedureAsync<T>(string storedProcedureName, object param);
        int ExecuteStoredProcedure(string storedProcedureName, object param);
        Task<int> ExecuteStoredProcedureAsync(string storedProcedureName, object param);
        int Execute(string query, object param);
        Task<int> ExecuteAsync(string query, object param);
    }
}
