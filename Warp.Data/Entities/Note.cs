using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Note
    {
        public Note()
        {
            this.AssessorNotes = new List<AssessorNote>();
            this.BranchNotes = new List<BranchNote>();
            this.BrandNotes = new List<BrandNote>();
            this.ClientNotes = new List<ClientNote>();
            this.FurtherNotes = new List<FurtherNote>();
            this.NoteCalendars = new List<NoteCalendar>();
            this.VisitNotes = new List<VisitNote>();
        }

        public int NoteID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int AdminID { get; set; }
        public short NoteTypeID { get; set; }
        public string Note1 { get; set; }
        public Nullable<short> DeactivatedByAdminID { get; set; }
        public Nullable<System.DateTime> DateDeactivated { get; set; }
        public string DeactivateReason { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
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
