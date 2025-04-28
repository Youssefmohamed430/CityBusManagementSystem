using CityBusManagementSystem.Models;

namespace CityBusManagementSystem.Repositries
{
    public interface IAdminRepository
    {
        ErrorModel AddBus(BusModel model);
        ErrorModel AddStation(StationModel model);
        ErrorModel AddTrip(TripModel model);
    }
}
