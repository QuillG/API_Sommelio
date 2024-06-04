namespace Sommelio.DTO
{
    public class UserRegisterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? UserType { get; set; }
    }
}
