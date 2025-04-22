using CityBusManagementSystem.Models;
using CityBusManagementSystem.Models.Data;
using CityBusManagementSystem.Models.Entities;

namespace CityBusManagementSystem.Repositries
{
    public class AdminRepository : GenericRepository<Admin> , IAdminRepository
    {
        private readonly AppDbContext _context;
        private readonly IGenericRepository<Bus> _IGenBusRepo;
        public AdminRepository(IGenericRepository<Bus> IGenBusRepo,AppDbContext context) : base(context)
        {
            this._context = context; 
            this._IGenBusRepo = IGenBusRepo;
        }

        public ErrorModel AddBus(BusModel model)
        {
            var result = _context.Buses.Any(x => x.BusNumber == model.BusNumber);

            if (result)
                return new ErrorModel("The bus is already here!");

            if (Enum.TryParse(typeof(Status), model.status, true, out object? obj)) 
            { 
                   try
                   {
                        _IGenBusRepo.Add(new Bus(model.BusNumber, model.Model, (Status)obj));
                   }
                   catch (Exception ex)
                   {
                        return new ErrorModel(ex.Message);
                   }
            }

            return new ErrorModel("Adding Done",true);
        }
    }
}
