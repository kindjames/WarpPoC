using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CommunicationType
    {
        public CommunicationType()
        {
            this.ClientCommunicationLogs = new List<ClientCommunicationLog>();
            this.CommunicationPreferences = new List<CommunicationPreference>();
        }

        public byte CommunicationTypeID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
        public virtual ICollection<CommunicationPreference> CommunicationPreferences { get; set; }
    }
}
