using Codeman.BRS.Shared.Model.Customer;
using Codeman.BRS.Shared.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Data.SqlServer.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<bool> Add(CustomerDetails entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(CustomerDetails entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CustomerDetails>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerDetails> GetById(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(CustomerDetails entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
