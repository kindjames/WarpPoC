using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonStatu
    {
        public PersonStatu()
        {
            this.People = new List<Person>();
        }

        public int PersonStatusId { get; set; }
        public string Status { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.DateTime Created { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
