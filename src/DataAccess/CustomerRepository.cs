using Codeman.BikeRentingSystem.Shared.Entity;
using Codeman.BikeRentingSystem.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<bool> Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
