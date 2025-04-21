namespace CityBusManagementSystem.Models.Entities
{
    public class Bus
    {
        public int BusId { get; set; }
        public int BusNumber { get; set; }
        public string Model { get; set; }
        public Status status { get; set; }
        public Driver driver { get; set; }
        public List<TripBuses> Tripbuses { get; set; }
    }
    public enum Status { Work , Maintenance };
}
