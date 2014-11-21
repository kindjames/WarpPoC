using System;

namespace Warp.Data.Entities
{
    public class AssessorNote
    {
        public int AssessorNoteId { get; set; }
        public int AssessorId { get; set; }
        public int NoteId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual Note Note { get; set; }
    }
}