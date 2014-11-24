using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ClientContactTracking
    {
        public ClientContactTracking()
        {
            AdminClientContactTrackings = new List<AdminClientContactTracking>();
            CCTFurtherNotes = new List<CCTFurtherNote>();
            PersonClientContactTrackings = new List<PersonClientContactTracking>();
        }

        public int ClientContactTrackingId { get; set; }
        public int ClientId { get; set; }
        public short ContactTypeId { get; set; }
        public short ClientContactStatusId { get; set; }
        public DateTime DateOfContact { get; set; }
        public string Notes { get; set; }
        public string AddedByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientContactStatus ClientContactStatus { get; set; }
        public virtual ICollection<AdminClientContactTracking> AdminClientContactTrackings { get; set; }
        public virtual ICollection<CCTFurtherNote> CCTFurtherNotes { get; set; }
        public virtual ICollection<PersonClientContactTracking> PersonClientContactTrackings { get; set; }
    }
}