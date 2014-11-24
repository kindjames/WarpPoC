using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class PersonStatus
    {
        public PersonStatus()
        {
            People = new List<Person>();
        }

        public int PersonStatusId { get; set; }
        public string Status { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}