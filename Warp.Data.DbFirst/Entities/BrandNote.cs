using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BrandNote
    {
        public int BrandNoteId { get; set; }
        public int BrandId { get; set; }
        public int NoteId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Note Note { get; set; }
    }
}