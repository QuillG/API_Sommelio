namespace Sommelio.Entities
{
    public class Wine
    {
        public int Id { get; set; }
        public int WineTypeId { get; set; }
        public int TypeAppellationId { get; set; }
        public int RegionId { get; set; }
        public int CepageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Producer {  get; set; }
        public string Embouteilleur { get; set; }
        public double AlcoholDegrees { get; set; }
        public string PictureUrl { get; set; }
        public WineType WineType { get; set; }
        public TypeApellation TypeApellation { get; set; }
        public Region Region { get; set; }
        public Cepage Cepage { get; set; }
    }
}
