using System;

namespace Warp.Data.Entities
{
    public class CustomerClient
    {
        public int CustomerClientId { get; set; }
        public int CustomerId { get; set; }
        public int ClientId { get; set; }
        public int CustomerLinkStatusId { get; set; }
        public bool PrimaryCustomer { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerLinkStatu CustomerLinkStatu { get; set; }
    }
}