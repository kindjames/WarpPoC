namespace Warp.Data.Entities
{
    public partial class ClientLegacyUser : EntityBase
    {
        public int ClientLegacyID { get; set; }
        public int ClientID { get; set; }
        public int LegacyID { get; set; }
        public virtual Client Client { get; set; }
    }
}
