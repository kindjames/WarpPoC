namespace Warp.Data.Entities
{
    public class ClientNote : EntityBase
    {
        public int ClientNoteId { get; set; }
        public int ClientId { get; set; }
        public int NoteId { get; set; }
        public virtual Client Client { get; set; }
        public virtual Note Note { get; set; }
    }
}