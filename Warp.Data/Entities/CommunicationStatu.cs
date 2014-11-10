using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class CommunicationStatu
    {
        public CommunicationStatu()
        {
            this.ClientCommunicationLogs = new List<ClientCommunicationLog>();
        }

        public byte CommunicationStatusID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
    }
}
