using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class NoteType
    {
        public NoteType()
        {
            Notes = new List<Note>();
        }

        public short NoteTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}