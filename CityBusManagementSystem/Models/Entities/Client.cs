namespace CityBusManagementSystem.Models.Entities
{
    public class Client
    {
        public string ClientId { get; set; }
        public ApplicationUser? user { get; set; }
        public Client() { }
        public Client(string clientId)
        {
            ClientId = clientId;
        }
    }
}
