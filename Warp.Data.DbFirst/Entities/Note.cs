using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Note
    {
        public Note()
        {
            AssessorNotes = new List<AssessorNote>();
            BranchNotes = new List<BranchNote>();
            BrandNotes = new List<BrandNote>();
            ClientNotes = new List<ClientNote>();
            FurtherNotes = new List<FurtherNote>();
            NoteCalendars = new List<NoteCalendar>();
            VisitNotes = new List<VisitNote>();
        }

        public int NoteId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int AdminId { get; set; }
        public short NoteTypeId { get; set; }
        public string Note1 { get; set; }
        public short? DeactivatedByAdminId { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public string DeactivateReason { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorNote> AssessorNotes { get; set; }
        public virtual ICollection<BranchNote> BranchNotes { get; set; }
        public virtual ICollection<BrandNote> BrandNotes { get; set; }
        public virtual ICollection<ClientNote> ClientNotes { get; set; }
        public virtual ICollection<FurtherNote> FurtherNotes { get; set; }
        public virtual NoteType NoteType { get; set; }
        public virtual ICollection<NoteCalendar> NoteCalendars { get; set; }
        public virtual ICollection<VisitNote> VisitNotes { get; set; }
    }
}