using System;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitNote
    {
        public int VisitNoteId { get; set; }
        public int VisitId { get; set; }
        public int NoteId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Note Note { get; set; }
        public virtual Visit Visit { get; set; }
    }
}