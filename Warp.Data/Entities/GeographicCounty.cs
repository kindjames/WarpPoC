namespace Warp.Data.Entities
{
    public partial class GeographicCounty
    {
        public int GeographicCountyID { get; set; }
        public int GeographicRegionID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual GeographicRegion GeographicRegion { get; set; }
    }
}
