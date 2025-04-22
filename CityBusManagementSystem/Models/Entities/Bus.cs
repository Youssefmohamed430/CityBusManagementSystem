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

        public Bus() { }

        public Bus(int BusNumber,string model, Status status)
        {
            this.BusNumber = BusNumber;
            this.Model = model;
            this.status = status;
        }
    }
    public enum Status { Work , Maintenance };
}
