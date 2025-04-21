namespace CityBusManagementSystem.Models.Entities
{
    public class Admin
    {
        public string AdminId { get; set; }
        public ApplicationUser? user { get; set; }
    }
}
