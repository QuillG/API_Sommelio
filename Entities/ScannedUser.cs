namespace Sommelio.Entities
{
    public class ScannedUser
    {
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public User User  { get; set; }
        public Company Company { get; set; }
    }
}
