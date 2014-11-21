using System;

namespace Warp.Data.Entities
{
    public class BranchNote
    {
        public int BranchNoteId { get; set; }
        public int BranchId { get; set; }
        public int NoteId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Note Note { get; set; }
    }
}