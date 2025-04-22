using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public interface IRegisterModel
    {
        [Required]
        [Length(3, 25, ErrorMessage = "Username must at least 3 letters and at most 25 letters!")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username must contain only letters and numbers")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "InValid Email")]
        public string Email { get; set; }
    }
}
