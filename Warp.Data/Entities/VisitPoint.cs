namespace Warp.Data.Entities
{
    public partial class VisitPoint
    {
        public int VisitPointID { get; set; }
        public int VisitID { get; set; }
        public int PointID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Point Point { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
