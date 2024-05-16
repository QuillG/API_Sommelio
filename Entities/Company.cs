namespace Sommelio.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public Address Address { get; set; }
        public User User { get; set; }

    }
}
