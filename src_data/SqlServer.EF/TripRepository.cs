using Codeman.BRS.Shared.Entity;
using Codeman.BRS.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer.EF
{
    public class TripRepository : ITripRepository
    {
        public Task<bool> Add(Trip entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Trip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Trip>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Trip> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Trip entity)
        {
            throw new NotImplementedException();
        }
    }
}
