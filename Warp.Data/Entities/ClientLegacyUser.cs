
namespace Warp.Data.Entities
{
    public class ClientLegacyUser : EntityBase
    {
        public int ClientLegacyId { get; set; }
        public int ClientId { get; set; }
        public int LegacyId { get; set; }
        public virtual Client Client { get; set; }
    }
}
