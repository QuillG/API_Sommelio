namespace Sommelio.DTO
{
    public class ParticularDto : UserRegisterDto
    {
        public int FidelityPoints { get; set; }
        public string FidelityGrade{ get; set; }
        public string? QRCode { get; set; }

    }
}
