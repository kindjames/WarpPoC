using System;

namespace Warp.Data.Entities
{
    public class CustomerUser
    {
        public int CustomerUserId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int CustomerLinkStatusId { get; set; }
        public bool PrimaryCustomer { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
    }
}