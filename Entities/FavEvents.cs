namespace Sommelio.Entities
{
    public class FavEvents
    {
        public int Id { get; set; }
        public int ParticularId { get; set; }
        public int EventId { get; set; }
        public Events Events { get; set; }
        public Particular Particular { get; set; }

    }
}
