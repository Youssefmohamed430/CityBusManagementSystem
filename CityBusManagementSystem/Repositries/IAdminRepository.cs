using CityBusManagementSystem.Models;

namespace CityBusManagementSystem.Repositries
{
    public interface IAdminRepository
    {
        ErrorModel AddBus(BusModel model);
    }
}
