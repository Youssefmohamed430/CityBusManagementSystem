using CityBusManagementSystem.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public class TripModel
    {
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
    }
}