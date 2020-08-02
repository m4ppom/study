using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace DataAccessLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public string ConnectionStringName { get; set; } = "Default";
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            //using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }

        public async Task<T> LoadDataOne<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            //using (IDbConnection connection = new MySqlConnection(connectionString))
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryFirstAsync<T>(sql, parameters);
                return data;
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionnString = _config.GetConnectionString(ConnectionStringName);
            //using (IDbConnection connection = new MySqlConnection(connectionnString))
            using (IDbConnection connection = new SqlConnection(connectionnString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
