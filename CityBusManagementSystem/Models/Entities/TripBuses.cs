namespace CityBusManagementSystem.Models.Entities
{
    public class TripBuses
    {
        public int TripBusesId { get; set; }
        public int TripId { get; set; }
        public int BusId { get; set; }
        public Bus? bus { get; set; }
        public Trip? trip { get; set; }
    }
}
