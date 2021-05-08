using Codeman.BikeRentingSystem.Shared.Entity;
using Codeman.BikeRentingSystem.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.DataAccess
{
    public class BikeRepository : IBikeRepository
    {
        public Task<bool> Add(Bike entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Bike entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bike>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Bike> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Bike entity)
        {
            throw new NotImplementedException();
        }
    }
}
