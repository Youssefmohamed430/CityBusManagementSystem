using CityBusManagementSystem.Models.Entities;

namespace CityBusManagementSystem.Repositries
{
    public interface IDriverRepository : IGenericRepository<Driver>
    {
        bool IsSsnToken(string ssn);
    }
}
