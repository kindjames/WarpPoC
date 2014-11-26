using System;

namespace Warp.Data.DbFirst.Entities
{
    public class FurtherNote
    {
        public int FurthernoteId { get; set; }
        public int NoteId { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Note4 { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Note Note { get; set; }
    }
}