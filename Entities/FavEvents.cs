namespace Sommelio.Entities
{
    public class FavEvents
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public Events Events { get; set; }
        public User User { get; set; }

    }
}
