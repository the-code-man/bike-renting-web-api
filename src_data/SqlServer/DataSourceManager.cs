using Codeman.BRS.Shared.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer
{
    public class DataSourceManager
    {
        private readonly ConnectionHelper _connectionHelper;
        private readonly ILogger _logger;

        public DataSourceManager(ConnectionHelper connectionHelper, ILogger logger)
        {
            _connectionHelper = connectionHelper;
            _logger = logger;
        }

        public async Task<T> ExecuteReaderAsync<T>(Func<SqlDataReader, Task<T>> func, string spName, [Optional] Dictionary<string, string> parameters)
        {
            SqlDataReader reader = null;

            try
            {
                using var connection = new SqlConnection(_connectionHelper.ConnectionString);
                using var command = connection.CreateCommand();
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (var paramkv in parameters)
                    {
                        command.Parameters.Add(new SqlParameter()); // todo - later
                    }
                }

                connection.Open();
                reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                return await func(reader);
            }
            catch (Exception ex)
            {
                _logger.Log("Error occurred while creating a connection to the database.", ex.Message, LogLevel.Error);
                return await func(null);
            }
            finally
            {
                await reader?.CloseAsync();
            }
        }
    }
}