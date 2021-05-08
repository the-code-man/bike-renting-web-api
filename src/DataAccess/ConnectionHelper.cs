using Codeman.BikeRentingSystem.Shared.Common;
using Microsoft.Extensions.Options;
using System;

namespace Codeman.BikeRentingSystem.DataAccess
{
    public class ConnectionHelper : IDBConnectionHelper
    {
        public ConnectionHelper(IOptions<DataSourceOptions> dsOptions)
        {
            ConnectionString = dsOptions.Value.DBConnString;

            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new ArgumentNullException("Database connection string has not been provided.");
            }
        }

        public string ConnectionString { get; }
    }
}
