namespace ClientSystemWebApp.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PlaceOfWork { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
