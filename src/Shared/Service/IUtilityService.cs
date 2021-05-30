using Codeman.BRS.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Service
{
    public interface IUtilityService
    {
        Task<IList<State>> GetAllStatesAsync();

        Task<IList<City>> GetAllCitiesAsync(string id);
    }
}