namespace CityBusManagementSystem.Models.Entities
{
    public class TripStation
    {
        public int TripStationId { get; set; }
        public int TripId { get; set; }
        public int StationId { get; set; }
        public Station? station { get; set; }
        public Trip? trip { get; set; }
    }
}
