using CityBusManagementSystem.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public class BusModel
    {
        [Required]
        //[MinLength(3,ErrorMessage = "Bus Number at leat 3 letters")]
        public int BusNumber { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string status { get; set; }
    }
}