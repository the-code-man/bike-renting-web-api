using Codeman.BikeRentingSystem.Shared.Entity;
using Codeman.BikeRentingSystem.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.DataAccess
{
    public class DockingStationRepository : IDockingStationRepository
    {
        public Task<bool> Add(DockingStation entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(DockingStation entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DockingStation>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<DockingStation> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DockingStation entity)
        {
            throw new NotImplementedException();
        }
    }
}
