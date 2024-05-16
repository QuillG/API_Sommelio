using System.Drawing;

namespace Sommelio.Entities
{
    public class Delicacies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? parentId { get; set; }
        public Delicacies? parent { get; set; }
        public int? ColorId { get; set; }
        public ColorsBtn? ColorsBtn { get; set; }


    }
}
