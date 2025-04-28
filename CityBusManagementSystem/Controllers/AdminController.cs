using CityBusManagementSystem.Models;
using CityBusManagementSystem.Models.Entities;
using CityBusManagementSystem.Repositries;
using CityBusManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityBusManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _IadminRepository;

        public AdminController(IAdminRepository IadminRepository)
        {
            this._IadminRepository = IadminRepository;
        }

        [HttpPost("AddBus")]
        public IActionResult AddBus(BusModel model)
        {
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            var result = _IadminRepository.AddBus(model);

            if(!result.Succeeded)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("AddStation")]
        public IActionResult AddStation(StationModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _IadminRepository.AddStation(model);

            if (!result.Succeeded)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("AddTrip")]
        public IActionResult AddTrip(TripModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _IadminRepository.AddTrip(model);

            if (!result.Succeeded)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}
