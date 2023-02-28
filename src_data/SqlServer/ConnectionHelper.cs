using Codeman.BRS.Shared.Common;
using Microsoft.Extensions.Options;
using System;

namespace Codeman.BRS.Data.SqlServer
{
    public class ConnectionHelper
    {
        public ConnectionHelper(IOptions<DataSourceOptions> dsOptions)
        {
            ConnectionString = dsOptions.Value.DBConnString;

            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new ArgumentNullException(nameof(ConnectionString), "Database connection string has not been provided.");
            }
        }

        public string ConnectionString { get; }
    }
}
