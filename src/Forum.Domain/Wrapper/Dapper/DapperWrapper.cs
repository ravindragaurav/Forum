using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Forum.Domain.Config;
using Dapper;

namespace Forum.Domain.Wrapper.Dapper
{
    public class DapperWrapper : IDapperWrapper
    {
        private readonly string _connectionString;
        private readonly int _commandTimeout;
        private readonly IConfig _config;

        public DapperWrapper(IConfig config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString();
            _commandTimeout = _config.GetConnectionTimeout();
        }

        public IEnumerable<T> QueryStoredProcedure<T>(string storedProcedureName, object param = null)
        {
            return Query<T>(storedProcedureName, param, CommandType.StoredProcedure);
        }

        public Task<IEnumerable<T>> QueryStoredProcedureAsync<T>(string storedProcedureName, object param = null)
        {
            return QueryAsync<T>(storedProcedureName, param, CommandType.StoredProcedure);
        }

        public IEnumerable<T> QuerySqlText<T>(string sqlText, object param)
        {
            return Query<T>(sqlText, param, CommandType.Text);
        }

        public IEnumerable<T> Query<T>(string sql, object param, CommandType commandType)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<T>(sql, param, commandType: commandType, commandTimeout: _commandTimeout);
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param, CommandType commandType)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<T>(sql, param, commandType: commandType, commandTimeout: _commandTimeout);
            }
        }

        public T QueryFirstOrDefaultStoredProcedure<T>(string storedProcedureName, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.QueryFirstOrDefault<T>(storedProcedureName, param, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
            }
        }

        public async Task<T> QueryFirstOrDefaultStoredProcedureAsync<T>(string storedProcedureName, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryFirstOrDefaultAsync<T>(storedProcedureName, param, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
            }
        }

        public IEnumerable<T> Query<T>(string query, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<T>(query, param, commandType: CommandType.Text, commandTimeout: _commandTimeout);
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string query, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<T>(query, param, commandType: CommandType.Text, commandTimeout: _commandTimeout);
            }
        }

        public int ExecuteStoredProcedure(string storedProcedureName, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Execute(storedProcedureName, param, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
            }
        }

        public async Task<int> ExecuteStoredProcedureAsync(string storedProcedureName, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.ExecuteAsync(storedProcedureName, param, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
            }
        }


        public int Execute(string query, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Execute(query, param, commandType: CommandType.Text, commandTimeout: _commandTimeout);
            }
        }

        public async Task<int> ExecuteAsync(string query, object param)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.ExecuteAsync(query, param, commandType: CommandType.Text, commandTimeout: _commandTimeout);
            }
        }


    }
}