using System;

namespace Warp.Data.Entities
{
    public partial class Error
    {
        public System.Guid ErrorId { get; set; }
        public Nullable<int> CauseBy { get; set; }
        public string Url { get; set; }
        public string Exception { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
    }
}
