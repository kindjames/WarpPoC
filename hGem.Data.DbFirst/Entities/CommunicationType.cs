using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class CommunicationType
    {
        public CommunicationType()
        {
            ClientCommunicationLogs = new List<ClientCommunicationLog>();
            CommunicationPreferences = new List<CommunicationPreference>();
        }

        public byte CommunicationTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
        public virtual ICollection<CommunicationPreference> CommunicationPreferences { get; set; }
    }
}