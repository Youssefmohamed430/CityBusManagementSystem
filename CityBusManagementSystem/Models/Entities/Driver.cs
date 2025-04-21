namespace CityBusManagementSystem.Models.Entities
{
    public class Driver
    {
        public string DriverId { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string ImgDrivingLicense { get; set; }
        public bool IsAccept { get; set; } = false;
        public double? Salary { get; set; }
        public ApplicationUser? user { get; set; }
        public int? BusId { get; set; }
        public Bus? bus { get; set; }
        public List<DriverSchedule>? DriverSchedules { get; set; }
    }
}
