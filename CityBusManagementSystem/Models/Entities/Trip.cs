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

        public Trip()
        {
            
        }
        public Trip(string Source, string Destination)
        {
            this.Source = Source;
            this.Destination = Destination;
        }

    }
}
