using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaribbeanSystem.Model.Base.Entity
{
    public class Entity
    {
        public Entity()
        {
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}
