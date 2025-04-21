namespace CityBusManagementSystem.Models.Entities
{
    public class Station
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public string Location { get; set; }
        public List<TripStation> TripStations { get; set; }
    }
}
