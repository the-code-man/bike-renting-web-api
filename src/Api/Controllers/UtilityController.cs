using Codeman.BRS.Shared.Common;
using Codeman.BRS.Shared.Model;
using Codeman.BRS.Shared.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codeman.BRS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UtilityController : ControllerBase
    {
        private readonly IUtilityService _utilityService;
        private readonly ILogger _logger;

        public UtilityController(IUtilityService utilityService, ILogger logger)
        {
            _utilityService = utilityService;
            _logger = logger;
        }

        [HttpGet("states")]
        public async Task<ActionResult<IList<State>>> GetStates()
        {
            try
            {
                var states = await _utilityService.GetAllStatesAsync();
                return Ok(states);
            }
            catch (Exception ex)
            {
                _logger.Log("Error occurred while fetching states.", ex.Message, LogLevel.Error);
                return NoContent();
            }
        }

        [HttpGet("state/{stateCode}/cities")]
        public async Task<ActionResult<IList<State>>> GetCities(string stateCode)
        {
            try
            {
                var cities = await _utilityService.GetAllCitiesAsync(stateCode);
                return Ok(cities);
            }
            catch (Exception ex)
            {
                _logger.Log($"Error occurred while fetching cities for state {stateCode}.", ex.Message, LogLevel.Error);
                return NoContent();
            }
        }
    }
}
