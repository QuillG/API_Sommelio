namespace Sommelio.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int BeerId { get; set; }
        public int WineId { get; set; }
        //public Beer Beer { get; set; }
        public Wine Wine { get; set; }
        public Beer Beer { get; set; }

    }
}
