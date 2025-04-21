namespace CityBusManagementSystem.Models.Entities
{
    public class DriverSchedule
    {
        public int DriverScheduleId { get; set; }
        public string DriverId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Day { get; set; }
        public Driver? driver { get; set; }
    }
}
