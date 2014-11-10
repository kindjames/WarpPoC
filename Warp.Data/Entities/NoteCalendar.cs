namespace Warp.Data.Entities
{
    public partial class NoteCalendar
    {
        public int NoteCalendarID { get; set; }
        public int NoteID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Note Note { get; set; }
    }
}
