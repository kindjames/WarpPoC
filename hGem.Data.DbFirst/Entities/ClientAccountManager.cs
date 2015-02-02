namespace Warp.Data.DbFirst.Entities
{
    public class ClientAccountManager : EntityBase
    {
        public int ClientAccountManagerId { get; set; }
        public int ClientId { get; set; }
        public int AccountManagerId { get; set; }
        public virtual Client Client { get; set; }
    }
}