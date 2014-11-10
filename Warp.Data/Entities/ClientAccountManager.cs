namespace Warp.Data.Entities
{
    public partial class ClientAccountManager : EntityBase
    {
        public int ClientAccountManagerID { get; set; }
        public int ClientID { get; set; }
        public int AccountManagerID { get; set; }
        public virtual Client Client { get; set; }
    }
}