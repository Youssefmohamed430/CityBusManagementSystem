namespace CityBusManagementSystem.Models.Entities
{
    public class TripsSchedule
    {
        public int ScheduleId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int TripId { get; set; }
        public Trip trip { get; set; }
    }
}
