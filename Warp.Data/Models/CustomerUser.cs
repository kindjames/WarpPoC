using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CustomerUser
    {
        public int CustomerUserID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public int CustomerLinkStatusID { get; set; }
        public bool PrimaryCustomer { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
