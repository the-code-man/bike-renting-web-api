using Codeman.BRS.Shared.Model.Core;
using Codeman.BRS.Shared.Repository.Core;
using Codeman.BRS.Shared.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Core.Service
{
    internal class UtilityService : IUtilityService
    {
        private readonly IStateRepository _stateRepository;

        public UtilityService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public Task<IList<City>> GetAllCitiesAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<State>> GetAllStatesAsync() => 
            await _stateRepository.GetAll();
    }
}
