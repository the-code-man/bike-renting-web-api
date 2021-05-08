using Codeman.BikeRentingSystem.Shared.Common;
using Codeman.BikeRentingSystem.Shared.Entity;
using Codeman.BikeRentingSystem.Shared.Repository;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.DataAccess
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

        public async Task<IList<City>> GetCities(int stateId)
        {
            List<City> cities = null;

            using var connection = new SqlConnection(_dbConnHelper.ConnectionString);

            SqlCommand command = new("dbo.uspGetCities", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StateId", stateId);

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
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("city_name"),
                        State = new State
                        {
                            Id = stateId,
                            Name = reader.GetString("state_name")
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
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("state_name")
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