namespace Sommelio.DTO
{
    public class UserDto
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string? Surname { get; set; }
            public string? Email { get; set; }
            public string? ProfilePictureUrl { get; set; }
            public string? UserType { get; set; }
            public int? FidelityPoints { get; set; }
            public string? FidelityGrade { get; set; }
            public string? QRCode { get; set; }
            public string? inscriptionDate { get; set; }


    }
}
