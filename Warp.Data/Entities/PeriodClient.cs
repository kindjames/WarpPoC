namespace Warp.Data.Entities
{
    public partial class PeriodClient
    {
        public int PeriodClientID { get; set; }
        public int PeriodID { get; set; }
        public int ClientID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Period Period { get; set; }
    }
}
