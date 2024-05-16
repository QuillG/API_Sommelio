namespace Sommelio.Entities
{
    public class DelicaciesWine
    {
        public int DelicaciesId { get; set; }
        public int WineId { get; set; }
        public Delicacies Delicacies { get; set; }
        public Wine Wine { get; set; }

    } 
}
