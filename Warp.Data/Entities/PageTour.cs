namespace Warp.Data.Entities
{
    public partial class PageTour
    {
        public int PageTourID { get; set; }
        public int PageID { get; set; }
        public int TourID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Page Page { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
