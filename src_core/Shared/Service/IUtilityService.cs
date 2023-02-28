using Codeman.BRS.Shared.Model.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Shared.Service
{
    public interface IUtilityService
    {
        Task<IEnumerable<State>> GetAllStatesAsync();

        Task<IList<City>> GetAllCitiesAsync(string id);
    }
}