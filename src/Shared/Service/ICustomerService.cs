using Codeman.BikeRentingSystem.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.Shared.Service
{
    public interface ICustomerService
    {
        Task<IList<State>> GetAllStatesAsync();

        Task<IList<City>> GetAllCitiesAsync(int stateId);
    }
}