using Codeman.BRS.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Repository
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<IList<State>> GetStates();

        Task<IList<City>> GetCitiesByStateCode(string stateCode);
    }
}