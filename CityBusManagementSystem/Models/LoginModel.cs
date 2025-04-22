using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string password { get; set; }
        
    }
}