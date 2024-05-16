namespace Sommelio.Entities
{
    public class WineType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ColorId { get; set; }
        public ColorsBtn? ColorsBtn { get; set; }

    }
}
