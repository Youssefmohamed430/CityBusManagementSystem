namespace CityBusManagementSystem.Models
{
    public class ErrorModel
    {
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public ErrorModel( string message,bool Succeded = false)
        {
            Message = message;
            Succeeded = Succeded;
        }
    }
}
