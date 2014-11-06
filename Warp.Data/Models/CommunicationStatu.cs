using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CommunicationStatu
    {
        public CommunicationStatu()
        {
            this.ClientCommunicationLogs = new List<ClientCommunicationLog>();
        }

        public byte CommunicationStatusID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
    }
}
