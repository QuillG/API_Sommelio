namespace Sommelio.Entities
{
    public class ScannedUser
    {
        public int CompanyId { get; set; }
        public int ParticularId { get; set; }
        public Particular Particular { get; set; }
        public Company Company { get; set; }
    }
}
