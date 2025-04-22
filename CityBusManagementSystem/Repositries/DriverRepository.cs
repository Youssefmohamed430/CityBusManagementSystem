using CityBusManagementSystem.Models.Data;
using CityBusManagementSystem.Models.Entities;

namespace CityBusManagementSystem.Repositries
{
    public class DriverRepository : GenericRepository<Driver> , IDriverRepository
    {
        private AppDbContext _context;
        public DriverRepository(AppDbContext context) : base(context)
              => this._context = context;
  
        public bool IsSsnToken(string ssn)
            => _context.Drivers.Any(x => x.SSN == ssn);
    }
}
