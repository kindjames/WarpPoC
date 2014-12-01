using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Data.Entities
{
    public abstract class EntityBase
    {
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}
