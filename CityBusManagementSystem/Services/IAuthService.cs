using CityBusManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityBusManagementSystem.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterClientAsync(RegisterClientModel model);
        Task<AuthModel> AddNewAdmin(RegisterClientModel model);
        Task<AuthModel> RegisterDriverAsync(RegisterDriverModel model);
        Task<AuthModel> LogInasync([FromBody] LoginModel model);
    }
}
