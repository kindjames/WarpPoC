using System;

namespace Warp.Data.Entities
{
    public partial class BanClient
    {
        public int BanClientID { get; set; }
        public int ClientID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
