using Codeman.BRS.Shared.Common;
using Codeman.BRS.Shared.Entity;
using Codeman.BRS.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IDBConnectionHelper _dbConnHelper;
        private readonly ILogger _logger;

        public AddressRepository(IDBConnectionHelper dbConnHelper, ILogger logger)
        {
            _dbConnHelper = dbConnHelper;
            _logger = logger;
        }

        public Task<bool> Add(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<City>> GetCitiesByStateCode(string stateCode)
        {
            using var connection = new SqlConnection(_dbConnHelper.ConnectionString);

            SqlCommand command = new("dbo.uspGetCities", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StateCode", stateCode);

            List<City> cities = null;
            SqlDataReader reader = null;

            try
            {
                await connection.OpenAsync();
                reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                while (await reader.ReadAsync())
                {
                    cities ??= new List<City>();

                    cities.Add(new City
                    {
                        Name = reader.GetString("city_name").Trim(),
                        State = new State
                        {
                            Name = reader.GetString("state_name").Trim(),
                            StateCode = reader.GetString("state_code").Trim()
                        }
                    });
                }

                reader.Close();
            }
            catch (SqlException sqEx)
            {
                _logger.Log("Error occured while fetching states", sqEx.Message, LogLevel.Error);
            }
            finally
            {
                reader?.Close();
            }

            return cities;
        }

        public async Task<IList<State>> GetStates()
        {
            List<State> states = null;

            using var connection = new SqlConnection(_dbConnHelper.ConnectionString);

            SqlCommand command = new("uspGetStates", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;

            try
            {
                await connection.OpenAsync();
                reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                while (await reader.ReadAsync())
                {
                    states ??= new List<State>();

                    states.Add(new State
                    {
                        Name = reader.GetString("state_name").Trim(),
                        StateCode = reader.GetString("state_code").Trim()
                    });
                }

                reader.Close();
            }
            catch (SqlException sqEx)
            {
                _logger.Log("Error occured while fetching states", sqEx.Message, LogLevel.Error);
            }
            finally
            {
                reader?.Close();
            }

            return states;
        }

        public Task<bool> Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}