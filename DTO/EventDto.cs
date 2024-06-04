using Sommelio.Entities;

namespace Sommelio.DTO
{
    public class EventDto
    {
        public int CompanyId { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
