namespace Warp.Data.Entities
{
    public partial class ClientCallInLog
    {
        public int ClientCallInLogID { get; set; }
        public int ClientID { get; set; }
        public int CallInLogID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual CallInLog CallInLog { get; set; }
    }
}
