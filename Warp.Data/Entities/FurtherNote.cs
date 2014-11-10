namespace Warp.Data.Entities
{
    public partial class FurtherNote
    {
        public int FurthernoteID { get; set; }
        public int NoteID { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Note4 { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Note Note { get; set; }
    }
}
