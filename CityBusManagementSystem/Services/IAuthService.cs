using CityBusManagementSystem.Models;

namespace CityBusManagementSystem.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterClientAsync(RegisterClientModel model);
    }
}
