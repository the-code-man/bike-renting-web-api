using Codeman.BRS.Shared.Model.Core;
using Codeman.BRS.Shared.Repository.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer.Repository.Core
{
    public class StateRepository : IStateRepository
    {
        private readonly DataSourceManager _dataSourceManager;

        public StateRepository(DataSourceManager dataSourceManager)
        {
            _dataSourceManager = dataSourceManager;
        }

        public async Task<IEnumerable<State>> GetAll() =>
            await _dataSourceManager.ExecuteReaderAsync(async (SqlDataReader reader) =>
            {
                List<State> states = new();
                while (await reader.ReadAsync())
                {
                    states.Add(
                        new State
                        {
                            StateCode = Convert.ToString(reader[Constants.FieldNames.STATE_CODE]),
                            Name = Convert.ToString(reader[Constants.FieldNames.STATE_NAME])
                        });
                }
                return states;
            }, Constants.StoredProcedures.Core.GET_ALL_STATES);

        public Task<State> GetById(string entityId)
        {
            throw new NotImplementedException();
        }
    }
}
