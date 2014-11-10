namespace Warp.Data.Entities
{
    public partial class CCTFurtherNote
    {
        public int CCTFurtherNotesID { get; set; }
        public int ClientContactTrackingID { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}
