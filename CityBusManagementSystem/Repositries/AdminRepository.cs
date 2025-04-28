using CityBusManagementSystem.Models;
using CityBusManagementSystem.Models.Data;
using CityBusManagementSystem.Models.Entities;

namespace CityBusManagementSystem.Repositries
{
    public class AdminRepository : GenericRepository<Admin> , IAdminRepository
    {
        private readonly AppDbContext _context;
        private readonly IGenericRepository<Bus> _IGenBusRepo;
        private readonly IGenericRepository<Station> _IGenStationRepo;
        private readonly IGenericRepository<Trip> _IGenTripRepo;
        public AdminRepository(IGenericRepository<Trip> IGenTripRepo,IGenericRepository<Station> IGenStationRepo,IGenericRepository<Bus> IGenBusRepo,AppDbContext context) : base(context)
        {
            this._context = context; 
            this._IGenBusRepo = IGenBusRepo;
            this._IGenStationRepo = IGenStationRepo;
            this._IGenTripRepo = IGenTripRepo;
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

            return new ErrorModel("",true);
        }
        public ErrorModel AddStation(StationModel model)
        {
            var result = _context.Stations.Any(x => x.Location == model.Location);

            if (result)
                return new ErrorModel("The Station is already here!");

            try
            {
                _IGenStationRepo.Add(new Station(model.StationName, model.Location));
            }
            catch (Exception ex)
            {
                return new ErrorModel(ex.Message);
            }

            return new ErrorModel("", true);
        }

        public ErrorModel AddTrip(TripModel model)
        {
            try
            {
                _IGenTripRepo.Add(new Trip(model.Source, model.Destination));
            }
            catch (Exception ex)
            {
                return new ErrorModel(ex.Message);
            }

            return new ErrorModel("", true);
        }

    }
}
