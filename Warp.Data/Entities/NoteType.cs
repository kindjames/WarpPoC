using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class NoteType
    {
        public NoteType()
        {
            this.Notes = new List<Note>();
        }

        public short NoteTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
