using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public class RegisterClientModel
    {
        [Required]
        [Length(3,25,ErrorMessage = "Name must at least 3 letters and at most 25 letters!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name must contain only letters")]
        public string Name { get; set; }

        [Required]
        [Length(3,25,ErrorMessage = "Username must at least 3 letters and at most 25 letters!")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username must contain only letters and numbers")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="InValid Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "password must contain only letters and numbers")]
        public string Password { get; set; }
    }
}