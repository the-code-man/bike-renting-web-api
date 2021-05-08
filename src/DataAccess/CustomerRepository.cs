using Codeman.BRS.Shared.Entity;
using Codeman.BRS.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer
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
