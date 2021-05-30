using Codeman.BRS.Shared.Model;
using Codeman.BRS.Shared.Model.Shared;
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