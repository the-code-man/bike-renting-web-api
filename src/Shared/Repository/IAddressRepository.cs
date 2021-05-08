using Codeman.BikeRentingSystem.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.Shared.Repository
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<IList<State>> GetStates();

        Task<IList<City>> GetCities(int stateId);
    }
}