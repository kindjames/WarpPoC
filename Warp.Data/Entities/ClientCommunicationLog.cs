using System;

namespace Warp.Data.Entities
{
    public class ClientCommunicationLog
    {
        public int ClientCommunicationLogId { get; set; }
        public byte CommunicationStatusId { get; set; }
        public int PersonId { get; set; }
        public byte CommunicationTypeId { get; set; }
        public string Details { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual CommunicationStatu CommunicationStatu { get; set; }
        public virtual CommunicationType CommunicationType { get; set; }
    }
}