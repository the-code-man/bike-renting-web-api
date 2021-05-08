using Codeman.BRS.Shared.Common;
using Codeman.BRS.Shared.Entity;
using Codeman.BRS.Shared.Repository;
using Codeman.BRS.Shared.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Core
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly ILogger _logger;

        private IList<State> _allStates;

        public CustomerService(ICustomerRepository customerRepository, 
            IAddressRepository addressRepository, 
            ILogger logger)
        {
            _customerRepository = customerRepository;
            _addressRepository = addressRepository;
            _logger = logger;
        }

        public async Task<IList<City>> GetAllCitiesAsync(int stateId)
        {
            return await _addressRepository.GetCities(stateId);
        }

        public async Task<IList<State>> GetAllStatesAsync()
        {
            _allStates ??= await _addressRepository.GetStates();

            return _allStates;
        }
    }
}
