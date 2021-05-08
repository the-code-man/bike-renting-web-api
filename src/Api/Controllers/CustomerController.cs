﻿using Codeman.BikeRentingSystem.Shared.Common;
using Codeman.BikeRentingSystem.Shared.Entity;
using Codeman.BikeRentingSystem.Shared.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codeman.BikeRentingSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger _logger;

        public CustomerController(ICustomerService customerService, ILogger logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        [HttpGet("states")]
        public async Task<ActionResult<IList<State>>> GetStates()
        {
            try
            {
                var states = await _customerService.GetAllStatesAsync();
                return Ok(states);
            }
            catch (Exception ex)
            {
                _logger.Log("Error occurred while fetching states.", ex.Message, LogLevel.Error);
                return NoContent();
            }
        }

        [HttpGet("state/{id}/cities")]
        public async Task<ActionResult<IList<State>>> GetCities(int id)
        {
            try
            {
                var cities = await _customerService.GetAllCitiesAsync(id);
                return Ok(cities);
            }
            catch (Exception ex)
            {
                _logger.Log($"Error occurred while fetching cities for state {id}.", ex.Message, LogLevel.Error);
                return NoContent();
            }
        }
    }
}
