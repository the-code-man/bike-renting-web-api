using Codeman.BRS.Shared.Entity;
using Codeman.BRS.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.EF.SqlServer
{
    public class AddressRepository : IAddressRepository
    {
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

        public Task<IList<City>> GetCities(int stateId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<State>> GetStates()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
