using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public class StationModel
    {
        [Required]
        [MinLength(4)]
        public string StationName { get; set; }
        [Required]
        public string Location { get; set; }
    }
}