using SoftCaribbeanSystem.Model.Base.Entity;

namespace SoftCaribbeanSystem.Model.Entities
{
    public class Patient: Entity
    {
        public string EPS { get; set; }
        public string ARL { get; set; }
        public string Condition { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
