namespace Warp.Data.Entities
{
    public partial class BrandNote
    {
        public int BrandNoteID { get; set; }
        public int BrandID { get; set; }
        public int NoteID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Note Note { get; set; }
    }
}
