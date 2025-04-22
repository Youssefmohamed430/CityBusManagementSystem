using System.ComponentModel.DataAnnotations;

namespace CityBusManagementSystem.Models
{
    public class RegisterDriverModel : IRegisterModel
    {
        [Required]
        [Length(3, 25, ErrorMessage = "Name must at least 3 letters and at most 25 letters!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name must contain only letters")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Address must contain only letters!")]
        public string Address { get; set; }

        [Required]
        public string ImgDrivingLicense { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "password must contain only letters and numbers")]
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}