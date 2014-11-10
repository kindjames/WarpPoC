namespace Warp.Data.Entities
{
    public partial class VisitNote
    {
        public int VisitNoteID { get; set; }
        public int VisitID { get; set; }
        public int NoteID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Note Note { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
