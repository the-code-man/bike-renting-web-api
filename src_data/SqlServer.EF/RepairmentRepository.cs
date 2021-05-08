using Codeman.BRS.Shared.Entity;
using Codeman.BRS.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer.EF
{
    public class RepairmentRepository : IRepairmentRepository
    {
        public Task<bool> Add(Repairment entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Repairment entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Repairment>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Repairment> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Repairment entity)
        {
            throw new NotImplementedException();
        }
    }
}
