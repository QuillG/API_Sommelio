namespace Sommelio.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
