namespace Sommelio.Entities
{
    public class Professional : User
    {
        public int? ProfessionalTypeId { get; set; }
        public ProfessionalType? ProfessionalType { get; set; }
    }
}
