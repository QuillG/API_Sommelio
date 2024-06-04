using Microsoft.SqlServer.Server;

namespace Sommelio.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        public int? FidelityPoints { get; set; }
        public int? FidelityGradeId { get; set; }
        public FidelityRank? FidelityGrade { get; set; }
        public string? QRCode { get; set; }
        public DateTime InscriptionDate { get; set; }
    }
}
