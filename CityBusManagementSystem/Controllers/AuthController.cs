using CityBusManagementSystem.Models;
using CityBusManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityBusManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("RegisterClient")]
        public async Task<IActionResult> RegisterClient(RegisterClientModel model)
        {
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            var result = await _authService.RegisterClientAsync(model);

            if(!result.IsAuthenticated) 
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("RegisterDriver")]
        public async Task<IActionResult> RegisterDriverAsync(RegisterDriverModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterDriverAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}
