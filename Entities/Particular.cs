namespace Sommelio.Entities
{
    public class Particular : User
    {
        public int ParticularId { get; set; }
        public int FidelityPoints { get; set; }
        public int FidelityGradeId { get; set; }
        public FidelityRank FidelityGrade { get; set; }
        public string QRCode { get; set; }

    }
}
