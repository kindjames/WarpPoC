namespace Warp.Data.Entities
{
    public partial class PandoraCache
    {
        public int PandoraCacheID { get; set; }
        public int AssessmentID { get; set; }
        public string Data { get; set; }
        public System.DateTime Expiry { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}
