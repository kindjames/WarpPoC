namespace Warp.Data.Entities
{
    public partial class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public int LocationStatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual LocationStatu LocationStatu { get; set; }
    }
}
