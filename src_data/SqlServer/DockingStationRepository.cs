using Codeman.BRS.Shared.Model;
using Codeman.BRS.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer
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
