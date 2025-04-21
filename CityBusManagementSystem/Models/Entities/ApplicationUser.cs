using Microsoft.AspNetCore.Identity;

namespace CityBusManagementSystem.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public Driver? driver { get; set; }
        public Client? client { get; set; }
        public Admin? Admin { get; set; }
        public ApplicationUser() {}

        public ApplicationUser(string userName, string name, string email)
        {
            UserName = userName;
            Name = name;
            Email = email;
        }
    }
}
