namespace CityBusManagementSystem.Models.Entities
{
    public class Trip
    {
        public int TripId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public List<TripBuses> Tripbuses { get; set; }
        public List<TripStation> TripStations { get; set; }
        public List<TripsSchedule> tripsSchedule { get; set; }

    }
}
