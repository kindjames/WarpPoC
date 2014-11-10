namespace Warp.Data.Entities
{
    public partial class PersonClientContactTracking
    {
        public int PersonClientContactTrackingID { get; set; }
        public int PersonID { get; set; }
        public int ClientContactTrackingID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}
